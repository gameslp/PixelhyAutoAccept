using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoItX3Lib;

namespace AutoAccept
{
    public partial class PixelhyAutoAccept : Form
    {
        IntPtr handle;
        string WINDOW_NAME = "League of Legends";

        AutoItX3 au3 = new AutoItX3();

        public RECT rect;
        public struct RECT
        {
            public int left, top, right, bottom;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        int col;

        public PixelhyAutoAccept()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void PixelhyAutoAccept_Load(object sender, EventArgs e)
        {
            Thread AA = new Thread(auto_accept) { IsBackground = true };
            AA.Start();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void auto_accept()
        {
            while (true)
            {
                if (siticoneButton1.Text.Contains("disable"))
                {
                    getwindowrectangle();
                    if (siticoneCheckBox1.Checked == true)
                    {
                        col = au3.PixelGetColor(rect.left + 860, rect.top + 827);
                    }else if (siticoneCheckBox2.Checked == true)
                    {
                        col = au3.PixelGetColor(rect.left + 725, rect.top + 697);
                    }
                    else if (siticoneCheckBox3.Checked == true)
                    {
                        col = au3.PixelGetColor(rect.left + 584, rect.top + 555);
                    }
                    else if (siticoneCheckBox4.Checked == true)
                    {
                        col = au3.PixelGetColor(rect.left + 465, rect.top + 445);
                    }

                    if (col == 0x1E252A)
                    {
                        Thread.Sleep(20);
                        if (siticoneCheckBox1.Checked == true)
                        {
                            au3.MouseMove(rect.left + 860, rect.top + 827, 1);
                        }
                        else if (siticoneCheckBox2.Checked == true)
                        {
                            au3.MouseMove(rect.left + 725, rect.top + 697, 1);
                        }
                        else if (siticoneCheckBox3.Checked == true)
                        {
                            au3.MouseMove(rect.left + 584, rect.top + 555, 1);
                        }
                        else if (siticoneCheckBox4.Checked == true)
                        {
                            au3.MouseMove(rect.left + 465, rect.top + 445, 1);
                        }
                        au3.MouseClick("LEFT");
                        Thread.Sleep(20);
                        au3.MouseClick("LEFT");
                        Thread.Sleep(5000);
                    }
                }
                Thread.Sleep(20);
            }
        }

        void getwindowrectangle()
            {
                handle = FindWindow(null, WINDOW_NAME);
                GetWindowRect(handle, out rect);
            }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if (siticoneButton1.Text.Contains("enable"))
            {
                siticoneCheckBox1.Enabled = false;
                siticoneCheckBox2.Enabled = false;
                siticoneCheckBox3.Enabled = false;
                siticoneCheckBox4.Enabled = false;
                siticoneButton1.Text = "disable";
            }else if (siticoneButton1.Text.Contains("disable"))
            {
                siticoneCheckBox1.Enabled = true;
                siticoneCheckBox2.Enabled = true;
                siticoneCheckBox3.Enabled = true;
                siticoneCheckBox4.Enabled = true;
                siticoneButton1.Text = "enable";
            }
        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox1.Checked == true)
            {
                siticoneCheckBox2.Checked = false;
                siticoneCheckBox3.Checked = false;
                siticoneCheckBox4.Checked = false;
            }
        }

        private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox2.Checked == true)
            {
                siticoneCheckBox1.Checked = false;
                siticoneCheckBox3.Checked = false;
                siticoneCheckBox4.Checked = false;
            }
        }

        private void siticoneCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox3.Checked == true)
            {
                siticoneCheckBox1.Checked = false;
                siticoneCheckBox2.Checked = false;
                siticoneCheckBox4.Checked = false;
            }
        }

        private void siticoneCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCheckBox4.Checked == true)
            {
                siticoneCheckBox1.Checked = false;
                siticoneCheckBox2.Checked = false;
                siticoneCheckBox3.Checked = false;
            }
        }
    }
}
