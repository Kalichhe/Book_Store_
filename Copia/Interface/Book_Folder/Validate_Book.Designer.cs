namespace Copia.Interface.Book_Folder
{
    partial class Validate_Book
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
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.ValidateBook_label1 = new System.Windows.Forms.Label();
            this.Send_button1 = new System.Windows.Forms.Button();
            this.BookCode_label1 = new System.Windows.Forms.Label();
            this.BookCode_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(8, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 28;
            this.ToClose_button3.Text = "Go Back";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // ValidateBook_label1
            // 
            this.ValidateBook_label1.AutoSize = true;
            this.ValidateBook_label1.BackColor = System.Drawing.SystemColors.Control;
            this.ValidateBook_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBook_label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValidateBook_label1.Location = new System.Drawing.Point(93, 9);
            this.ValidateBook_label1.Name = "ValidateBook_label1";
            this.ValidateBook_label1.Size = new System.Drawing.Size(204, 37);
            this.ValidateBook_label1.TabIndex = 32;
            this.ValidateBook_label1.Text = "Validate Book";
            // 
            // Send_button1
            // 
            this.Send_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button1.Location = new System.Drawing.Point(145, 126);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(86, 37);
            this.Send_button1.TabIndex = 30;
            this.Send_button1.Text = "Send";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // BookCode_label1
            // 
            this.BookCode_label1.AutoSize = true;
            this.BookCode_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCode_label1.Location = new System.Drawing.Point(11, 95);
            this.BookCode_label1.Name = "BookCode_label1";
            this.BookCode_label1.Size = new System.Drawing.Size(99, 23);
            this.BookCode_label1.TabIndex = 31;
            this.BookCode_label1.Text = "Book Code";
            // 
            // BookCode_textBox1
            // 
            this.BookCode_textBox1.Location = new System.Drawing.Point(116, 98);
            this.BookCode_textBox1.Name = "BookCode_textBox1";
            this.BookCode_textBox1.Size = new System.Drawing.Size(266, 22);
            this.BookCode_textBox1.TabIndex = 29;
            // 
            // Validate_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 181);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ValidateBook_label1);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.BookCode_label1);
            this.Controls.Add(this.BookCode_textBox1);
            this.Name = "Validate_Book";
            this.Text = "Validate_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label ValidateBook_label1;
        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.Label BookCode_label1;
        private System.Windows.Forms.TextBox BookCode_textBox1;
    }
}