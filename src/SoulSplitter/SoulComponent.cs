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

using System.Drawing;
using System.Windows.Forms;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Xml;
using SoulMemory;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using SoulMemory.Enums;
using SoulSplitter.Migrations;
using SoulMemory.Abstractions;
using SoulMemory.Games.Sekiro;
using SoulSplitter.Abstractions;
using SoulSplitter.Ui;
using SoulSplitter.Ui.View;
using SoulSplitter.Ui.ViewModels.MainViewModel;
using SoulSplitter.Utils;

namespace SoulSplitter;

public enum ComponentMode
{
    AutoSplitter,
    Layout,
}

public class SoulComponent : IComponent
{
    public const string Name = "SoulSplitter";


    private LiveSplitState _liveSplitState;
    private ComponentMode _componentMode;
    private ITimerAdapter? _timerAdapter;

    private IGame _game = null!;
    private DateTime _lastFailedRefresh = DateTime.MinValue;
    public readonly MainWindow MainWindow;

    public SoulComponent(
        LiveSplitState liveSplitState,
        ComponentMode mode)
    {
        ThrowIfInstallationInvalid();

        _liveSplitState = liveSplitState;
        _componentMode = mode;

        //App needs to be initialized before parsing settings - languagemanager needs to be available
        if (App.Current == null)
        {
            var _ = new App();
        }

        var xml = _liveSplitState.Run.AutoSplitterSettings;
        var mainViewModel = GetMainViewModelFromSettings(xml);
        MainWindow = new MainWindow(mainViewModel);
        App.Current!.MainWindow = MainWindow;
        _game = new Sekiro();
        _timerAdapter = new TimerAdapter(_liveSplitState, new Timer(_game, mainViewModel));
    }

    private MainViewModel GetMainViewModelFromSettings(XmlNode settings)
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
        if(migrationException != null) { mainViewModel.AddException(migrationException); }
        if(deserializationException != null) { mainViewModel.AddException(deserializationException); }

        return mainViewModel;
    }

    /// <summary>
    /// Called by livesplit every frame
    /// </summary>
    public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
    {
        MainWindow!.Dispatcher.Invoke(() =>
        {
            try
            {
                //Timeout for 5 sec after a refresh fails
                if (DateTime.Now < _lastFailedRefresh.AddSeconds(5))
                {
                    return;
                }

                var result = _timerAdapter!.Update();
                if (result.IsErr)
                {
                    //For these error cases it is pointless to try again right away; it will only eat host CPU, hence the timeout.
                    if (result.GetErr().Reason is 
                        RefreshErrorReason.ProcessNotRunning or 
                        RefreshErrorReason.ProcessExited or 
                        RefreshErrorReason.ScansFailed or 
                        RefreshErrorReason.AccessDenied)
                    {
                        _lastFailedRefresh = DateTime.Now;
                    }

                    MainWindow.MainViewModel.AddRefreshError(result.GetErr());
                }

                MainWindow.MainViewModel.TryAndHandleError(() =>
                {
                    if (MainWindow.MainViewModel.SelectedSplitType == SplitType.Position && _game is IPlayerPosition playerPosition)
                    {
                        MainWindow.MainViewModel.CurrentPosition = playerPosition.GetPlayerPosition();
                    }
                });
            }
            catch (Exception e)
            {
                Logger.Log(e);
                MainWindow.MainViewModel.AddException(e);
            }
        });
    }
    
    #region drawing ===================================================================================================================
    public IDictionary<string, Action> ContextMenuControls => new Dictionary<string, Action>();
    public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
    {
        //Soulsplitter doesn't draw to livesplit's window, but must implement the full interface.
    }

    public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
    {
        //Soulsplitter doesn't draw to livesplit's window, but must implement the full interface.
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
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        _timerAdapter?.Dispose();
    }
    #endregion

    #region Xml settings ==============================================================================================================
    /// <summary>
    /// Called when loading the settings from livesplit into the component
    /// </summary>
    public void SetSettings(XmlNode settings)
    {
        //SetSettings is ignored - settings are obtained in the constructor from livesplit's state object.
        return;
    }

    /// <summary>
    /// Called when saving the component
    /// </summary>
    public XmlNode GetSettings(XmlDocument document)
    {
        var root = document.CreateElement("Settings");
        MainWindow!.Dispatcher.Invoke(() =>
        {
            var xml = MainWindow.MainViewModel.SerializeXml();
            var fragment = document.CreateDocumentFragment();
            fragment.InnerXml = xml;
            root.AppendChild(fragment);
        });
        return root;
    }

    

    private Button? _customShowSettingsButton;
    public Control GetSettingsControl(LayoutMode mode)
    {
        var stackTrace = new StackTrace();
        var caller = stackTrace.GetFrame(1).GetMethod().Name;
        if (caller == "AddComponent")
        {
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

    /// <summary>
    /// Reads the game name from livesplit and tries to write the appropriate game to the view model
    /// </summary>
    private void SelectGameFromLiveSplitState(LiveSplitState s)
    {
        MainWindow!.Dispatcher.Invoke(() =>
        {
            if (!string.IsNullOrWhiteSpace(s.Run?.GameName))
            {
                var name = s.Run!.GameName.ToLower().Replace(" ", "");
                MainWindow.MainViewModel.SelectedGame = name switch
                {
                    "darksouls" or "darksoulsremastered" => Game.DarkSouls1,
                    "darksoulsii" => Game.DarkSouls2,
                    "darksoulsiii" => Game.DarkSouls3,
                    "sekiro" or "sekiro:shadowsdietwice" => Game.Sekiro,
                    "eldenring" => Game.EldenRing,
                    "armoredcore6" or "armoredcorevi:firesofrubicon" => Game.ArmoredCore6,
                    _ => MainWindow.MainViewModel.SelectedGame
                };
            }
        });
    }

    #endregion

    #region validate installation

    private readonly List<string> _installedFiles =
    [
        "SoulSplitter.dll",
        "SoulMemory.dll",
        "MaterialDesignColors.dll",
        "MaterialDesignThemes.Wpf.dll",
        "Microsoft.Xaml.Behaviors.dll",
        "soulmods_x64.dll",
        "soulmods_x86.dll",
        "soulmemory_rs_x64.dll",
        "soulmemory_rs_x86.dll",
        "launcher_x64.exe",
        "launcher_x86.exe"
    ];

    private void ThrowIfInstallationInvalid()
    {
        var assemblyPath = Assembly.GetAssembly(typeof(SoulComponent)).Location;
        var directory = Path.GetDirectoryName(assemblyPath)!;

        var files = Directory.EnumerateFiles(directory).Select(i => Path.GetFileName(i)!).ToList();
        var missing = _installedFiles.Except(files).ToList();

        if (missing.Any())
        {
            throw new FileNotFoundException($"Incomplete installation. Missing files: {string.Join(",", missing)}");
        }
    }

    #endregion
}

