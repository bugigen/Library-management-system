namespace BookLibraryApp
{
    partial class NewReader
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
            button_add = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox_book = new TextBox();
            textBox_lastname = new TextBox();
            textBox_firstname = new TextBox();
            label1 = new Label();
            label4 = new Label();
            SuspendLayout();
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
            button_add.Location = new Point(175, 156);
            button_add.Name = "button_add";
            button_add.Size = new Size(116, 32);
            button_add.TabIndex = 26;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = false;
            button_add.Click += button_add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 89);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 24;
            label3.Text = "Взятые книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 46);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 23;
            label2.Text = "Фамилия";
            // 
            // textBox_book
            // 
            textBox_book.Location = new Point(131, 77);
            textBox_book.Multiline = true;
            textBox_book.Name = "textBox_book";
            textBox_book.Size = new Size(212, 44);
            textBox_book.TabIndex = 21;
            // 
            // textBox_lastname
            // 
            textBox_lastname.Location = new Point(131, 48);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.Size = new Size(212, 23);
            textBox_lastname.TabIndex = 20;
            // 
            // textBox_firstname
            // 
            textBox_firstname.Location = new Point(131, 19);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.Size = new Size(212, 23);
            textBox_firstname.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(81, 17);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 18;
            label1.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(131, 124);
            label4.Name = "label4";
            label4.Size = new Size(164, 15);
            label4.TabIndex = 27;
            label4.Text = "через запятую без пробелов";
            // 
            // NewReader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(368, 209);
            Controls.Add(label4);
            Controls.Add(button_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_book);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_firstname);
            Controls.Add(label1);
            Name = "NewReader";
            Text = "Новый читатель";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_add;
        private Label label3;
        private Label label2;
        private TextBox textBox_book;
        private TextBox textBox_lastname;
        private TextBox textBox_firstname;
        private Label label1;
        private Label label4;
    }
}