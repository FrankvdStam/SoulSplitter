using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Testing.Tas;
using System.Windows.Forms;
using SoulMemory;

namespace Testing.Tas
{
    internal class DarkSouls1ToolAssistant
    {
        private Process _process;
        private SoulMemory.DarkSouls1.DarkSouls1 _darkSouls;
        private GameType _gameType;

        public DarkSouls1ToolAssistant(SoulMemory.DarkSouls1.DarkSouls1 darkSouls, GameType gameType)
        {
            _darkSouls = darkSouls;

            var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("darksouls"));
            if (process != null)
            {
                _process = process;
            }
            

            _gameType = gameType;
        }

        private void Focus()
        {
            User32.SetForegroundWindow(_process.MainWindowHandle);
        }

        #region Movement =================================================================================================================================

        private bool _sprint = false;
        public void Sprint()
        {
            Focus();
            _sprint = true;
            User32.SendKeyDown(User32.KeyCode.SPACE_BAR, User32.ScanCode.Space);
        }

        public void Roll()
        {
            Focus();
            User32.SendKeyPress(User32.KeyCode.SPACE_BAR, User32.ScanCode.Space);
        }
        
        private bool _forward = false;
        public void Forward()
        {

            Focus();
            _forward = true;
            User32.SendKeyDown(User32.KeyCode.KEY_W, User32.ScanCode.W);
        }

        private bool _backward = false;
        public void Backward()
        {
            Focus();
            _backward = true;
            User32.SendKeyDown(User32.KeyCode.KEY_S, User32.ScanCode.S);
        }

        private bool _left = false;
        public void Left()
        {
            Focus();
            _left = true;
            User32.SendKeyDown(User32.KeyCode.KEY_A, User32.ScanCode.A);
        }


        private bool _right = false;
        public void Right()
        {
            Focus();
            _right = true;
            User32.SendKeyDown(User32.KeyCode.KEY_D, User32.ScanCode.D);
        }

        public void Stop()
        {
            if (_forward)
            {
                User32.SendKeyUp(User32.KeyCode.KEY_W, User32.ScanCode.W);
            }

            if (_forward)
            {
                User32.SendKeyUp(User32.KeyCode.KEY_S, User32.ScanCode.S);
            }

            if (_left)
            {
                User32.SendKeyUp(User32.KeyCode.KEY_A, User32.ScanCode.A);
            }

            if (_right)
            {
                User32.SendKeyUp(User32.KeyCode.KEY_D, User32.ScanCode.D);
            }

            if (_sprint)
            {
                User32.SendKeyUp(User32.KeyCode.SPACE_BAR, User32.ScanCode.Space);
            }
        }

        public void Punch()
        {
            Focus();
            Keypress(User32.KeyCode.KEY_P, User32.ScanCode.P);
        }

        public void LightAttack()
        {
            Focus();
            Keypress(User32.KeyCode.KEY_I, User32.ScanCode.I);
        }

        public void Parry()
        {
            Focus();
            Keypress(User32.KeyCode.KEY_O, User32.ScanCode.O);
        }

        public void Menu()
        {
            Focus();
            Keypress(User32.KeyCode.ESC, User32.ScanCode.ESC);
        }
        #endregion

        #region items =================================================================================================================================

        public void UseItem()
        {
            Focus();
            Keypress(User32.KeyCode.KEY_R, User32.ScanCode.R);
        }

        #endregion

        #region Camera =================================================================================================================================
        public void MoveCamera(int x, int y, uint time = 0)
        {
            Focus();
            User32.SendMouseMove(x, y, time);
        }
        #endregion

        #region Menuing =================================================================================================================================

        public void SkipCutscene()
        {
            Focus();
            Keypress(User32.KeyCode.ESC, User32.ScanCode.ESC);
        }
        
        public void MainMenuContinue()
        {
            Focus();
            Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E, 200);
        
            //Ptde doesn't have "continue" in the main menu. Needs to click load and then click a savefile
            if (_gameType != GameType.DarkSoulsRemastered)
            {
                Thread.Sleep(3000);
                Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E, 200);
            }
            
            while (!_darkSouls.IsPlayerLoaded())
            {
                Thread.Sleep(100);
            }
            Thread.Sleep(3800);
        }

        public void MenuLeft()
        {
            if (_gameType == GameType.DarkSoulsRemastered)
            {
                Keypress(User32.KeyCode.LEFT, User32.ScanCode.Left);
            }
            else
            {
                Keypress(User32.KeyCode.KEY_C, User32.ScanCode.C);
            }
        }

        public void MenuRight()
        {
            if (_gameType == GameType.DarkSoulsRemastered)
            {
                Keypress(User32.KeyCode.RIGHT, User32.ScanCode.Right);
            }
            else
            {
                Keypress(User32.KeyCode.KEY_V, User32.ScanCode.V);
            }
        }

        public void MenuUp()
        {
            if (_gameType == GameType.DarkSoulsRemastered)
            {
                Keypress(User32.KeyCode.UP, User32.ScanCode.Up);
            }
            else
            {
                Keypress(User32.KeyCode.KEY_Z, User32.ScanCode.Z);
            }
        }

        public void MenuDown()
        {
            if (_gameType == GameType.DarkSoulsRemastered)
            {
                Keypress(User32.KeyCode.DOWN, User32.ScanCode.Down);
            }
            else
            {
                Keypress(User32.KeyCode.KEY_X, User32.ScanCode.X);
            }
        }

        public void MenuConfirm()
        {
            Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E);
        }

        public void SaveQuit()
        {
            Focus();
            
            Keypress(User32.KeyCode.ESC, User32.ScanCode.ESC);
            Thread.Sleep(500);

            MenuLeft();
            Thread.Sleep(50);

            MenuConfirm();
            Thread.Sleep(50);

            MenuUp();
            Thread.Sleep(50);

            MenuConfirm();
            Thread.Sleep(50);

            MenuLeft();
            Thread.Sleep(50);

            MenuConfirm();

            //Press any key
            Thread.Sleep(1500);
            MenuConfirm();

            if (_gameType == GameType.DarkSoulsRemastered)
            {
                //Clear offline message
                Thread.Sleep(1500);
                MenuConfirm();
            }
        }

        #endregion

        public void EquipArtoriasRing()
        {
            Focus();
            
            Keypress(User32.KeyCode.ESC, User32.ScanCode.ESC);
            Thread.Sleep(200);

            MenuRight();
            Thread.Sleep(50);

            MenuConfirm();
            Thread.Sleep(50);

            MenuLeft();
            Thread.Sleep(50);
            
            MenuUp();
            Thread.Sleep(50);

            //for (int i = 0; i < 2; i++)
            //{
            //    MenuDown();
            //    Thread.Sleep(50);
            //}

            for (int i = 0; i < 2; i++)
            {
                MenuConfirm();
                Thread.Sleep(50);
            }

            Keypress(User32.KeyCode.ESC, User32.ScanCode.ESC);
        }
        
        public void Interact()
        {
            Focus();
            Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E);
        }
        
        private void Keypress(User32.KeyCode keyCode, User32.ScanCode scanCode, int keyPressDelay = 32)
        {
            User32.SendKeyDown(keyCode, scanCode);
            Thread.Sleep(keyPressDelay);
            User32.SendKeyUp(keyCode, scanCode);
        }

    }
}
