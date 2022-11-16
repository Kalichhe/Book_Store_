namespace Copia.Interface
{
    partial class Main
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
            this.Exit_button3 = new System.Windows.Forms.Button();
            this.ShowBook_button2 = new System.Windows.Forms.Button();
            this.Book_button1 = new System.Windows.Forms.Button();
            this.BookStore_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_button3
            // 
            this.Exit_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button3.Location = new System.Drawing.Point(388, 42);
            this.Exit_button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Exit_button3.Name = "Exit_button3";
            this.Exit_button3.Size = new System.Drawing.Size(74, 28);
            this.Exit_button3.TabIndex = 3;
            this.Exit_button3.Text = "Salir";
            this.Exit_button3.UseVisualStyleBackColor = true;
            this.Exit_button3.Click += new System.EventHandler(this.ToClose_button3_Click_1);
            // 
            // ShowBook_button2
            // 
            this.ShowBook_button2.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBook_button2.Location = new System.Drawing.Point(106, 40);
            this.ShowBook_button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowBook_button2.Name = "ShowBook_button2";
            this.ShowBook_button2.Size = new System.Drawing.Size(103, 29);
            this.ShowBook_button2.TabIndex = 2;
            this.ShowBook_button2.Text = "Ver libros";
            this.ShowBook_button2.UseVisualStyleBackColor = true;
            this.ShowBook_button2.Click += new System.EventHandler(this.ShowBook_button2_Click_1);
            // 
            // Book_button1
            // 
            this.Book_button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_button1.Location = new System.Drawing.Point(9, 41);
            this.Book_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Book_button1.Name = "Book_button1";
            this.Book_button1.Size = new System.Drawing.Size(93, 28);
            this.Book_button1.TabIndex = 1;
            this.Book_button1.Text = "Libreria";
            this.Book_button1.UseVisualStyleBackColor = true;
            this.Book_button1.Click += new System.EventHandler(this.Book_button1_Click_1);
            // 
            // BookStore_label1
            // 
            this.BookStore_label1.AutoSize = true;
            this.BookStore_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookStore_label1.Location = new System.Drawing.Point(9, 7);
            this.BookStore_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookStore_label1.Name = "BookStore_label1";
            this.BookStore_label1.Size = new System.Drawing.Size(104, 30);
            this.BookStore_label1.TabIndex = 7;
            this.BookStore_label1.Text = "Libreria";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 84);
            this.Controls.Add(this.Exit_button3);
            this.Controls.Add(this.ShowBook_button2);
            this.Controls.Add(this.Book_button1);
            this.Controls.Add(this.BookStore_label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.Text = "Booker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_button3;
        private System.Windows.Forms.Button ShowBook_button2;
        private System.Windows.Forms.Button Book_button1;
        private System.Windows.Forms.Label BookStore_label1;
    }
}