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
            textBox_age = new TextBox();
            textBox_title = new TextBox();
            textBox_author = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Font = new Font("Segoe UI", 12F);
            button_add.Location = new Point(175, 156);
            button_add.Name = "button_add";
            button_add.Size = new Size(116, 32);
            button_add.TabIndex = 26;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(17, 113);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 24;
            label3.Text = "Взятые книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 23;
            label2.Text = "Фамилия";
            // 
            // textBox_age
            // 
            textBox_age.Location = new Point(131, 101);
            textBox_age.Multiline = true;
            textBox_age.Name = "textBox_age";
            textBox_age.Size = new Size(212, 44);
            textBox_age.TabIndex = 21;
            // 
            // textBox_title
            // 
            textBox_title.Location = new Point(131, 72);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(212, 23);
            textBox_title.TabIndex = 20;
            // 
            // textBox_author
            // 
            textBox_author.Location = new Point(131, 43);
            textBox_author.Name = "textBox_author";
            textBox_author.Size = new Size(212, 23);
            textBox_author.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(81, 41);
            label1.Name = "label1";
            label1.Size = new Size(41, 21);
            label1.TabIndex = 18;
            label1.Text = "Имя";
            // 
            // NewReader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 209);
            Controls.Add(button_add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox_age);
            Controls.Add(textBox_title);
            Controls.Add(textBox_author);
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
        private TextBox textBox_age;
        private TextBox textBox_title;
        private TextBox textBox_author;
        private Label label1;
    }
}