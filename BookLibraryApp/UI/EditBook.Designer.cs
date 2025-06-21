namespace BookLibraryApp
{
    partial class EditBook
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
            button_edit = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox_ganre = new TextBox();
            textBox_age = new TextBox();
            textBox_title = new TextBox();
            textBox_author = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_edit
            // 
            button_edit.BackColor = Color.LightBlue;
            button_edit.FlatAppearance.BorderColor = Color.MintCream;
            button_edit.FlatAppearance.BorderSize = 0;
            button_edit.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            button_edit.FlatAppearance.MouseOverBackColor = Color.SkyBlue;
            button_edit.FlatStyle = FlatStyle.Flat;
            button_edit.Font = new Font("Segoe UI", 12F);
            button_edit.Location = new Point(165, 150);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(116, 32);
            button_edit.TabIndex = 17;
            button_edit.Text = "Изменить";
            button_edit.UseVisualStyleBackColor = false;
            button_edit.Click += button_edit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(62, 113);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 16;
            label4.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(16, 84);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 15;
            label3.Text = "Год издания";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(37, 55);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 14;
            label2.Text = "Название";
            // 
            // textBox_ganre
            // 
            textBox_ganre.Location = new Point(121, 111);
            textBox_ganre.Name = "textBox_ganre";
            textBox_ganre.Size = new Size(212, 23);
            textBox_ganre.TabIndex = 13;
            // 
            // textBox_age
            // 
            textBox_age.Location = new Point(121, 82);
            textBox_age.Name = "textBox_age";
            textBox_age.Size = new Size(212, 23);
            textBox_age.TabIndex = 12;
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(121, 53);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(212, 23);
            textBox_title.TabIndex = 11;
            // 
            // textBox_author
            // 
            textBox_author.Location = new Point(121, 24);
            textBox_author.Name = "textBox_author";
            textBox_author.Size = new Size(212, 23);
            textBox_author.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 9;
            label1.Text = "Автор";
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(368, 209);
            Controls.Add(button_edit);
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
            Name = "EditBook";
            Text = "Редактирование книги";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_edit;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox_ganre;
        private TextBox textBox_age;
        private TextBox textBox_title;
        private TextBox textBox_author;
        private Label label1;
    }
}