using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class SignupForm : Form
    {
        private const string usersFilePath = "users.txt";

        public SignupForm()
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

        private void buttonExit_Click(object sender, EventArgs e)
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
            SigninForm obj = new SigninForm();
            obj.Show();
        }

        private void RegisterUser(string username, string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            string userData = $"{username};{hashedPassword}";
            File.AppendAllText(usersFilePath, userData + Environment.NewLine);
        }

        private bool IsSecureData(string username, string password)
        {
            int minLengthName = 4;

            int minLengthPass = 8;
            int minUpperCase = 1;
            int minLowerCase = 1;
            int minDigits = 1;

            if (username.Length < minLengthName)
            {
                return false;
            }

            if (password.Length < minLengthPass)
            {
                return false;
            }

            if (password.Count(char.IsUpper) < minUpperCase)
            {
                return false;
            }

            if (password.Count(char.IsLower) < minLowerCase)
            {
                return false;
            }

            if (password.Count(char.IsDigit) < minDigits)
            {
                return false;
            }

            return true;
        }

        private bool IsUserRegistered(string username)
        {
            // Перевіряємо, чи користувач з таким ім'ям вже зареєстрований
            // Читаємо дані з файлу і порівнюємо з переданим ім'ям
            string[] usersData = File.ReadAllLines(usersFilePath);

            foreach (string line in usersData)
            {
                string[] userData = line.Split(';');
                string storedUsername = userData[0];

                if (username == storedUsername)
                {
                    return true;
                }
            }

            return false;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxRepPass.Text)
            {
                MessageBox.Show("Passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (IsUserRegistered(textBoxUsername.Text))
            {
                MessageBox.Show("Username is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!IsSecureData(textBoxUsername.Text, textBoxPassword.Text))
            {
                labelPasswordTip.Visible = true;
                MessageBox.Show("Registration data isn't secure enough.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RegisterUser(textBoxUsername.Text, textBoxPassword.Text);
                this.Hide();
                MainForm obj = new MainForm(textBoxUsername.Text);
                obj.Show();
            }
        }
    }
}