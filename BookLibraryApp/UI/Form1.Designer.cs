namespace BookLibraryApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button_show_book = new Button();
            tabPage2 = new TabPage();
            button7 = new Button();
            label2 = new Label();
            button_search_2 = new Button();
            button_back_menu = new Button();
            button_delet_book = new Button();
            button_edit_book = new Button();
            button_new_book = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            tabPage3 = new TabPage();
            label3 = new Label();
            button4 = new Button();
            button_new_reader = new Button();
            listView2 = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            tabPage4 = new TabPage();
            button_false = new Button();
            button_true = new Button();
            listView3 = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            label4 = new Label();
            button5 = new Button();
            button_search = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            tabPage5 = new TabPage();
            label7 = new Label();
            label5 = new Label();
            button6 = new Button();
            button_back = new Button();
            button_give_book = new Button();
            comboBox2 = new ComboBox();
            listView5 = new ListView();
            columnHeader18 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            columnHeader21 = new ColumnHeader();
            listView4 = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(-12, -29);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(547, 450);
            tabControl1.TabIndex = 0;
            tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button_show_book);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(539, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F);
            label6.Location = new Point(48, 35);
            label6.Name = "label6";
            label6.Size = new Size(445, 37);
            label6.TabIndex = 7;
            label6.Text = "Система управления библиотекой";
            // 
            // button3
            // 
            button3.BackColor = Color.LightBlue;
            button3.FlatAppearance.BorderColor = Color.MintCream;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button3.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button3.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(97, 194);
            button3.Name = "button3";
            button3.Size = new Size(156, 57);
            button3.TabIndex = 3;
            button3.TabStop = false;
            button3.Text = "ВЫДАЧА И ВОЗВРАТ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.FlatAppearance.BorderColor = Color.MintCream;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button2.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(281, 194);
            button2.Name = "button2";
            button2.Size = new Size(156, 57);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.Text = "ПОИСК КНИГ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.FlatAppearance.BorderColor = Color.MintCream;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(281, 118);
            button1.Name = "button1";
            button1.Size = new Size(156, 57);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "СПИСОК ЧИТАТЕЛЕЙ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button_show_book
            // 
            button_show_book.BackColor = Color.LightBlue;
            button_show_book.FlatAppearance.BorderColor = Color.MintCream;
            button_show_book.FlatAppearance.BorderSize = 0;
            button_show_book.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button_show_book.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_show_book.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_show_book.FlatStyle = FlatStyle.Flat;
            button_show_book.Location = new Point(97, 118);
            button_show_book.Name = "button_show_book";
            button_show_book.Size = new Size(156, 57);
            button_show_book.TabIndex = 0;
            button_show_book.TabStop = false;
            button_show_book.Text = "СПИСОК КНИГ";
            button_show_book.UseVisualStyleBackColor = false;
            button_show_book.Click += button_show_book_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(button_search_2);
            tabPage2.Controls.Add(button_back_menu);
            tabPage2.Controls.Add(button_delet_book);
            tabPage2.Controls.Add(button_edit_book);
            tabPage2.Controls.Add(button_new_book);
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(539, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.LightBlue;
            button7.FlatAppearance.BorderColor = Color.MintCream;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button7.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(352, 365);
            button7.Name = "button7";
            button7.Size = new Size(149, 27);
            button7.TabIndex = 7;
            button7.TabStop = false;
            button7.Text = "Выдача/возврат";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(165, 14);
            label2.Name = "label2";
            label2.Size = new Size(228, 37);
            label2.TabIndex = 6;
            label2.Text = "Список всех книг";
            // 
            // button_search_2
            // 
            button_search_2.BackColor = Color.LightBlue;
            button_search_2.FlatAppearance.BorderColor = Color.MintCream;
            button_search_2.FlatAppearance.BorderSize = 0;
            button_search_2.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_search_2.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_search_2.FlatStyle = FlatStyle.Flat;
            button_search_2.Location = new Point(42, 365);
            button_search_2.Name = "button_search_2";
            button_search_2.Size = new Size(149, 27);
            button_search_2.TabIndex = 5;
            button_search_2.TabStop = false;
            button_search_2.Text = "Поиск";
            button_search_2.UseVisualStyleBackColor = false;
            button_search_2.Click += button_search_2_Click;
            // 
            // button_back_menu
            // 
            button_back_menu.BackColor = Color.LightBlue;
            button_back_menu.FlatAppearance.BorderColor = Color.MintCream;
            button_back_menu.FlatAppearance.BorderSize = 0;
            button_back_menu.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_back_menu.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_back_menu.FlatStyle = FlatStyle.Flat;
            button_back_menu.Location = new Point(197, 365);
            button_back_menu.Name = "button_back_menu";
            button_back_menu.Size = new Size(149, 27);
            button_back_menu.TabIndex = 4;
            button_back_menu.TabStop = false;
            button_back_menu.Text = "Назад в меню";
            button_back_menu.UseVisualStyleBackColor = false;
            button_back_menu.Click += button_back_menu_Click;
            // 
            // button_delet_book
            // 
            button_delet_book.BackColor = Color.LightBlue;
            button_delet_book.FlatAppearance.BorderColor = Color.MintCream;
            button_delet_book.FlatAppearance.BorderSize = 0;
            button_delet_book.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_delet_book.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_delet_book.FlatStyle = FlatStyle.Flat;
            button_delet_book.Location = new Point(352, 316);
            button_delet_book.Name = "button_delet_book";
            button_delet_book.Size = new Size(149, 29);
            button_delet_book.TabIndex = 3;
            button_delet_book.TabStop = false;
            button_delet_book.Text = "Удаление книги";
            button_delet_book.UseVisualStyleBackColor = false;
            button_delet_book.Click += button_delet_book_Click;
            // 
            // button_edit_book
            // 
            button_edit_book.BackColor = Color.LightBlue;
            button_edit_book.FlatAppearance.BorderColor = Color.MintCream;
            button_edit_book.FlatAppearance.BorderSize = 0;
            button_edit_book.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_edit_book.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_edit_book.FlatStyle = FlatStyle.Flat;
            button_edit_book.Location = new Point(197, 316);
            button_edit_book.Name = "button_edit_book";
            button_edit_book.Size = new Size(149, 29);
            button_edit_book.TabIndex = 2;
            button_edit_book.TabStop = false;
            button_edit_book.Text = "Редактирование книги";
            button_edit_book.UseVisualStyleBackColor = false;
            button_edit_book.Click += button_edit_book_Click;
            // 
            // button_new_book
            // 
            button_new_book.BackColor = Color.LightBlue;
            button_new_book.FlatAppearance.BorderColor = Color.MintCream;
            button_new_book.FlatAppearance.BorderSize = 0;
            button_new_book.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_new_book.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_new_book.FlatStyle = FlatStyle.Flat;
            button_new_book.Location = new Point(42, 316);
            button_new_book.Name = "button_new_book";
            button_new_book.Size = new Size(149, 29);
            button_new_book.TabIndex = 1;
            button_new_book.TabStop = false;
            button_new_book.Text = "Добавить новую книгу";
            button_new_book.UseVisualStyleBackColor = false;
            button_new_book.Click += button_new_book_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listView1.Location = new Point(17, 69);
            listView1.Name = "listView1";
            listView1.Size = new Size(507, 233);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Автор";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Название";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Год";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Жанр";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Статус";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 70;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button_new_reader);
            tabPage3.Controls.Add(listView2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(539, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(105, 12);
            label3.Name = "label3";
            label3.Size = new Size(298, 37);
            label3.TabIndex = 7;
            label3.Text = "Список всех читателей";
            // 
            // button4
            // 
            button4.BackColor = Color.LightBlue;
            button4.FlatAppearance.BorderColor = Color.MintCream;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(180, 367);
            button4.Name = "button4";
            button4.Size = new Size(186, 27);
            button4.TabIndex = 5;
            button4.TabStop = false;
            button4.Text = "Назад в меню";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button_back_menu_Click;
            // 
            // button_new_reader
            // 
            button_new_reader.BackColor = Color.LightBlue;
            button_new_reader.FlatAppearance.BorderColor = Color.MintCream;
            button_new_reader.FlatAppearance.BorderSize = 0;
            button_new_reader.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_new_reader.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_new_reader.FlatStyle = FlatStyle.Flat;
            button_new_reader.Location = new Point(180, 314);
            button_new_reader.Name = "button_new_reader";
            button_new_reader.Size = new Size(186, 38);
            button_new_reader.TabIndex = 2;
            button_new_reader.TabStop = false;
            button_new_reader.Text = "Регистрация нового читателя";
            button_new_reader.UseVisualStyleBackColor = false;
            button_new_reader.Click += button_new_reader_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listView2.Location = new Point(19, 62);
            listView2.Name = "listView2";
            listView2.Size = new Size(505, 233);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Имя";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Фамилия";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Список взятых книг";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 250;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button_false);
            tabPage4.Controls.Add(button_true);
            tabPage4.Controls.Add(listView3);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button_search);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(539, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_false
            // 
            button_false.BackColor = Color.LightBlue;
            button_false.FlatAppearance.BorderColor = Color.MintCream;
            button_false.FlatAppearance.BorderSize = 0;
            button_false.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button_false.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_false.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_false.FlatStyle = FlatStyle.Flat;
            button_false.Location = new Point(360, 136);
            button_false.Name = "button_false";
            button_false.Size = new Size(140, 23);
            button_false.TabIndex = 10;
            button_false.TabStop = false;
            button_false.Text = "Выдать занятые";
            button_false.UseVisualStyleBackColor = false;
            button_false.Click += button_false_Click;
            // 
            // button_true
            // 
            button_true.BackColor = Color.LightBlue;
            button_true.FlatAppearance.BorderColor = Color.MintCream;
            button_true.FlatAppearance.BorderSize = 0;
            button_true.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button_true.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_true.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_true.FlatStyle = FlatStyle.Flat;
            button_true.Location = new Point(360, 107);
            button_true.Name = "button_true";
            button_true.Size = new Size(140, 23);
            button_true.TabIndex = 9;
            button_true.TabStop = false;
            button_true.Text = "Выдать свободные";
            button_true.UseVisualStyleBackColor = false;
            button_true.Click += button_true_Click;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listView3.Location = new Point(15, 180);
            listView3.Name = "listView3";
            listView3.Size = new Size(509, 163);
            listView3.TabIndex = 8;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "ID";
            columnHeader11.Width = 30;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Автор";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Название";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 170;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Год";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Жанр";
            columnHeader15.TextAlign = HorizontalAlignment.Center;
            columnHeader15.Width = 70;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Статус";
            columnHeader16.TextAlign = HorizontalAlignment.Center;
            columnHeader16.Width = 70;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(185, 17);
            label4.Name = "label4";
            label4.Size = new Size(171, 37);
            label4.TabIndex = 7;
            label4.Text = "Поиск книги";
            // 
            // button5
            // 
            button5.BackColor = Color.LightBlue;
            button5.FlatAppearance.BorderColor = Color.MintCream;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button5.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button5.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(197, 365);
            button5.Name = "button5";
            button5.Size = new Size(149, 27);
            button5.TabIndex = 6;
            button5.TabStop = false;
            button5.Text = "Назад в меню";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button_back_menu_Click;
            // 
            // button_search
            // 
            button_search.BackColor = Color.LightBlue;
            button_search.FlatAppearance.BorderColor = Color.MintCream;
            button_search.FlatAppearance.BorderSize = 0;
            button_search.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            button_search.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_search.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Location = new Point(360, 78);
            button_search.Name = "button_search";
            button_search.Size = new Size(140, 23);
            button_search.TabIndex = 5;
            button_search.TabStop = false;
            button_search.Text = "Искать";
            button_search.UseVisualStyleBackColor = false;
            button_search.Click += button_search_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 60);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Поиск по:";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Название", "Автор", "Жанр" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Название", "Автор", "Жанр" });
            comboBox1.Location = new Point(42, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(button6);
            tabPage5.Controls.Add(button_back);
            tabPage5.Controls.Add(button_give_book);
            tabPage5.Controls.Add(comboBox2);
            tabPage5.Controls.Add(listView5);
            tabPage5.Controls.Add(listView4);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(539, 422);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(62, 323);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 9;
            label7.Text = "ID читателя:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(144, 17);
            label5.Name = "label5";
            label5.Size = new Size(236, 37);
            label5.TabIndex = 8;
            label5.Text = "Выдача и возврат";
            // 
            // button6
            // 
            button6.BackColor = Color.LightBlue;
            button6.FlatAppearance.BorderColor = Color.MintCream;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button6.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(218, 364);
            button6.Name = "button6";
            button6.Size = new Size(149, 27);
            button6.TabIndex = 7;
            button6.TabStop = false;
            button6.Text = "Назад в меню";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button_back_menu_Click;
            // 
            // button_back
            // 
            button_back.BackColor = Color.LightBlue;
            button_back.FlatAppearance.BorderColor = Color.MintCream;
            button_back.FlatAppearance.BorderSize = 0;
            button_back.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_back.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_back.FlatStyle = FlatStyle.Flat;
            button_back.Location = new Point(380, 319);
            button_back.Name = "button_back";
            button_back.Size = new Size(95, 23);
            button_back.TabIndex = 6;
            button_back.TabStop = false;
            button_back.Text = "Возвратить";
            button_back.UseVisualStyleBackColor = false;
            button_back.Click += button_back_Click;
            // 
            // button_give_book
            // 
            button_give_book.BackColor = Color.LightBlue;
            button_give_book.FlatAppearance.BorderColor = Color.MintCream;
            button_give_book.FlatAppearance.BorderSize = 0;
            button_give_book.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_give_book.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_give_book.FlatStyle = FlatStyle.Flat;
            button_give_book.Location = new Point(279, 319);
            button_give_book.Name = "button_give_book";
            button_give_book.Size = new Size(95, 23);
            button_give_book.TabIndex = 5;
            button_give_book.TabStop = false;
            button_give_book.Text = "Выдать";
            button_give_book.UseVisualStyleBackColor = false;
            button_give_book.Click += button_give_book_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(141, 319);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // listView5
            // 
            listView5.Columns.AddRange(new ColumnHeader[] { columnHeader18, columnHeader20, columnHeader21 });
            listView5.Location = new Point(313, 71);
            listView5.Name = "listView5";
            listView5.Size = new Size(220, 225);
            listView5.TabIndex = 3;
            listView5.UseCompatibleStateImageBehavior = false;
            listView5.View = View.Details;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "ID";
            columnHeader18.Width = 40;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Имя";
            columnHeader20.Width = 80;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Фамилия";
            columnHeader21.Width = 80;
            // 
            // listView4
            // 
            listView4.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader19, columnHeader22 });
            listView4.Location = new Point(13, 71);
            listView4.Name = "listView4";
            listView4.Size = new Size(294, 225);
            listView4.TabIndex = 2;
            listView4.UseCompatibleStateImageBehavior = false;
            listView4.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "ID";
            columnHeader17.Width = 40;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Название";
            columnHeader19.TextAlign = HorizontalAlignment.Center;
            columnHeader19.Width = 150;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Кто взял";
            columnHeader22.TextAlign = HorizontalAlignment.Center;
            columnHeader22.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 410);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(544, 449);
            MinimizeBox = false;
            MinimumSize = new Size(544, 449);
            Name = "Form1";
            Text = "Библиотека";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button_show_book;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button button_new_book;
        private Button button_edit_book;
        private Button button_delet_book;
        private TabPage tabPage3;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Button button_new_reader;
        private Button button1;
        private Button button2;
        private Button button3;
        private TabPage tabPage4;
        private Button button_search;
        private Label label1;
        private TextBox textBox1;
        public ComboBox comboBox1;
        private TabPage tabPage5;
        private ListView listView4;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader22;
        private ListView listView5;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private Button button_back;
        private Button button_give_book;
        private ComboBox comboBox2;
        private Button button_back_menu;
        private Button button_search_2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button7;
        private Label label6;
        private ListView listView3;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Button button_true;
        private Button button_false;
        private Label label7;
    }
}
