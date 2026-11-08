// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using SoulSplitter.Plugin.Abstractions;
using SoulSplitter.Plugin.DependencyInjection;
using SoulSplitter.Plugin.Migrations;
using SoulSplitter.Plugin.Resources;
using SoulSplitter.Plugin.Serialization;
using SoulSplitter.Plugin.Timer;
using SoulSplitter.Plugin.Ui;
using SoulSplitter.Plugin.Ui.View;
using SoulSplitter.Plugin.Ui.ViewModels.MainViewModel;
using SoulSplitter.Plugin.Utils;
using SoulSplitter.SoulMemory.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using IServiceProvider = SoulSplitter.Plugin.DependencyInjection.IServiceProvider;

namespace SoulSplitter.Plugin.Livesplit;

public class LivesplitAdapter : IComponent
{
    public const string Name = "SoulSplitter";
    private readonly ComponentMode _componentMode;
    private readonly LiveSplitState _liveSplitState;
    private readonly IServiceProvider _serviceProvider;
    private readonly ISoulSplitterComponent _component;
    public readonly MainWindow MainWindow;

    public LivesplitAdapter(LiveSplitState liveSplitState, ComponentMode mode)
    {
        ThrowIfInstallationInvalid();

        var isActive = liveSplitState?.Run?.IsAutoSplitterActive() ?? false;

        _serviceProvider = GlobalServiceProvider.Instance;
        _liveSplitState = liveSplitState;
        _componentMode = mode;

        //init language first
        try
        {
            if (System.Windows.Application.Current == null)
            {
                var _ = new App();
            }
            _serviceProvider.GetService<ILanguageManager>().LoadLanguage(Language.English);            
        }
        catch(Exception e)
        {
            MessageBox.Show($"SoulSplitter loading language failed \r\n\r\n {e.ToString()}");
            throw;
        }

        try
        {
            MainWindow = _serviceProvider.GetService<MainWindow>();
            MainWindow.MainViewModel.SelectedGame = LivesplitStateToGameEnum(_liveSplitState);
        }
        catch(Exception e)
        {
            MessageBox.Show($"MainWindow init failed \r\n\r\n {e.ToString()}");
        }

        if (System.Windows.Application.Current!.MainWindow != MainWindow)
        {
            System.Windows.Application.Current!.MainWindow = MainWindow;
        }

        //This is probably wonky. Have to fix.
        if (_componentMode == ComponentMode.AutoSplitter)
        {
            var timerAdapter = new TimerAdapter(_liveSplitState, new Timer.Timer(_serviceProvider, MainWindow!.MainViewModel));
            _component = new TimerComponent(timerAdapter, MainWindow.MainViewModel);
        }
        else
        {
            _component = new LayoutComponent(MainWindow!.MainViewModel);
        }

        _references.Add(_referenceId);
    }

    private MainViewModel GetMainViewModelFromSettings(XmlNode? settings)
    {
        if (settings == null)
        {
            return new MainViewModel();
        }

        MainViewModel? mainViewModel = null;

        //Since we're still in the process of initialization, potentially we can't use TryAndHandleError yet

        //try to migrate; if it fails we can still try to deserialize
        Exception? migrationException = null;
        try
        {
            Migrator.Migrate(settings);
        }
        catch (Exception me)
        {
            migrationException = me;
        }

        //try to deserialize; if it fails we can initialize a new instance
        Exception? deserializationException = null;
        try
        {
            //var settingsNode = SoulMemory.Extensions.GetChildNodeByName(settings, "Uiv2");
            mainViewModel = MainViewModel.DeserializeXml(settings.InnerXml); // Serialization.DeserializeXml<MainViewModel>(settings.InnerXml);
        }
        catch (Exception de)
        {
            deserializationException = de;
        }

        mainViewModel ??= new MainViewModel();
        if (migrationException != null) { mainViewModel.AddException(migrationException); }
        if (deserializationException != null) { mainViewModel.AddException(deserializationException); }

        return mainViewModel;
    }

    private void MigrateSettingsAndDeserialize(XmlNode? settings)
    {
        var xml = settings?.InnerXml;
        if (xml == null || string.IsNullOrWhiteSpace(xml))
        {
            return;
        }

        //try to migrate; if it fails we can still try to deserialize
        try
        {
            Migrator.Migrate(settings!);
            xml = settings!.InnerXml;
        }
        catch (Exception me)
        {
            MainWindow.MainViewModel.AddException(me);
        }

        //try to deserialize; if it fails we can initialize a new instance
        try
        {
            var serializedModel = SerializedModel.Deserialize(xml);
            serializedModel.FillMainViewModel(MainWindow.MainViewModel);
        }
        catch (Exception de)
        {
            MainWindow.MainViewModel.AddException(de);
        }
    }

    /// <summary>
    /// Called by livesplit every frame
    /// </summary>
    public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
    {
        if (MainWindow == null || _component == null)
        {
            return;
        }
        MainWindow.Dispatcher.Invoke(_component.Update);
    }

    #region drawing ===================================================================================================================
    public IDictionary<string, Action> ContextMenuControls => new Dictionary<string, Action>();
    public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
    {
        if (_componentMode == ComponentMode.Layout && _component is ISoulSplitterLayoutComponent layoutComponent)
        {
            MainWindow?.Dispatcher.Invoke(() =>
            {
                layoutComponent.Draw(g, null, height, clipRegion);
                HorizontalWidth = layoutComponent.Width;
                VerticalHeight = layoutComponent.Height;
            });
        }
    }

    public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
    {
        if (_componentMode == ComponentMode.Layout && _component is ISoulSplitterLayoutComponent layoutComponent)
        {
            MainWindow?.Dispatcher.Invoke(() =>
            {
                layoutComponent.Draw(g, width, null, clipRegion);
                HorizontalWidth = layoutComponent.Width;
                VerticalHeight = layoutComponent.Height;
            });
        }
    }

    public string ComponentName => Name;
    public float HorizontalWidth { get; private set; } = 0;
    public float MinimumHeight { get; private set; } = 0;
    public float VerticalHeight { get; private set; } = 0;
    public float MinimumWidth { get; private set; } = 0;
    public float PaddingTop => 0;
    public float PaddingBottom => 0;
    public float PaddingLeft => 0;
    public float PaddingRight => 0;

    private Guid _referenceId = Guid.NewGuid();

    private static List<Guid> _references = new List<Guid>();
    public void Dispose()
    {
        _references.Remove(_referenceId);
        if(_references.Any())
        {
            MainWindow.MainViewModel.Reset();
        }

        //GC.SuppressFinalize(this);
    }
    #endregion

    #region Xml settings ==============================================================================================================
    
    /// <summary>
    /// Called when loading the settings from livesplit into the component
    /// </summary>
    public void SetSettings(XmlNode settings)
    {
        MigrateSettingsAndDeserialize(settings);

        //var mainViewModel = GetMainViewModelFromSettings(settings);
        //mainViewModel.SelectedGame = LivesplitStateToGameEnum(_liveSplitState);
        //MainWindow = new MainWindow(mainViewModel);
        //System.Windows.Application.Current!.MainWindow = MainWindow;
        //var timerAdapter = new TimerAdapter(_liveSplitState, new Timer.Timer(_serviceProvider, MainWindow.MainViewModel));
        //_component = new TimerComponent(timerAdapter, MainWindow.MainViewModel);

        UpdateLivesplitSplits();
    }

    /// <summary>
    /// Called when saving the component
    /// </summary>
    public XmlNode GetSettings(XmlDocument document)
    {
        var serializedModel = new SerializedModel(MainWindow.MainViewModel);
        var xml = SerializedModel.Serialize(serializedModel);

        var root = document.CreateElement("AutoSplitterSettings");
        var fragment = document.CreateDocumentFragment();
        fragment.InnerXml = xml;
        root.AppendChild(fragment);
        return root;
    }
    
    private Button? _customShowSettingsButton;
    public Control GetSettingsControl(LayoutMode mode)
    {
        var stackTrace = new StackTrace();
        var caller = stackTrace.GetFrame(1).GetMethod().Name;
        if (caller == "AddComponent")
        {
            UpdateLivesplitSplits();
            MainWindow!.ShowDialog();
        }

        if (_customShowSettingsButton == null)
        {
            _customShowSettingsButton = new Button();
            _customShowSettingsButton.Text = "SoulSplitter settings";
            _customShowSettingsButton.Click += (_, _) => MainWindow!.Dispatcher.Invoke(() => MainWindow.ShowDialog());
            _customShowSettingsButton.Paint += (_, _) =>
            {
                try
                {
                    var form = (Form)_customShowSettingsButton.Parent.Parent.Parent;
                    form.DialogResult = DialogResult.OK; //Ok triggers livesplit to save
                    form.Close();
                }
                catch (Exception e)
                {
                    Logger.Log(e);
                }
            };
        }

        return _customShowSettingsButton;
    }

    private void UpdateLivesplitSplits()
    {
        MainWindow!.Dispatcher.Invoke(() => {
            var splits = _liveSplitState?.Run?.Select(i => i.Name)?.ToList();
            splits ??= new List<string>(0);
            MainWindow!.MainViewModel!.UpdateLivesplitSplits(splits);
        });
    }

    private Game LivesplitStateToGameEnum(LiveSplitState s)
    {
        var name = s.Run!.GameName.ToLower().Replace(" ", "");
        return name switch
        {
            "darksouls" or "darksoulsremastered" => Game.DarkSouls1,
            "darksoulsii" => Game.DarkSouls2,
            "darksoulsiii" => Game.DarkSouls3,
            "sekiro" or "sekiro:shadowsdietwice" => Game.Sekiro,
            "eldenring" => Game.EldenRing,
            "armoredcore6" or "armoredcorevi:firesofrubicon" => Game.ArmoredCore6,
            "bloodborne" => Game.Bloodborne,
            _ => Game.DarkSouls1,
        };
    }

    #endregion

    #region validate installation

    private readonly List<string> _installedFiles =
    [
        "SoulSplitter.Plugin.dll",
        "SoulSplitter.SoulMemory.dll",
        "MaterialDesignColors.dll",
        "MaterialDesignThemes.Wpf.dll",
        "Microsoft.Xaml.Behaviors.dll",
        "SoulSplitter.soulmods.x64.dll",
        "SoulSplitter.soulmods.x86.dll",
        "SoulSplitter.soulmemory_rs.x64.dll",
        "SoulSplitter.soulmemory_rs.x86.dll",
        "SoulSplitter.soulmemory-rs.launcher.x64.exe",
        "SoulSplitter.soulmemory-rs.launcher.x86.exe"
    ];

    private void ThrowIfInstallationInvalid()
    {
        var assemblyPath = Assembly.GetAssembly(typeof(LivesplitAdapter)).Location;
        var directory = Path.GetDirectoryName(assemblyPath)!;

        var files = Directory.EnumerateFiles(directory).Select(i => Path.GetFileName(i)!.ToLower()).ToList();
        var missing = _installedFiles.Select(i => i.ToLower()).Except(files).ToList();

        if (missing.Any())
        {
            throw new FileNotFoundException($"Incomplete installation. Missing files: {string.Join(",", missing)}");
        }
    }

    #endregion
}

