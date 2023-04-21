using System.Runtime.InteropServices;

namespace KeyMouseAccessibilityTest
{
    [Flags]
    public enum dirBitFlags : byte
    {
        DOWN_LEFT  = 0b00000001,
        DOWN       = 0b00000010,
        DOWN_RIGHT = 0b00000100,
        LEFT       = 0b00001000,
        RIGHT      = 0b00010000,
        UP_LEFT    = 0b00100000,
        UP         = 0b01000000,
        UP_RIGHT   = 0b10000000,
    }


    public partial class Form1 : Form
    {
        //Grab Set cursor Position from user32.dll
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        //Grab The Mouse Event Function from user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSE_EVENT_MOVE = 0x0001;
        private const int MOUSE_EVENT_LEFTDOWN = 0x0002;
        private const int MOUSE_EVENT_LEFTUP = 0x0004;
        private const int MOUSE_EVENT_RIGHTDOWN = 0x0008;
        private const int MOUSE_EVENT_RIGHTUP = 0x0010;
        private const int MOUSE_EVENT_MIDDLEDOWN = 0x0020;
        private const int MOUSE_EVENT_MIDDLEUP = 0x0040;
        private const int MOUSE_EVENT_ABSOLUTE = 0x8000;

        int mouseSpeed = 2;

        // Left clicks the mouse
        public static void LeftDown()
        {
            mouse_event(MOUSE_EVENT_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        public static void LeftUp()
        {
            mouse_event(MOUSE_EVENT_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
        }

        double x_dir = 0;
        double y_dir = 0;

        dirBitFlags curr_mov;

        private void adjMovAtomic(dirBitFlags f, bool set)
        {
            lock(this)
            {
                if (set) curr_mov |= f;
                else curr_mov &= ~f;

                int x_mag = (int)(
                    ((int)(curr_mov & dirBitFlags.DOWN_RIGHT) >> 2) +
                    ((int)(curr_mov & dirBitFlags.RIGHT) >> 4) +
                    ((int)(curr_mov & dirBitFlags.UP_RIGHT) >> 7) -
                    ((int)(curr_mov & dirBitFlags.DOWN_LEFT) >> 0) - 
                    ((int)(curr_mov & dirBitFlags.LEFT) >> 3) -
                    ((int)(curr_mov & dirBitFlags.UP_LEFT) >> 5));

                int y_mag = (int)(
                    ((int)(curr_mov & dirBitFlags.DOWN_RIGHT) >> 2) +
                    ((int)(curr_mov & dirBitFlags.DOWN) >> 1) +
                    ((int)(curr_mov & dirBitFlags.DOWN_LEFT) >> 0) -
                    ((int)(curr_mov & dirBitFlags.UP_RIGHT) >> 7) -
                    ((int)(curr_mov & dirBitFlags.UP) >> 6) -
                    ((int)(curr_mov & dirBitFlags.UP_LEFT) >> 5));

                double mag = Math.Sqrt(x_mag * x_mag + y_mag * y_mag);
                if (mag <= 0)
                {
                    x_dir = 0;
                    y_dir = 0;
                }
                else
                {
                    x_dir = x_mag / mag;
                    y_dir = y_mag / mag;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1: 
                    adjMovAtomic(dirBitFlags.DOWN_LEFT, true);
                    break;
                case Keys.NumPad2:
                    adjMovAtomic(dirBitFlags.DOWN, true);
                    break;
                case Keys.NumPad3:
                    adjMovAtomic(dirBitFlags.DOWN_RIGHT, true);
                    break;
                case Keys.NumPad4:
                    adjMovAtomic(dirBitFlags.LEFT, true);
                    break;
                case Keys.NumPad5:  
                    LeftDown();
                    break;
                case Keys.NumPad6:
                    adjMovAtomic(dirBitFlags.RIGHT, true);
                    break;
                case Keys.NumPad7:
                    adjMovAtomic(dirBitFlags.UP_LEFT, true);
                    break;
                case Keys.NumPad8:
                    adjMovAtomic(dirBitFlags.UP, true);
                    break;
                case Keys.NumPad9:
                    adjMovAtomic(dirBitFlags.UP_RIGHT, true);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }


            pressedDebug.Text = $"{e.KeyCode} pressed";
            xydirLabel.Text = $"x:{x_dir}, y:{y_dir}";
            xymovLabel.Text = $"currmov: {Convert.ToString((byte)curr_mov, 2)}";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    adjMovAtomic(dirBitFlags.DOWN_LEFT, false);
                    break;
                case Keys.NumPad2:
                    adjMovAtomic(dirBitFlags.DOWN, false);
                    break;
                case Keys.NumPad3:
                    adjMovAtomic(dirBitFlags.DOWN_RIGHT, false);
                    break;
                case Keys.NumPad4:
                    adjMovAtomic(dirBitFlags.LEFT, false);
                    break;
                case Keys.NumPad5:
                    LeftUp();
                    break;
                case Keys.NumPad6:
                    adjMovAtomic(dirBitFlags.RIGHT, false);
                    break;
                case Keys.NumPad7:
                    adjMovAtomic(dirBitFlags.UP_LEFT, false);
                    break;
                case Keys.NumPad8:
                    adjMovAtomic(dirBitFlags.UP, false);
                    break;
                case Keys.NumPad9:
                    adjMovAtomic(dirBitFlags.UP_RIGHT, false);
                    break;
            }
            pressedDebug.Text = "Nothing pressed";
            xydirLabel.Text = $"x:{x_dir}, y:{y_dir}";
            xymovLabel.Text = $"currmov: {Convert.ToString((byte)curr_mov, 2)}";
        }

        //Debug output showing mouse position of Labels
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cursorX.Text = $"X = {Cursor.Position.X}";
            cursorY.Text = $"Y = {Cursor.Position.Y}";
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetCursorPos(Convert.ToInt32(Cursor.Position.X + mouseSpeed*x_dir), Convert.ToInt32(Cursor.Position.Y + mouseSpeed * y_dir));
        }
    }
}