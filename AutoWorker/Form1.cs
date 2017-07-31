using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;


namespace KeyPresser
{
    public partial class FormMain : Form
    {
        #region Mouse and Keyboard events

        private const int INPUT_KEYBOARD = 1;
        private const int KEYEVENTF_KEYDOWN = 0x0;
        private const int KEYEVENTF_KEYUP = 0x2;
        private const int KEYEVENTF_EXTENDEDKEY = 0x1;
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */

        #endregion

        #region Special keys text script

        private const string TAB = "//TAB";
        private const string CAPSLOCK = "//CAPSLOCK";
        private const string SHIFT = "//SHIFT";
        private const string CTRL = "//CTRL";
        private const string ALT = "//ALT";
        private const string SPACE = "//SPACE";
        private const string ENTER = "//ENTER";
        private const string BACKSPACE = "//BACKSPACE";

        #endregion

        #region DLL Libraries

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        // DLL for clicker
        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        #endregion

        /*public enum ClickType
        {
            click = 0,
            rightClick = 1,
            doubleClick = 2
        }

        public class ActionEntry
        {
            int x;
            int y;
            string text;
            int interval;
            ClickType type;
            public ActionEntry(int x, int y, string text, int interval, ClickType type)
            {
                this.x = x;
                this.y = y;
                this.text = text;
                this.interval = interval;
                this.type = type;
            }

            public int X
            {
                set { x = value; }
                get { return x; }
            }
            public int Y
            {
                set { y = value; }
                get { return y; }
            }
            public string Text
            {
                set { text = value; }
                get { return text; }
            }

            public int Interval
            {
                set { interval = value; }
                get { return interval; }
            }
            public ClickType Type
            {
                set { type = value; }
                get { return type; }
            }
        }*/

        public class SendKey
        {
            [StructLayout(LayoutKind.Sequential)]
            private struct MOUSEINPUT
            {
                public int dx;
                public int dy;
                public int mouseData;
                public int dwFlags;
                public int time;
                public int dwExtraInfo;
            };

            [StructLayout(LayoutKind.Sequential)]
            private struct KEYBDINPUT
            {
                public short wVk;
                public short wScan;
                public int dwFlags;
                public int time;
                public int dwExtraInfo;
            };

            [StructLayout(LayoutKind.Sequential)]
            private struct HARDWAREINPUT
            {
                public int uMsg;
                public short wParamL;
                public short wParamH;
            };

            [StructLayout(LayoutKind.Explicit)]
            private struct INPUT
            {
                [FieldOffset(0)]
                public int type;
                [FieldOffset(4)]
                public MOUSEINPUT no;
                [FieldOffset(4)]
                public KEYBDINPUT ki;
                [FieldOffset(4)]
                public HARDWAREINPUT hi;
            };

            [DllImport("user32.dll")]
            private extern static void SendInput(int nInputs, ref INPUT pInputs, int cbsize);
            [DllImport("user32.dll", EntryPoint = "MapVirtualKeyA")]
            private extern static int MapVirtualKey(int wCode, int wMapType);

            public void Send(Keys key, bool isEXTEND)
            {
                INPUT inp = new INPUT();
                inp.type = INPUT_KEYBOARD;
                inp.ki.wVk = (short)key;
                inp.ki.wScan = (short)MapVirtualKey(inp.ki.wVk, 0);
                inp.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYDOWN;
                inp.ki.time = 0;
                inp.ki.dwExtraInfo = 0;
                SendInput(1, ref inp, Marshal.SizeOf(inp));                

                inp.ki.dwFlags = ((isEXTEND) ? (KEYEVENTF_EXTENDEDKEY) : 0x0) | KEYEVENTF_KEYUP;
                SendInput(1, ref inp, Marshal.SizeOf(inp));
            }
        }

        public class CursorPoint
        {
            public int x;
            public int y;

            public CursorPoint(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        const int HOTKEY_F1 = 1;
        const int HOTKEY_F2 = 2;
        const int HOTKEY_F3 = 3;
        const int HOTKEY_F4 = 4;
        const int HOTKEY_F5 = 5;

        SendKey s = new SendKey();
        List<CursorPoint> pointsList = new List<CursorPoint>();
        Regex regex = new Regex("^[a-zA-Z0-9]$");
        Regex specialKeys = new Regex("^(" + TAB + "|" + CAPSLOCK + "|" + SHIFT + "|" + CTRL + "|"
            + ALT + "|" + SPACE + "|" + ENTER + "|" + BACKSPACE + ")$");
        int pointsCount = 1;

        public FormMain()
        {
            InitializeComponent();

            // Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            // Compute the addition of each combination of the keys you want to be pressed
            // ALT+CTRL = 1 + 2 = 3 , CTRL+SHIFT = 2 + 4 = 6...
            RegisterHotKey(this.Handle, HOTKEY_F1, 0, (int)Keys.F1);
            RegisterHotKey(this.Handle, HOTKEY_F2, 0, (int)Keys.F2);
            RegisterHotKey(this.Handle, HOTKEY_F3, 0, (int)Keys.F3);
            RegisterHotKey(this.Handle, HOTKEY_F4, 0, (int)Keys.F4);
            RegisterHotKey(this.Handle, HOTKEY_F5, 0, (int)Keys.F5);
        }

        #region Background Workers

        //background worker for auto typer
        private void bw_Type(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            char[] content = new char[textBoxContent.Text.Length];
            content = textBoxContent.Text.ToCharArray();

            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                foreach (char c in content)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    //special letters
                    if (!regex.IsMatch(c.ToString()))
                    {
                        switch (c)
                        {
                            case '!':
                                SendKeys.SendWait("+1");
                                break;
                            case '@':
                                SendKeys.SendWait("+2");
                                break;
                            case '#':
                                SendKeys.SendWait("+3");
                                break;
                            case '$':
                                SendKeys.SendWait("+4");
                                break;
                            case '%':
                                SendKeys.SendWait("{%}");
                                break;
                            case '^':
                                SendKeys.SendWait("+6");
                                break;
                            case '&':
                                SendKeys.SendWait("+7");
                                break;
                            case '*':
                                s.Send(Keys.Multiply, false);
                                break;
                            case '(':
                                SendKeys.SendWait("+9");
                                break;
                            case ')':
                                SendKeys.SendWait("+0");
                                break;
                            case '`':
                                s.Send(Keys.Oemtilde, false);
                                break;
                            case '~':
                                SendKeys.SendWait("{~}");
                                break;
                            case '-':
                                s.Send(Keys.Subtract, false);
                                break;
                            case '_':
                                SendKeys.SendWait("_");
                                break;
                            case '+':
                                s.Send(Keys.Add, false);
                                break;
                            case '=':
                                s.Send(Keys.Oemplus, false);
                                break;
                            case '[':
                                s.Send(Keys.OemOpenBrackets, false);
                                break;
                            case '{':
                                SendKeys.SendWait("{{}");
                                break;
                            case ']':
                                s.Send(Keys.OemCloseBrackets, false);
                                break;
                            case '}':
                                SendKeys.SendWait("{}}");
                                break;
                            case '\\':
                                s.Send(Keys.OemBackslash, false);
                                break;
                            case '|':
                                SendKeys.SendWait("|");
                                break;
                            case ';':
                                s.Send(Keys.OemSemicolon, false);
                                break;
                            case ':':
                                SendKeys.SendWait(":");
                                break;
                            case '\'':
                                s.Send(Keys.OemQuotes, false);
                                break;
                            case '"':
                                SendKeys.SendWait("\"");
                                break;
                            case ',':
                                s.Send(Keys.Oemcomma, false);
                                break;
                            case '<':
                                SendKeys.SendWait("<");
                                break;
                            case '.':
                                s.Send(Keys.OemPeriod, false);
                                break;
                            case '>':
                                SendKeys.SendWait(">");
                                break;
                            case '/':
                                s.Send(Keys.Divide, false);
                                break;
                            case '?':
                                SendKeys.SendWait("?");
                                break;
                            case ' ':
                                s.Send(Keys.Space, false);
                                break;
                        }
                    }
                    //upper letters
                    else if (Char.IsUpper(c))
                    {
                        SendKeys.SendWait("+{" + c + "}");
                    }
                    //lower letters and digits
                    else
                    {
                        Keys k = (Keys)char.ToUpper(c);
                        s.Send(k, true);
                    }

                    switch (c)
                    {
                        case '%':
                            s.Send(Keys.End, false);
                            break;
                    }

                    Thread.Sleep((int)numericUpDownCharacterInterval.Value);
                }

                Thread.Sleep((int)numericUpDownIntervalTyper.Value);
            }
        }



        //background worker for auto clicker
        private void bw_Click(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            bool leftCLick = true;

            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                //Left CLick
                if (radioButtonLeftClick.Checked)
                {
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    if (checkBoxDoubleClick.Checked)
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                    }
                }
                //Right CLick
                else if (radioButtonRightClick.Checked)
                {
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                    mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                    if (checkBoxDoubleClick.Checked)
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                    }
                }
                //Alternate
                else
                {
                    if (leftCLick)
                    {
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        if (checkBoxDoubleClick.Checked)
                        {
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        }

                        leftCLick = !leftCLick;
                    }
                    else
                    {
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                        if (checkBoxDoubleClick.Checked)
                        {
                            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                        }

                        leftCLick = !leftCLick;
                    }
                }

                Thread.Sleep((int)numericUpDownIntervalClicker.Value);
            }
        }

        //background worker for cursor mover
        private void bw_CursorMover(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                foreach (CursorPoint p in pointsList)
                {
                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    Cursor.Position = new Point(p.x, p.y);
                    Thread.Sleep((int)numericUpDownIntervalCursorMover.Value);
                }
            }
        }

        #endregion

        private void startClicker()
        {
            bwClick.WorkerSupportsCancellation = true;
            bwClick.WorkerReportsProgress = true;
            bwClick.DoWork += new DoWorkEventHandler(bw_Click);
            if (!bwClick.IsBusy)
            {
                bwClick.RunWorkerAsync();
            }

            foreach (Control c in groupBoxClicker.Controls)
            {
                c.Enabled = false;
            }
            btnStopClicker.Enabled = true;
        }

        private void stopClicker()
        {
            if (bwClick.WorkerSupportsCancellation)
            {
                bwClick.CancelAsync();
            }

            foreach (Control c in groupBoxClicker.Controls)
            {
                c.Enabled = true;
            }
            btnStopClicker.Enabled = false;
        }

        private void startTyper()
        {
            bwType.WorkerSupportsCancellation = true;
            bwType.WorkerReportsProgress = true;
            bwType.DoWork += new DoWorkEventHandler(bw_Type);
            if (!bwType.IsBusy)
            {
                bwType.RunWorkerAsync();
            }

            foreach (Control c in groupBoxTyper.Controls)
            {
                c.Enabled = false;
            }
            btnStopTyper.Enabled = true;
        }

        private void stopTyper()
        {
            if (bwType.WorkerSupportsCancellation)
            {
                bwType.CancelAsync();
            }

            foreach (Control c in groupBoxTyper.Controls)
            {
                c.Enabled = true;
            }
            btnStopTyper.Enabled = false;
        }

        private void startCursorMover()
        {
            bwCursorMover.WorkerSupportsCancellation = true;
            bwCursorMover.WorkerReportsProgress = true;
            bwCursorMover.DoWork += new DoWorkEventHandler(bw_CursorMover);

            pointsList.Clear();
            bool isX = true;
            int x = 0;
            List<Control> points = flowLayoutPanel.Controls.Cast<Control>().ToList();
            foreach (Control c in points)
            {
                if (c is NumericUpDown)
                {
                    NumericUpDown num = (NumericUpDown)c;
                    if (isX)
                    {
                        x = (int)num.Value;
                    }
                    else
                    {
                        pointsList.Add(new CursorPoint(x, (int)num.Value));
                    }

                    isX = !isX;
                }
            }

            if (!bwCursorMover.IsBusy)
            {
                bwCursorMover.RunWorkerAsync();
            }

            foreach (Control c in groupBoxCursorMover.Controls)
            {
                c.Enabled = false;
            }
            btnStopCursorMover.Enabled = true;
        }

        private void stopCursorMover()
        {
            if (bwCursorMover.WorkerSupportsCancellation)
            {
                bwCursorMover.CancelAsync();
            }

            foreach (Control c in groupBoxCursorMover.Controls)
            {
                c.Enabled = true;
            }
            btnStopCursorMover.Enabled = false;
        }

        private void startAll()
        {
            if (btnStartTyper.Enabled)
            {
                startTyper();
            }
            if (btnStartClicker.Enabled)
            {
                startClicker();
            }
            if (btnStartCursorMover.Enabled)
            {
                startCursorMover();
            }
        }

        private void stopAll()
        {
            if (!btnStartTyper.Enabled)
            {
                stopTyper();
            }
            if (!btnStartClicker.Enabled)
            {
                stopClicker();
            }
            if (!btnStartCursorMover.Enabled)
            {
                stopCursorMover();
            }
        }

        BackgroundWorker bwType = new BackgroundWorker();
        BackgroundWorker bwClick = new BackgroundWorker();
        BackgroundWorker bwCursorMover = new BackgroundWorker();

        //Catch pressing hot key events
        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            //Start or Stop Clicker
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_F1)
            {
                if (btnStartClicker.Enabled)
                {
                    startClicker();
                }
                else
                {
                    stopClicker();
                }
            }
            //Start or Stop Cursor mover
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_F2)
            {
                if (btnStartCursorMover.Enabled)
                {
                    startCursorMover();
                }
                else
                {
                    stopCursorMover();
                }
            }
            //Start or Stop Typer
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_F3)
            {
                if (btnStartTyper.Enabled)
                {
                    startTyper();
                }
                else
                {
                    stopTyper();
                }
            }
            //Start all
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_F4)
            {
                startAll();
            }
            //Stop all
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == HOTKEY_F5)
            {
                stopAll();
            }

            base.WndProc(ref m);
        }

        private void btnStartClicker_Click(object sender, EventArgs e)
        {
            startClicker();
        }

        private void btnStopClicker_Click(object sender, EventArgs e)
        {
            stopClicker();
        }

        private void btnStartCursorMover_Click(object sender, EventArgs e)
        {
            startCursorMover();
        }

        private void btnStopCursorMover_Click(object sender, EventArgs e)
        {
            stopCursorMover();
        }

        private void btnStartTyper_Click(object sender, EventArgs e)
        {
            startTyper();
        }

        private void btnStopTyper_Click(object sender, EventArgs e)
        {
            stopTyper();
        }

        private void btnStartAll_Click(object sender, EventArgs e)
        {
            startAll();
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            stopAll();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            List<Control> points = flowLayoutPanel.Controls.Cast<Control>().ToList();

            foreach (Control c in points)
            {
                if (c != lblX1 && c != lblY1
                    && c != numericUpDownX1 && c != numericUpDownY1)
                {
                    flowLayoutPanel.Controls.Remove(c);
                    c.Dispose();
                }
            }

            numericUpDownX1.Value = 0;
            numericUpDownY1.Value = 0;
            pointsCount = 1;
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            Label lblX = new Label();
            Label lblY = new Label();
            NumericUpDown numX = new NumericUpDown();
            NumericUpDown numY = new NumericUpDown();

            pointsCount++;
            //Labels properties
            lblX.Text = "X" + pointsCount.ToString() + ":";
            lblY.Text = "Y" + pointsCount.ToString() + ":";
            lblX.ForeColor = Color.Black;
            lblY.ForeColor = Color.Black;
            lblX.Width = 23;
            lblY.Width = 23;
            //NumericUpdowns properties
            numX.Width = 54;
            numY.Width = 54;
            numX.TextAlign = HorizontalAlignment.Center;
            numY.TextAlign = HorizontalAlignment.Center;
            numX.ThousandsSeparator = true;
            numY.ThousandsSeparator = true;
            numX.Minimum = 0;
            numY.Minimum = 0;
            numX.Maximum = 10000;
            numY.Maximum = 10000;

            flowLayoutPanel.Controls.Add(lblX);
            flowLayoutPanel.Controls.Add(numX);
            flowLayoutPanel.Controls.Add(lblY);
            flowLayoutPanel.Controls.Add(numY);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_F1);
            UnregisterHotKey(this.Handle, HOTKEY_F2);
            UnregisterHotKey(this.Handle, HOTKEY_F3);
            UnregisterHotKey(this.Handle, HOTKEY_F4);
            UnregisterHotKey(this.Handle, HOTKEY_F5);
        }
    }
}