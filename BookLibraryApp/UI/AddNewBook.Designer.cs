namespace BookLibraryApp
{
    partial class AddNewBook
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
            label1 = new Label();
            textBox_author = new TextBox();
            textBox_title = new TextBox();
            textBox_age = new TextBox();
            textBox_ganre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_add = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "Автор";
            // 
            // textBox_author
            // 
            textBox_author.Location = new Point(121, 24);
            textBox_author.Name = "textBox_author";
            textBox_author.Size = new Size(212, 23);
            textBox_author.TabIndex = 1;
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(121, 53);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(212, 23);
            textBox_title.TabIndex = 2;
            // 
            // textBox_age
            // 
            textBox_age.Location = new Point(121, 82);
            textBox_age.Name = "textBox_age";
            textBox_age.Size = new Size(212, 23);
            textBox_age.TabIndex = 3;
            // 
            // textBox_ganre
            // 
            textBox_ganre.Location = new Point(121, 111);
            textBox_ganre.Name = "textBox_ganre";
            textBox_ganre.Size = new Size(212, 23);
            textBox_ganre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 55);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 5;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 84);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 6;
            label3.Text = "Год издания";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(62, 113);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 7;
            label4.Text = "Жанр";
            // 
            // button_add
            // 
            button_add.BackColor = Color.LightBlue;
            button_add.FlatAppearance.BorderColor = Color.MintCream;
            button_add.FlatAppearance.BorderSize = 0;
            button_add.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_add.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.Font = new Font("Segoe UI", 12F);
            button_add.Location = new Point(165, 150);
            button_add.Name = "button_add";
            button_add.Size = new Size(116, 32);
            button_add.TabIndex = 8;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // AddNewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(368, 209);
            Controls.Add(button_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_ganre);
            Controls.Add(textBox_age);
            Controls.Add(textBox_title);
            Controls.Add(textBox_author);
            Controls.Add(label1);
            MaximumSize = new Size(384, 248);
            MinimumSize = new Size(384, 248);
            Name = "AddNewBook";
            Text = "Добавление новой книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox_author;
        private TextBox textBox_title;
        private TextBox textBox_age;
        private TextBox textBox_ganre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_add;
    }
}