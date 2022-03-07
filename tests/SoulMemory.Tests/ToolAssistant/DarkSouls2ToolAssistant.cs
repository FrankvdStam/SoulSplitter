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
using WindowsInput;
using WindowsInput.Native;

namespace Testing.Tas
{
    internal class DarkSouls2ToolAssistant
    {
        private Process _process;
        //private DarkSouls2 _darkSouls;

        //private const int LoadTimeMillis = 7000;

        public DarkSouls2ToolAssistant(GameType gameType)
        {
            //_darkSouls = darkSouls;

            var process = Process.GetProcesses().FirstOrDefault(i => i.ProcessName.ToLower().StartsWith("darksouls"));
            if (process != null)
            {
                _process = process;
            }
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
            Keypress(User32.KeyCode.KEY_H, User32.ScanCode.H);
        }

        public void WrathOfGods()
        {
            Focus();
            Keypress(User32.KeyCode.KEY_U, User32.ScanCode.U);
            Thread.Sleep(2000);
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
            Thread.Sleep(1000);
        }
        
        public void MainMenuContinue()
        {
            Focus();
            Thread.Sleep(400);
            Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E, 200);
            Thread.Sleep(400);
            Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E, 200); 
            Thread.Sleep(7500);
        }

        public void MenuLeft()
        {
            Keypress(User32.KeyCode.LEFT, User32.ScanCode.Left);
        }

        public void MenuRight()
        {
            Keypress(User32.KeyCode.RIGHT, User32.ScanCode.Right);
        }

        public void MenuUp()
        {
            Keypress(User32.KeyCode.UP, User32.ScanCode.Up);
            
        }

        public void MenuDown()
        {
            Keypress(User32.KeyCode.DOWN, User32.ScanCode.Down);
        }

        public void MenuConfirm()
        {
            Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E);
        }

        public void SaveQuit()
        {
            Focus();

            while (true)
            {
                Thread.Sleep(2000);
                MenuLeft();
            }


            //Clear any items/okay messages
            for (int i = 0; i < 3; i++)
            {
                Interact();
                Thread.Sleep(400);
            }

            Keypress(User32.KeyCode.ESC, User32.ScanCode.ESC);
            Thread.Sleep(1000);

            MenuLeft();
            Thread.Sleep(600);

            MenuUp();
            Thread.Sleep(600);

            MenuConfirm();
            Thread.Sleep(600);

            MenuLeft();
            Thread.Sleep(600);

            MenuConfirm();
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
            //Keypress(User32.KeyCode.KEY_E, User32.ScanCode.E);
        }
        
        private void Keypress(User32.KeyCode keyCode, User32.ScanCode scanCode, int keyPressDelay = 32)
        {
            User32.SendKeyDown(keyCode, scanCode);
            Thread.Sleep(keyPressDelay);
            User32.SendKeyUp(keyCode, scanCode);
        }

    }
}
