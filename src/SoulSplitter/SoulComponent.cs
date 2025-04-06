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
using SoulSplitter.Splitters;
using SoulSplitter.UiOld;
using SoulMemory;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using SoulMemory.Enums;
using SoulMemory.Games.Sekiro;
using SoulSplitter.Migrations;
using SoulMemory.Abstractions;
using SoulSplitter.UiV3;
using SoulSplitterUIv2.Utils;
using static System.Windows.Forms.AxHost;

namespace SoulSplitter;

public class SoulComponent : IComponent
{
    public const string Name = "SoulSplitter";


    private LiveSplitState _liveSplitState;
    private ISplitter? _splitter;
    private ITimerAdapter? _timerAdapter;
    private IGame _game = null!;
    private DateTime _lastFailedRefresh = DateTime.MinValue;
    public readonly MainWindow MainWindow;

    public SoulComponent(LiveSplitState state, bool shouldThrowOnInvalidInstallation = true,
        ITimerAdapter? timerAdapter = null)
    {
        if (shouldThrowOnInvalidInstallation)
        {
            ThrowIfInstallationInvalid();
        }

        MainWindow = new MainWindow();
        _liveSplitState = state;
        SelectGameFromLiveSplitState(_liveSplitState);

        if (App.Current == null)
        {
            App a = new App();
        }

        InitTimerAdapter(state, timerAdapter);
    }

    private void InitTimerAdapter(LiveSplitState state, ITimerAdapter? timerAdapter = null)
    {
        _timerAdapter = timerAdapter ?? new TimerAdapter(state, new Timer(new Sekiro(), (SoulSplitterUIv2.Ui.ViewModels.MainViewModel.MainViewModel)App.Current!.MainWindow.DataContext));
    }

    /// <summary>
    /// Called by livesplit every frame
    /// </summary>
    public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
    {
        MainWindow.Dispatcher.Invoke(() =>
        {
            try
            {
                _liveSplitState = state;

                //Timeout for 5 sec after a refresh fails
                if (DateTime.Now < _lastFailedRefresh.AddSeconds(5))
                {
                    return;
                }

                if (MainWindow.MainViewModel.ImportXml != null)
                {
                    ImportXml();
                }

                //Result will internally be added to the error list already.
                var result = UpdateSplitter(MainWindow.MainViewModel, state);
                if(result.IsErr)
                {
                    var err = result.GetErr();
                    if(
                        //For these error cases it is pointless to try again right away; it will only eat host CPU.
                        //Hence the timeout.
                        err.Reason is RefreshErrorReason.ProcessNotRunning or RefreshErrorReason.ProcessExited or RefreshErrorReason.ScansFailed or RefreshErrorReason.AccessDenied)
                    {
                        _lastFailedRefresh = DateTime.Now;
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Log(e);
                MainWindow.MainViewModel.AddException(e);
            }
        });
    }
    
    private Game? _selectedGame;
    private ResultErr<RefreshError> UpdateSplitter(MainViewModel mainViewModel, LiveSplitState state)
    {
        //Detect game change, initialize the correct splitter
        if (!_selectedGame.HasValue || _selectedGame != mainViewModel.SelectedGame)
        {
            //the splitter listens to livesplit events. Need to dispose to properly clean up and to make sure no elden ring events trigger in dark souls 3
            if (_splitter != null)
            {
                _splitter.Dispose();
                _splitter = null;
            }

            _selectedGame = mainViewModel.SelectedGame;
            switch (mainViewModel.SelectedGame)
            {
                default:
                    throw new InvalidOperationException("Splitter object is null");

                case Game.DarkSouls1:
                    _game = new SoulMemory.Games.DarkSouls1.DarkSouls1();
                    _splitter = new DarkSouls1Splitter(new TimerModel { CurrentState = state }, (SoulMemory.Games.DarkSouls1.DarkSouls1)_game, mainViewModel);
                    break;

                case Game.DarkSouls2:
                    _game = new SoulMemory.Games.DarkSouls2.DarkSouls2();
                    _splitter = new DarkSouls2Splitter(state, (SoulMemory.Games.DarkSouls2.DarkSouls2)_game);
                    break;

                case Game.DarkSouls3:
                    _game = new SoulMemory.Games.DarkSouls3.DarkSouls3();
                    _splitter = new DarkSouls3Splitter(state, (SoulMemory.Games.DarkSouls3.DarkSouls3)_game);
                    break;

                case Game.Sekiro:
                    _game = new SoulMemory.Games.Sekiro.Sekiro();
                    //_splitter = new SekiroSplitter(state, (SoulMemory.Games.Sekiro.Sekiro)_game);
                    break;

                case Game.EldenRing:
                    _game = new SoulMemory.Games.EldenRing.EldenRing();
                    _splitter = new EldenRingSplitter(state, (SoulMemory.Games.EldenRing.EldenRing)_game);
                    break;

                case Game.ArmoredCore6:
                    _game = new SoulMemory.Games.ArmoredCore6.ArmoredCore6();
                    _splitter = new ArmoredCore6Splitter(state, (SoulMemory.Games.ArmoredCore6.ArmoredCore6)_game);
                    break;
            }
            _splitter?.SetViewModel(mainViewModel);
        }

        if (mainViewModel.SelectedGame == Game.Sekiro)
        {
            return _timerAdapter!.Update();
        }

        return _splitter!.Update(mainViewModel);
    }

    public ISplitter? GetSplitter() => _splitter;

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
        if (_splitter != null)
        {
            _splitter.Dispose();
        }
    }
    #endregion

    #region Xml settings ==============================================================================================================

    private void ImportXml()
    {
        try
        {
            var xml = MainWindow.MainViewModel.ImportXml;
            MainWindow.MainViewModel.ImportXml = null; //Don't get stuck in an import loop

            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xml!);

            SetSettings(xmlDocument);
        }
        catch (Exception e)
        {
            Logger.Log(e);
            MainWindow.MainViewModel.AddException(e);
        }
    }

    /// <summary>
    /// Called when saving the compone
    /// </summary>
    public XmlNode GetSettings(XmlDocument document)
    {
        var root = document.CreateElement("Settings");
        MainWindow.Dispatcher.Invoke(() =>
        {
            {
                var xml = MainWindow.MainViewModel.Serialize();
                var fragment = document.CreateDocumentFragment();
                fragment.InnerXml = xml;
                root.AppendChild(fragment);
            }

            {
                var xml = Serialization.SerializeXml((SoulSplitterUIv2.Ui.ViewModels.MainViewModel.MainViewModel)App.Current.MainWindow.DataContext);
                var element = document.CreateElement("Uiv2");
                var uiv2fragment = document.CreateDocumentFragment();
                uiv2fragment.InnerXml = xml;
                element.AppendChild(uiv2fragment);
                root.AppendChild(element);
            }
        });
        return root;
    }

    /// <summary>
    /// Called when loading the settings from livesplit into the component
    /// </summary>
    public void SetSettings(XmlNode settings)
    {
        MainWindow.Dispatcher.Invoke(() =>
        {
            try
            {
                try
                {
                    Migrator.Migrate(settings);
                }
                catch (Exception migrationException)
                {
                    Logger.Log(migrationException);
                    MainWindow.MainViewModel.AddException(migrationException);
                }

                var mainViewModelXmlNode = SoulMemory.Extensions.GetChildNodeByName(settings, "MainViewModel");
                var vm = MainViewModel.Deserialize(mainViewModelXmlNode.OuterXml);
                MainWindow.MainViewModel = vm;
                _splitter?.SetViewModel(MainWindow.MainViewModel);

                var uiv2 = SoulMemory.Extensions.GetChildNodeByName(settings, "Uiv2");

                var vmui2 = Serialization.DeserializeXml<SoulSplitterUIv2.Ui.ViewModels.MainViewModel.MainViewModel>(uiv2.InnerXml);
                App.Current.MainWindow.DataContext = vmui2;
                InitTimerAdapter(_liveSplitState); //Reinitialize the timer adapter to make sure it has the correct view model
            }
            catch (Exception e)
            {
                MainWindow.MainViewModel = new MainViewModel();
                SelectGameFromLiveSplitState(_liveSplitState);

                Logger.Log(e);
                MainWindow.MainViewModel.AddException(e);
            }
        });
    }

    private Button? _customShowSettingsButton;
    public Control GetSettingsControl(LayoutMode mode)
    {
        var stackTrace = new StackTrace();
        var caller = stackTrace.GetFrame(1).GetMethod().Name;
        if (caller == "AddComponent")
        {
            MainWindow.ShowDialog();
        }

        if (_customShowSettingsButton == null)
        {
            _customShowSettingsButton = new Button();
            _customShowSettingsButton.Text = "SoulSplitter settings";
            _customShowSettingsButton.Click += (_, _) => MainWindow.Dispatcher.Invoke(() => MainWindow.ShowDialog());
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
    private void SelectGameFromLiveSplitState(LiveSplitState? s)
    {
        MainWindow.Dispatcher.Invoke(() =>
        {
            if (!string.IsNullOrWhiteSpace(s?.Run?.GameName))
            {
                var name = s!.Run!.GameName.ToLower().Replace(" ", "");
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

