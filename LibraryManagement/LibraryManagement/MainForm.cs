using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class MainForm : Form
    {
        private List<Book> books;
        private List<Book> userBooks;

        //Sidebar
        bool sidebarExpand;
        public MainForm(string nameValue)
        {
            InitializeComponent();
            buttonAccount.Text = nameValue;
            sidebar.BringToFront();
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

        // Exit кнопка
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Minimize кнопка
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
                    buttonLibrary.ForeColor = Color.FromArgb(255, 128, 0);
                    buttoMylibrary.ForeColor = Color.FromArgb(255, 128, 0);
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
                    buttonLibrary.ForeColor = Color.White;
                    buttoMylibrary.ForeColor = Color.White;
                }
            }
        }

        private void buttonMenu_click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        // Logout кнопка
        private void buttonAccleft_Click(object sender, EventArgs e)
        {
            this.Hide();
            SigninForm obj = new SigninForm();
            obj.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Зчитуємо книжки з .txt файлу
            books = LoadBooksFromFile("library.txt");

            // Відображаємо книжки в DataGridView
            dgvLibrary.DataSource = books;
            LoadUserLibrary(buttonAccount.Text);

            UpdateUserRatings();
        }

        private List<Book> LoadBooksFromFile(string filePath)
        {
            List<Book> loadedBooks = new List<Book>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    string title = parts[0];
                    string author = parts[1];
                    string genre = parts[2];
                    int year = int.Parse(parts[3]);
                    int pageCount = int.Parse(parts[4]);
                    string language = parts[5];

                    Book book = new Book(title, author, genre, year, pageCount, language);
                    loadedBooks.Add(book);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred when reading books from a file: " + ex.Message);
            }

            return loadedBooks;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи була вибрана книжка
            if (dgvLibrary.SelectedRows.Count > 0)
            {
                // Отримуємо обраний рядок DataGridView
                DataGridViewRow selectedRow = dgvLibrary.SelectedRows[0];

                // Отримуємо книжку, яку потрібно додати
                Book selectedBook = (Book)selectedRow.DataBoundItem;

                if (IsBookAlreadyAdded(buttonAccount.Text, selectedBook))
                {
                    MessageBox.Show("This book has already been added to the file.");
                }
                else
                {
                    // Додаємо книжку в файл користувача
                    AddBookToFile(buttonAccount.Text, selectedBook);

                    MessageBox.Show("The book has been successfully added to the file!");
                    RefreshUserLibraryDataGridView();
                    UpdateUserRatings();
                }
            }
            else
            {
                MessageBox.Show("Please select a book from the list.");
            }
        }

        private bool IsBookAlreadyAdded(string username, Book book)
        {
            string userFilePath = $"userLibrary_{username}.txt"; // Шлях до файлу користувача
            if (!File.Exists(userFilePath))
            {
                File.Create(userFilePath).Close(); // Створити файл, якщо він не існує
            }
            string[] lines = File.ReadAllLines(userFilePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length >= 6) // Перевірка розміру масиву parts
                {
                    string title = parts[0];

                    string author = parts[1];
                    string genre = parts[2];
                    int year = int.Parse(parts[3]);
                    int pageCount = int.Parse(parts[4]);
                    string language = parts[5];

                    if (book.Title == title && book.Author == author && book.Genre == genre && book.Year == year && book.PageCount == pageCount && book.Language == language)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void AddBookToFile(string username, Book book)
        {
            string userFilePath = $"userLibrary_{username}.txt"; // Створюємо ім'я файлу на основі імені користувача

            try
            {
                using (StreamWriter writer = new StreamWriter(userFilePath, true))
                {
                    writer.WriteLine($"{book.Title};{book.Author};{book.Genre};{book.Year};{book.PageCount};{book.Language}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the book to the file: " + ex.Message);
            }
        }
        private void SearchBooks(string author, string genre, string year, string language)
        {
            List<Book> searchResults = new List<Book>();

            foreach (Book book in books)
            {
                if (string.IsNullOrEmpty(author) || book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(genre) || book.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                    {
                        if (string.IsNullOrEmpty(year) || book.Year.ToString().Equals(year))
                        {
                            if (string.IsNullOrEmpty(language) || book.Language.Equals(language, StringComparison.OrdinalIgnoreCase))
                            {
                                searchResults.Add(book);
                            }
                        }
                    }
                }
            }

            dgvLibrary.DataSource = searchResults;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string author = textBoxAuthor.Text;
            string genre = textBoxGenre.Text;
            string year = textBoxYear.Text;
            string language = textBoxLanguage.Text;

            SearchBooks(author, genre, year, language);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dgvLibrary.DataSource = books;
            textBoxAuthor.Text = "";
            textBoxGenre.Text = "";
            textBoxYear.Text = "";
            textBoxLanguage.Text = "";
        }
        private void buttonAccount_Click(object sender, EventArgs e)
        {
            sidebarSwitcher.SelectTab("tabAccount");
            labelMain.Text = "ACCOUNT";
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            sidebarSwitcher.SelectTab("tabLibrary");
            labelMain.Text = "LIBRARY";
        }

        private void buttonMylibrary_Click(object sender, EventArgs e)
        {
            sidebarSwitcher.SelectTab("tabMylibrary");
            labelMain.Text = "MY LIBRARY";
        }

        //
        //UserLibrary
        private void LoadUserLibrary(string username)
        {
            string userFilePath = $"userLibrary_{username}.txt"; // Шлях до файлу користувача

            if (!File.Exists(userFilePath))
            {
                return;
            }

            try
            {
                userBooks = LoadUserBooksFromFile(userFilePath);

                // Відображаємо книжки в DataGridView
                dgvUserLibrary.DataSource = null; // Спочатку очищаємо даних DataGridView
                dgvUserLibrary.DataSource = userBooks;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user library: " + ex.Message);
            }
        }

        private List<Book> LoadUserBooksFromFile(string filePath)
        {
            List<Book> loadedBooks = new List<Book>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    string title = parts[0];
                    string author = parts[1];
                    string genre = parts[2];
                    int year = int.Parse(parts[3]);
                    int pageCount = int.Parse(parts[4]);
                    string language = parts[5];

                    Book book = new Book(title, author, genre, year, pageCount, language);
                    loadedBooks.Add(book);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred when reading books from a file: " + ex.Message);
            }

            return loadedBooks;
        }
        private void RefreshUserLibraryDataGridView()
        {
            // Завантажуємо книжки користувача
            LoadUserLibrary(buttonAccount.Text);

            // Перезавантажуємо дані в DataGridView
            dgvUserLibrary.Refresh();
        }

        private void SearchUserBooks(string author, string genre, string year, string language)
        {
            List<Book> searchResults = new List<Book>();

            foreach (Book book in userBooks)
            {
                if (string.IsNullOrEmpty(author) || book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrEmpty(genre) || book.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                    {
                        if (string.IsNullOrEmpty(year) || book.Year.ToString().Equals(year))
                        {
                            if (string.IsNullOrEmpty(language) || book.Language.Equals(language, StringComparison.OrdinalIgnoreCase))
                            {
                                searchResults.Add(book);
                            }
                        }
                    }
                }
            }

            dgvUserLibrary.DataSource = null; // Спочатку очищаємо дані DataGridView
            dgvUserLibrary.DataSource = searchResults;
        }

        private void buttonUserSearch_Click(object sender, EventArgs e)
        {
            string author = textBoxUserAuthor.Text;
            string genre = textBoxUserGenre.Text;
            string year = textBoxUserYear.Text;
            string language = textBoxUserLanguage.Text;

            SearchUserBooks(author, genre, year, language);
        }

        private void buttonUserClear_Click(object sender, EventArgs e)
        {
            dgvUserLibrary.DataSource = userBooks;
            textBoxUserAuthor.Text = "";
            textBoxUserGenre.Text = "";
            textBoxUserYear.Text = "";
            textBoxUserLanguage.Text = "";
        }

        private void DeleteBookFromFile(string username, Book book)
        {
            string userFilePath = $"userLibrary_{username}.txt"; // Шлях до файлу користувача

            try
            {
                // Зчитуємо всі рядки з файлу
                string[] lines = File.ReadAllLines(userFilePath);

                // Записуємо знову всі рядки, крім рядка, що містить видаляються книжку
                using (StreamWriter writer = new StreamWriter(userFilePath, false))
                {
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length >= 6) // Перевірка розміру масиву parts
                        {
                            string title = parts[0];
                            string author = parts[1];
                            string genre = parts[2];
                            int year = int.Parse(parts[3]);
                            int pageCount = int.Parse(parts[4]);
                            string language = parts[5];

                            if (book.Title != title || book.Author != author || book.Genre != genre || book.Year != year || book.PageCount != pageCount || book.Language != language)
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the book from the file: " + ex.Message);
            }
        }

        private void dgvUserLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи була вибрана книжка
            if (dgvUserLibrary.SelectedRows.Count > 0)
            {
                // Отримуємо обраний рядок DataGridView
                DataGridViewRow selectedRow = dgvUserLibrary.SelectedRows[0];

                // Отримуємо книжку, яку потрібно видалити
                Book selectedBook = (Book)selectedRow.DataBoundItem;

                // Видаляємо книжку з файлу користувача
                DeleteBookFromFile(buttonAccount.Text, selectedBook);

                MessageBox.Show("The book has been successfully deleted from the user's file!");
                RefreshUserLibraryDataGridView();
                UpdateUserRatings();
            }
            else
            {
                MessageBox.Show("Please select a book from the list.");
            }
        }
        //

        private Dictionary<string, int> CalculateUserRatings()
        {
            Dictionary<string, int> userRatings = new Dictionary<string, int>();

            foreach (string filePath in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "userLibrary_*.txt"))
            {
                string username = Path.GetFileNameWithoutExtension(filePath).Replace("userLibrary_", "");

                try
                {
                    int bookCount = File.ReadAllLines(filePath).Length;
                    userRatings.Add(username, bookCount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while calculating the rating for user '{username}': {ex.Message}");
                }
            }

            return userRatings;
        }

        private void UpdateUserRatings()
        {
            Dictionary<string, int> userRatings = CalculateUserRatings();

            // Очищаємо список користувачів
            listBoxUserRatings.Items.Clear();

            // Додаємо рейтинг кожного користувача до списку
            foreach (var userRating in userRatings.OrderByDescending(x => x.Value))
            {
                listBoxUserRatings.Items.Add($"{userRating.Key}: {userRating.Value} books");
            }
        }
    }
}