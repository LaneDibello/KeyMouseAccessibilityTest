using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace KeyMouseAccessibilityTest
{
    [Flags]
    public enum dirBitFlags : byte
    {
        DOWN_LEFT = 0b00000001,
        DOWN = 0b00000010,
        DOWN_RIGHT = 0b00000100,
        LEFT = 0b00001000,
        RIGHT = 0b00010000,
        UP_LEFT = 0b00100000,
        UP = 0b01000000,
        UP_RIGHT = 0b10000000,
    }

    public partial class Form1 : Form
    {
        MouseOperations mouse;
        Dictionary<TextBox, Keys> directionKeys;

        public Form1()
        {
            InitializeComponent();

            mouse = new MouseOperations();

            directionKeys = new Dictionary<TextBox, Keys>()
            {
                {lUpLeft, Keys.NumPad7},
                {lUp, Keys.NumPad8},
                {lUpRight, Keys.NumPad9},
                {lLeft, Keys.NumPad4},
                {lRight, Keys.NumPad6},
                {lDownLeft, Keys.NumPad1},
                {lDown, Keys.NumPad2},
                {lDownRight, Keys.NumPad3},
                {lLeftClick, Keys.NumPad5},
                {lRightClick, Keys.NumPad0}
            };

            foreach (var dK in directionKeys)
            {
                dK.Key.Text = dK.Value.ToString().ToUpper();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (directionKeys.Values.Contains(e.KeyCode))
            {
                switch (directionKeys.First(k => k.Value == e.KeyCode).Key.Name)
                {
                    case "lDownLeft":
                        mouse.adjMovAtomic(dirBitFlags.DOWN_LEFT, true);
                        break;
                    case "lDown":
                        mouse.adjMovAtomic(dirBitFlags.DOWN, true);
                        break;
                    case "lDownRight":
                        mouse.adjMovAtomic(dirBitFlags.DOWN_RIGHT, true);
                        break;
                    case "lLeft":
                        mouse.adjMovAtomic(dirBitFlags.LEFT, true);
                        break;
                    case "lLeftClick":
                        MouseOperations.LeftDown();
                        break;
                    case "lRight":
                        mouse.adjMovAtomic(dirBitFlags.RIGHT, true);
                        break;
                    case "lUpLeft":
                        mouse.adjMovAtomic(dirBitFlags.UP_LEFT, true);
                        break;
                    case "lUp":
                        mouse.adjMovAtomic(dirBitFlags.UP, true);
                        break;
                    case "lUpRight":
                        mouse.adjMovAtomic(dirBitFlags.UP_RIGHT, true);
                        break;
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

            if (directionKeys.Values.Contains(e.KeyCode))
            {
                switch (directionKeys.First(k => k.Value == e.KeyCode).Key.Name)
                {
                    case "lDownLeft":
                        mouse.adjMovAtomic(dirBitFlags.DOWN_LEFT, false);
                        break;
                    case "lDown":
                        mouse.adjMovAtomic(dirBitFlags.DOWN, false);
                        break;
                    case "lDownRight":
                        mouse.adjMovAtomic(dirBitFlags.DOWN_RIGHT, false);
                        break;
                    case "lLeft":
                        mouse.adjMovAtomic(dirBitFlags.LEFT, false);
                        break;
                    case "lLeftClick":
                        MouseOperations.LeftDown();
                        break;
                    case "lRight":
                        mouse.adjMovAtomic(dirBitFlags.RIGHT, false);
                        break;
                    case "lUpLeft":
                        mouse.adjMovAtomic(dirBitFlags.UP_LEFT, false);
                        break;
                    case "lUp":
                        mouse.adjMovAtomic(dirBitFlags.UP, false);
                        break;
                    case "lUpRight":
                        mouse.adjMovAtomic(dirBitFlags.UP_RIGHT, false);
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MouseOperations.SetCursorPos(Convert.ToInt32(Cursor.Position.X + mouse.mouseSpeed * mouse.x_dir), Convert.ToInt32(Cursor.Position.Y + mouse.mouseSpeed * mouse.y_dir));

        }



        private void keybindEnter(object sender, EventArgs e)
        {
            //TextBox tb = sender as TextBox;
            Panel p = sender as Panel;
            p.BorderStyle = BorderStyle.FixedSingle;
            p.BackColor = Color.LightBlue;
            p.Controls[0].Select();
        }

        private void keybindLeave(object sender, EventArgs e)
        {
            //TextBox tb = sender as TextBox;
            Panel p = sender as Panel;
            p.BorderStyle = BorderStyle.None;
            p.BackColor = Form1.DefaultBackColor;
        }

        private void kebindPress(object sender, KeyEventArgs e)
        {
            TextBox tb = sender as TextBox;
            directionKeys[tb] = e.KeyCode;
        }
    }
}