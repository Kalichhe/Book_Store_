namespace Copia.Interface.Book_Folder
{
    partial class Delete_Book
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
            this.Send_button1 = new System.Windows.Forms.Button();
            this.BookCode_label1 = new System.Windows.Forms.Label();
            this.BookCode_textBox1 = new System.Windows.Forms.TextBox();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.Delete_Book_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_button1
            // 
            this.Send_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button1.Location = new System.Drawing.Point(124, 95);
            this.Send_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(119, 30);
            this.Send_button1.TabIndex = 38;
            this.Send_button1.Text = "Eliminar";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // BookCode_label1
            // 
            this.BookCode_label1.AutoSize = true;
            this.BookCode_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCode_label1.Location = new System.Drawing.Point(10, 70);
            this.BookCode_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookCode_label1.Name = "BookCode_label1";
            this.BookCode_label1.Size = new System.Drawing.Size(55, 18);
            this.BookCode_label1.TabIndex = 39;
            this.BookCode_label1.Text = "Código";
            // 
            // BookCode_textBox1
            // 
            this.BookCode_textBox1.Location = new System.Drawing.Point(112, 72);
            this.BookCode_textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookCode_textBox1.Name = "BookCode_textBox1";
            this.BookCode_textBox1.Size = new System.Drawing.Size(200, 20);
            this.BookCode_textBox1.TabIndex = 37;
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(8, 40);
            this.ToClose_button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(74, 28);
            this.ToClose_button3.TabIndex = 35;
            this.ToClose_button3.Text = "Volver";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // Delete_Book_label1
            // 
            this.Delete_Book_label1.AutoSize = true;
            this.Delete_Book_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Book_label1.Location = new System.Drawing.Point(93, 7);
            this.Delete_Book_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Delete_Book_label1.Name = "Delete_Book_label1";
            this.Delete_Book_label1.Size = new System.Drawing.Size(171, 30);
            this.Delete_Book_label1.TabIndex = 36;
            this.Delete_Book_label1.Text = "Eliminar libro";
            // 
            // Delete_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 134);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.BookCode_label1);
            this.Controls.Add(this.BookCode_textBox1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.Delete_Book_label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Delete_Book";
            this.Text = "Delete Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.Label BookCode_label1;
        private System.Windows.Forms.TextBox BookCode_textBox1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label Delete_Book_label1;
    }
}