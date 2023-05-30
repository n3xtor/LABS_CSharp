using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace LibraryManagement
{
    public partial class SigninForm : Form
    {
        private const string usersFilePath = "users.txt";

        public SigninForm()
        {
            InitializeComponent();
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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm obj = new SignupForm();
            obj.Show();
        }

        private bool ValidateUser(string username, string password)
        {
            // Основна логіка перевірки користувача
            // Читаємо дані з файлу і порівнюємо з переданими значеннями
            string[] usersData = File.ReadAllLines(usersFilePath);

            foreach (string line in usersData)
            {
                string[] userData = line.Split(';');
                string storedUsername = userData[0];
                string storedPassword = userData[1];

                if (username == storedUsername && password == storedPassword)
                {
                    return true;
                }
            }

            return false;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (!ValidateUser(textBoxUsername.Text, textBoxPassword.Text))
            {
                MessageBox.Show("Wrong data for login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                MainForm obj = new MainForm(textBoxUsername.Text);
                obj.Show();
            }
        }
    }
}
