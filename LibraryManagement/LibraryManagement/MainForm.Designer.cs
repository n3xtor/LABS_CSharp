using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LibraryManagement
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.tabMylibrary = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelUserGenre = new System.Windows.Forms.Label();
            this.labelUserLanguage = new System.Windows.Forms.Label();
            this.labelUserAuthor = new System.Windows.Forms.Label();
            this.labelUserYear = new System.Windows.Forms.Label();
            this.buttonUserClear = new System.Windows.Forms.Button();
            this.textBoxUserLanguage = new System.Windows.Forms.TextBox();
            this.textBoxUserYear = new System.Windows.Forms.TextBox();
            this.textBoxUserGenre = new System.Windows.Forms.TextBox();
            this.textBoxUserAuthor = new System.Windows.Forms.TextBox();
            this.buttonUserSearch = new System.Windows.Forms.Button();
            this.dgvUserLibrary = new System.Windows.Forms.DataGridView();
            this.tabLibrary = new System.Windows.Forms.TabPage();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxLanguage = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.dgvLibrary = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.sidebarSwitcher = new System.Windows.Forms.TabControl();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.labelUserRating = new System.Windows.Forms.Label();
            this.listBoxUserRatings = new System.Windows.Forms.ListBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.PictureBox();
            this.buttonLibrary = new System.Windows.Forms.Button();
            this.buttoMylibrary = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.buttonAccleft = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.tabMylibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLibrary)).BeginInit();
            this.tabLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).BeginInit();
            this.sidebarSwitcher.SuspendLayout();
            this.tabAccount.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 10;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // tabMylibrary
            // 
            this.tabMylibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.tabMylibrary.Controls.Add(this.buttonDelete);
            this.tabMylibrary.Controls.Add(this.labelUserGenre);
            this.tabMylibrary.Controls.Add(this.labelUserLanguage);
            this.tabMylibrary.Controls.Add(this.labelUserAuthor);
            this.tabMylibrary.Controls.Add(this.labelUserYear);
            this.tabMylibrary.Controls.Add(this.buttonUserClear);
            this.tabMylibrary.Controls.Add(this.textBoxUserLanguage);
            this.tabMylibrary.Controls.Add(this.textBoxUserYear);
            this.tabMylibrary.Controls.Add(this.textBoxUserGenre);
            this.tabMylibrary.Controls.Add(this.textBoxUserAuthor);
            this.tabMylibrary.Controls.Add(this.buttonUserSearch);
            this.tabMylibrary.Controls.Add(this.dgvUserLibrary);
            this.tabMylibrary.Location = new System.Drawing.Point(4, 9);
            this.tabMylibrary.Name = "tabMylibrary";
            this.tabMylibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tabMylibrary.Size = new System.Drawing.Size(1315, 677);
            this.tabMylibrary.TabIndex = 2;
            this.tabMylibrary.Text = "tabPage3";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(776, 567);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(308, 55);
            this.buttonDelete.TabIndex = 83;
            this.buttonDelete.Text = "Delete selected";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelUserGenre
            // 
            this.labelUserGenre.AutoSize = true;
            this.labelUserGenre.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUserGenre.Location = new System.Drawing.Point(1109, 159);
            this.labelUserGenre.Name = "labelUserGenre";
            this.labelUserGenre.Size = new System.Drawing.Size(63, 25);
            this.labelUserGenre.TabIndex = 82;
            this.labelUserGenre.Text = "Genre";
            // 
            // labelUserLanguage
            // 
            this.labelUserLanguage.AutoSize = true;
            this.labelUserLanguage.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUserLanguage.Location = new System.Drawing.Point(1109, 370);
            this.labelUserLanguage.Name = "labelUserLanguage";
            this.labelUserLanguage.Size = new System.Drawing.Size(93, 25);
            this.labelUserLanguage.TabIndex = 81;
            this.labelUserLanguage.Text = "Language";
            // 
            // labelUserAuthor
            // 
            this.labelUserAuthor.AutoSize = true;
            this.labelUserAuthor.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUserAuthor.Location = new System.Drawing.Point(1109, 53);
            this.labelUserAuthor.Name = "labelUserAuthor";
            this.labelUserAuthor.Size = new System.Drawing.Size(70, 25);
            this.labelUserAuthor.TabIndex = 80;
            this.labelUserAuthor.Text = "Author";
            // 
            // labelUserYear
            // 
            this.labelUserYear.AutoSize = true;
            this.labelUserYear.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUserYear.Location = new System.Drawing.Point(1109, 264);
            this.labelUserYear.Name = "labelUserYear";
            this.labelUserYear.Size = new System.Drawing.Size(47, 25);
            this.labelUserYear.TabIndex = 79;
            this.labelUserYear.Text = "Year";
            // 
            // buttonUserClear
            // 
            this.buttonUserClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonUserClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserClear.FlatAppearance.BorderSize = 0;
            this.buttonUserClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserClear.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUserClear.ForeColor = System.Drawing.Color.White;
            this.buttonUserClear.Location = new System.Drawing.Point(1137, 569);
            this.buttonUserClear.Name = "buttonUserClear";
            this.buttonUserClear.Size = new System.Drawing.Size(130, 53);
            this.buttonUserClear.TabIndex = 78;
            this.buttonUserClear.Text = "Clear";
            this.buttonUserClear.UseVisualStyleBackColor = false;
            this.buttonUserClear.Click += new System.EventHandler(this.buttonUserClear_Click);
            // 
            // textBoxUserLanguage
            // 
            this.textBoxUserLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxUserLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserLanguage.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserLanguage.ForeColor = System.Drawing.Color.White;
            this.textBoxUserLanguage.Location = new System.Drawing.Point(1114, 403);
            this.textBoxUserLanguage.Name = "textBoxUserLanguage";
            this.textBoxUserLanguage.Size = new System.Drawing.Size(166, 38);
            this.textBoxUserLanguage.TabIndex = 77;
            // 
            // textBoxUserYear
            // 
            this.textBoxUserYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxUserYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserYear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserYear.ForeColor = System.Drawing.Color.White;
            this.textBoxUserYear.Location = new System.Drawing.Point(1114, 298);
            this.textBoxUserYear.Name = "textBoxUserYear";
            this.textBoxUserYear.Size = new System.Drawing.Size(166, 38);
            this.textBoxUserYear.TabIndex = 76;
            // 
            // textBoxUserGenre
            // 
            this.textBoxUserGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxUserGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserGenre.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserGenre.ForeColor = System.Drawing.Color.White;
            this.textBoxUserGenre.Location = new System.Drawing.Point(1114, 191);
            this.textBoxUserGenre.Name = "textBoxUserGenre";
            this.textBoxUserGenre.Size = new System.Drawing.Size(166, 38);
            this.textBoxUserGenre.TabIndex = 75;
            // 
            // textBoxUserAuthor
            // 
            this.textBoxUserAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxUserAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserAuthor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserAuthor.ForeColor = System.Drawing.Color.White;
            this.textBoxUserAuthor.Location = new System.Drawing.Point(1114, 86);
            this.textBoxUserAuthor.Name = "textBoxUserAuthor";
            this.textBoxUserAuthor.Size = new System.Drawing.Size(166, 38);
            this.textBoxUserAuthor.TabIndex = 74;
            // 
            // buttonUserSearch
            // 
            this.buttonUserSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonUserSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserSearch.FlatAppearance.BorderSize = 0;
            this.buttonUserSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserSearch.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUserSearch.ForeColor = System.Drawing.Color.White;
            this.buttonUserSearch.Location = new System.Drawing.Point(1137, 489);
            this.buttonUserSearch.Name = "buttonUserSearch";
            this.buttonUserSearch.Size = new System.Drawing.Size(130, 57);
            this.buttonUserSearch.TabIndex = 73;
            this.buttonUserSearch.Text = "Search";
            this.buttonUserSearch.UseVisualStyleBackColor = false;
            this.buttonUserSearch.Click += new System.EventHandler(this.buttonUserSearch_Click);
            // 
            // dgvUserLibrary
            // 
            this.dgvUserLibrary.AllowUserToAddRows = false;
            this.dgvUserLibrary.AllowUserToDeleteRows = false;
            this.dgvUserLibrary.AllowUserToResizeColumns = false;
            this.dgvUserLibrary.AllowUserToResizeRows = false;
            this.dgvUserLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.dgvUserLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserLibrary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserLibrary.ColumnHeadersHeight = 35;
            this.dgvUserLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserLibrary.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserLibrary.Location = new System.Drawing.Point(258, 82);
            this.dgvUserLibrary.MultiSelect = false;
            this.dgvUserLibrary.Name = "dgvUserLibrary";
            this.dgvUserLibrary.ReadOnly = true;
            this.dgvUserLibrary.RowHeadersVisible = false;
            this.dgvUserLibrary.RowHeadersWidth = 51;
            this.dgvUserLibrary.RowTemplate.Height = 40;
            this.dgvUserLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserLibrary.Size = new System.Drawing.Size(826, 439);
            this.dgvUserLibrary.TabIndex = 64;
            this.dgvUserLibrary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserLibrary_CellContentClick);
            // 
            // tabLibrary
            // 
            this.tabLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.tabLibrary.Controls.Add(this.labelGenre);
            this.tabLibrary.Controls.Add(this.labelLanguage);
            this.tabLibrary.Controls.Add(this.labelAuthor);
            this.tabLibrary.Controls.Add(this.labelYear);
            this.tabLibrary.Controls.Add(this.buttonClear);
            this.tabLibrary.Controls.Add(this.textBoxLanguage);
            this.tabLibrary.Controls.Add(this.textBoxYear);
            this.tabLibrary.Controls.Add(this.textBoxGenre);
            this.tabLibrary.Controls.Add(this.textBoxAuthor);
            this.tabLibrary.Controls.Add(this.dgvLibrary);
            this.tabLibrary.Controls.Add(this.buttonSearch);
            this.tabLibrary.Controls.Add(this.buttonAdd);
            this.tabLibrary.Location = new System.Drawing.Point(4, 9);
            this.tabLibrary.Name = "tabLibrary";
            this.tabLibrary.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibrary.Size = new System.Drawing.Size(1315, 677);
            this.tabLibrary.TabIndex = 1;
            this.tabLibrary.Text = "tabPage2";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelGenre.Location = new System.Drawing.Point(1109, 159);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(63, 25);
            this.labelGenre.TabIndex = 72;
            this.labelGenre.Text = "Genre";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelLanguage.Location = new System.Drawing.Point(1109, 370);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(93, 25);
            this.labelLanguage.TabIndex = 71;
            this.labelLanguage.Text = "Language";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelAuthor.Location = new System.Drawing.Point(1109, 53);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(70, 25);
            this.labelAuthor.TabIndex = 70;
            this.labelAuthor.Text = "Author";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelYear.Location = new System.Drawing.Point(1109, 264);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 25);
            this.labelYear.TabIndex = 69;
            this.labelYear.Text = "Year";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(1137, 569);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 53);
            this.buttonClear.TabIndex = 68;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxLanguage
            // 
            this.textBoxLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxLanguage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLanguage.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLanguage.ForeColor = System.Drawing.Color.White;
            this.textBoxLanguage.Location = new System.Drawing.Point(1114, 403);
            this.textBoxLanguage.Name = "textBoxLanguage";
            this.textBoxLanguage.Size = new System.Drawing.Size(166, 38);
            this.textBoxLanguage.TabIndex = 67;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.ForeColor = System.Drawing.Color.White;
            this.textBoxYear.Location = new System.Drawing.Point(1114, 298);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(166, 38);
            this.textBoxYear.TabIndex = 66;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGenre.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGenre.ForeColor = System.Drawing.Color.White;
            this.textBoxGenre.Location = new System.Drawing.Point(1114, 191);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(166, 38);
            this.textBoxGenre.TabIndex = 65;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(50)))));
            this.textBoxAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAuthor.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.ForeColor = System.Drawing.Color.White;
            this.textBoxAuthor.Location = new System.Drawing.Point(1114, 86);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(166, 38);
            this.textBoxAuthor.TabIndex = 64;
            // 
            // dgvLibrary
            // 
            this.dgvLibrary.AllowUserToAddRows = false;
            this.dgvLibrary.AllowUserToDeleteRows = false;
            this.dgvLibrary.AllowUserToResizeColumns = false;
            this.dgvLibrary.AllowUserToResizeRows = false;
            this.dgvLibrary.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.dgvLibrary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLibrary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibrary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLibrary.ColumnHeadersHeight = 35;
            this.dgvLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLibrary.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLibrary.Location = new System.Drawing.Point(258, 82);
            this.dgvLibrary.MultiSelect = false;
            this.dgvLibrary.Name = "dgvLibrary";
            this.dgvLibrary.ReadOnly = true;
            this.dgvLibrary.RowHeadersVisible = false;
            this.dgvLibrary.RowHeadersWidth = 51;
            this.dgvLibrary.RowTemplate.Height = 40;
            this.dgvLibrary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibrary.Size = new System.Drawing.Size(826, 439);
            this.dgvLibrary.TabIndex = 62;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(1137, 489);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(130, 57);
            this.buttonSearch.TabIndex = 63;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(776, 567);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(308, 55);
            this.buttonAdd.TabIndex = 61;
            this.buttonAdd.Text = "Add to own library";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // sidebarSwitcher
            // 
            this.sidebarSwitcher.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.sidebarSwitcher.Controls.Add(this.tabAccount);
            this.sidebarSwitcher.Controls.Add(this.tabLibrary);
            this.sidebarSwitcher.Controls.Add(this.tabMylibrary);
            this.sidebarSwitcher.ItemSize = new System.Drawing.Size(0, 5);
            this.sidebarSwitcher.Location = new System.Drawing.Point(61, 45);
            this.sidebarSwitcher.Multiline = true;
            this.sidebarSwitcher.Name = "sidebarSwitcher";
            this.sidebarSwitcher.SelectedIndex = 0;
            this.sidebarSwitcher.Size = new System.Drawing.Size(1323, 690);
            this.sidebarSwitcher.TabIndex = 24;
            // 
            // tabAccount
            // 
            this.tabAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.tabAccount.Controls.Add(this.labelUserRating);
            this.tabAccount.Controls.Add(this.listBoxUserRatings);
            this.tabAccount.Location = new System.Drawing.Point(4, 9);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccount.Size = new System.Drawing.Size(1315, 677);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.Text = "tabPage1";
            // 
            // labelUserRating
            // 
            this.labelUserRating.AutoSize = true;
            this.labelUserRating.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUserRating.Location = new System.Drawing.Point(605, 64);
            this.labelUserRating.Name = "labelUserRating";
            this.labelUserRating.Size = new System.Drawing.Size(268, 25);
            this.labelUserRating.TabIndex = 85;
            this.labelUserRating.Text = "Users rating by count of books";
            // 
            // listBoxUserRatings
            // 
            this.listBoxUserRatings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.listBoxUserRatings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUserRatings.Font = new System.Drawing.Font("Yu Gothic UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxUserRatings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.listBoxUserRatings.FormattingEnabled = true;
            this.listBoxUserRatings.ItemHeight = 25;
            this.listBoxUserRatings.Location = new System.Drawing.Point(659, 117);
            this.listBoxUserRatings.Name = "listBoxUserRatings";
            this.listBoxUserRatings.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxUserRatings.Size = new System.Drawing.Size(168, 550);
            this.listBoxUserRatings.TabIndex = 84;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.buttonLibrary);
            this.sidebar.Controls.Add(this.buttoMylibrary);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.buttonAccount);
            this.sidebar.Controls.Add(this.buttonAccleft);
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(275, 735);
            this.sidebar.MinimumSize = new System.Drawing.Size(93, 735);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(275, 735);
            this.sidebar.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 124);
            this.panel1.TabIndex = 0;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.Location = new System.Drawing.Point(11, 29);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(247, 50);
            this.buttonMenu.TabIndex = 24;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_click);
            // 
            // buttonLibrary
            // 
            this.buttonLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLibrary.FlatAppearance.BorderSize = 0;
            this.buttonLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibrary.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLibrary.ForeColor = System.Drawing.Color.White;
            this.buttonLibrary.Image = ((System.Drawing.Image)(resources.GetObject("buttonLibrary.Image")));
            this.buttonLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibrary.Location = new System.Drawing.Point(0, 133);
            this.buttonLibrary.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonLibrary.Name = "buttonLibrary";
            this.buttonLibrary.Padding = new System.Windows.Forms.Padding(7, 0, 10, 0);
            this.buttonLibrary.Size = new System.Drawing.Size(275, 70);
            this.buttonLibrary.TabIndex = 0;
            this.buttonLibrary.Text = "Library";
            this.buttonLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLibrary.UseVisualStyleBackColor = true;
            this.buttonLibrary.Click += new System.EventHandler(this.buttonLibrary_Click);
            // 
            // buttoMylibrary
            // 
            this.buttoMylibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttoMylibrary.FlatAppearance.BorderSize = 0;
            this.buttoMylibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoMylibrary.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttoMylibrary.ForeColor = System.Drawing.Color.White;
            this.buttoMylibrary.Image = ((System.Drawing.Image)(resources.GetObject("buttoMylibrary.Image")));
            this.buttoMylibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttoMylibrary.Location = new System.Drawing.Point(0, 209);
            this.buttoMylibrary.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttoMylibrary.Name = "buttoMylibrary";
            this.buttoMylibrary.Padding = new System.Windows.Forms.Padding(7, 0, 10, 0);
            this.buttoMylibrary.Size = new System.Drawing.Size(275, 70);
            this.buttoMylibrary.TabIndex = 1;
            this.buttoMylibrary.Text = "My library";
            this.buttoMylibrary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttoMylibrary.UseVisualStyleBackColor = true;
            this.buttoMylibrary.Click += new System.EventHandler(this.buttonMylibrary_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 281);
            this.panel2.TabIndex = 26;
            // 
            // buttonAccount
            // 
            this.buttonAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Image = global::LibraryManagement.Properties.Resources.User3;
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(0, 572);
            this.buttonAccount.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.buttonAccount.Size = new System.Drawing.Size(275, 96);
            this.buttonAccount.TabIndex = 27;
            this.buttonAccount.Text = "nextor";
            this.buttonAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // buttonAccleft
            // 
            this.buttonAccleft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccleft.FlatAppearance.BorderSize = 0;
            this.buttonAccleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccleft.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAccleft.ForeColor = System.Drawing.Color.White;
            this.buttonAccleft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccleft.Location = new System.Drawing.Point(0, 674);
            this.buttonAccleft.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.buttonAccleft.Name = "buttonAccleft";
            this.buttonAccleft.Size = new System.Drawing.Size(275, 47);
            this.buttonAccleft.TabIndex = 28;
            this.buttonAccleft.Text = "Logout";
            this.buttonAccleft.UseVisualStyleBackColor = true;
            this.buttonAccleft.Click += new System.EventHandler(this.buttonAccleft_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(1320, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(55, 60);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(261, 660);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.Image")));
            this.buttonMinimize.Location = new System.Drawing.Point(1265, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(55, 60);
            this.buttonMinimize.TabIndex = 6;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelMain.Font = new System.Drawing.Font("Yu Gothic UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(692, 1);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(227, 59);
            this.labelMain.TabIndex = 7;
            this.labelMain.Text = "ACCOUNT";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Header.Controls.Add(this.labelMain);
            this.Header.Controls.Add(this.buttonMinimize);
            this.Header.Controls.Add(this.flowLayoutPanel1);
            this.Header.Controls.Add(this.buttonExit);
            this.Header.Cursor = System.Windows.Forms.Cursors.Default;
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1375, 60);
            this.Header.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1375, 735);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.sidebarSwitcher);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMylibrary.ResumeLayout(false);
            this.tabMylibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLibrary)).EndInit();
            this.tabLibrary.ResumeLayout(false);
            this.tabLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrary)).EndInit();
            this.sidebarSwitcher.ResumeLayout(false);
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSidebar;
        private TabPage tabMylibrary;
        private TabPage tabLibrary;
        private Label labelGenre;
        private Label labelLanguage;
        private Label labelAuthor;
        private Label labelYear;
        private Button buttonClear;
        private TextBox textBoxLanguage;
        private TextBox textBoxYear;
        private TextBox textBoxGenre;
        private TextBox textBoxAuthor;
        private DataGridView dgvLibrary;
        private Button buttonSearch;
        private Button buttonAdd;
        private TabControl sidebarSwitcher;
        private TabPage tabAccount;
        private FlowLayoutPanel sidebar;
        private Button buttonLibrary;
        private Button buttoMylibrary;
        private Panel panel2;
        private Button buttonAccount;
        private Button buttonAccleft;
        private Panel panel1;
        private PictureBox buttonMenu;
        private Button buttonExit;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonMinimize;
        private Label labelMain;
        private Panel Header;
        private DataGridView dgvUserLibrary;
        private Label labelUserGenre;
        private Label labelUserLanguage;
        private Label labelUserAuthor;
        private Label labelUserYear;
        private Button buttonUserClear;
        private TextBox textBoxUserLanguage;
        private TextBox textBoxUserYear;
        private TextBox textBoxUserGenre;
        private TextBox textBoxUserAuthor;
        private Button buttonUserSearch;
        private Button buttonDelete;
        private ListBox listBoxUserRatings;
        private Label labelUserRating;
    }
}