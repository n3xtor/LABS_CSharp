using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        bool sidebarExpand;
        public MainForm(string nameValue)
        {
            InitializeComponent();
            buttonAccount.Text = nameValue;
        }

        // пересування вікна
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            // встановити максимальний і мінімальний розмір sidebar panel
            if (sidebarExpand)
            {
                // якщо sidebar відкритий 
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();
                    buttonAccleft.Visible = false;
                    buttonAccount.ForeColor = Color.FromArgb(255, 128, 0);
                }             
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                    // приховування елементів sidebar
                    buttonAccleft.Visible = true;
                    buttonAccount.ForeColor = Color.White;
                }
            }
        }

        private void buttonMenu_click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void buttonAccleft_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninForm obj = new SigninForm();
            obj.Show();
        }
    }
}
