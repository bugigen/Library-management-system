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

        private void InitializeComponent()
        {
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.buttonLoadBooks = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(12, 50);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(700, 300);
            this.listViewBooks.TabIndex = 0;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;

            this.buttonLoadBooks.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadBooks.Name = "buttonLoadBooks";
            this.buttonLoadBooks.Size = new System.Drawing.Size(100, 30);
            this.buttonLoadBooks.TabIndex = 1;
            this.buttonLoadBooks.Text = "Load Books";
            this.buttonLoadBooks.UseVisualStyleBackColor = true;
            this.buttonLoadBooks.Click += new System.EventHandler(this.ButtonLoadBooks);
       
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 362);
            this.Controls.Add(this.buttonLoadBooks);
            this.Controls.Add(this.listViewBooks);
            this.Name = "MainForm";
            this.Text = "SQLite Books Database";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.Button buttonLoadBooks;
    }
}
