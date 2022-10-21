namespace Copia.Interface.Book_Folder
{
    partial class Increase_Book
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
            this.Increase_label1 = new System.Windows.Forms.Label();
            this.Code_label1 = new System.Windows.Forms.Label();
            this.BookCode_textBox1 = new System.Windows.Forms.TextBox();
            this.Amount_label1 = new System.Windows.Forms.Label();
            this.Amount_textBox1 = new System.Windows.Forms.TextBox();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.Increase_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Increase_label1
            // 
            this.Increase_label1.AutoSize = true;
            this.Increase_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increase_label1.Location = new System.Drawing.Point(112, 9);
            this.Increase_label1.Name = "Increase_label1";
            this.Increase_label1.Size = new System.Drawing.Size(206, 37);
            this.Increase_label1.TabIndex = 14;
            this.Increase_label1.Text = "Increase Book";
            // 
            // Code_label1
            // 
            this.Code_label1.AutoSize = true;
            this.Code_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_label1.Location = new System.Drawing.Point(12, 86);
            this.Code_label1.Name = "Code_label1";
            this.Code_label1.Size = new System.Drawing.Size(52, 23);
            this.Code_label1.TabIndex = 33;
            this.Code_label1.Text = "Code";
            // 
            // BookCode_textBox1
            // 
            this.BookCode_textBox1.Location = new System.Drawing.Point(147, 88);
            this.BookCode_textBox1.Name = "BookCode_textBox1";
            this.BookCode_textBox1.Size = new System.Drawing.Size(259, 22);
            this.BookCode_textBox1.TabIndex = 32;
            // 
            // Amount_label1
            // 
            this.Amount_label1.AutoSize = true;
            this.Amount_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_label1.Location = new System.Drawing.Point(8, 109);
            this.Amount_label1.Name = "Amount_label1";
            this.Amount_label1.Size = new System.Drawing.Size(78, 23);
            this.Amount_label1.TabIndex = 35;
            this.Amount_label1.Text = "Amount";
            // 
            // Amount_textBox1
            // 
            this.Amount_textBox1.Location = new System.Drawing.Point(147, 116);
            this.Amount_textBox1.Name = "Amount_textBox1";
            this.Amount_textBox1.Size = new System.Drawing.Size(259, 22);
            this.Amount_textBox1.TabIndex = 34;
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(114, 34);
            this.ToClose_button3.TabIndex = 36;
            this.ToClose_button3.Text = "Go Back";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // Increase_button1
            // 
            this.Increase_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increase_button1.Location = new System.Drawing.Point(133, 144);
            this.Increase_button1.Name = "Increase_button1";
            this.Increase_button1.Size = new System.Drawing.Size(167, 37);
            this.Increase_button1.TabIndex = 37;
            this.Increase_button1.Text = "Increase";
            this.Increase_button1.UseVisualStyleBackColor = true;
            this.Increase_button1.Click += new System.EventHandler(this.Increase_button1_Click);
            // 
            // Increase_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 193);
            this.Controls.Add(this.Increase_button1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.Amount_label1);
            this.Controls.Add(this.Amount_textBox1);
            this.Controls.Add(this.Code_label1);
            this.Controls.Add(this.BookCode_textBox1);
            this.Controls.Add(this.Increase_label1);
            this.Name = "Increase_Book";
            this.Text = "Increase_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Increase_label1;
        private System.Windows.Forms.Label Code_label1;
        private System.Windows.Forms.TextBox BookCode_textBox1;
        private System.Windows.Forms.Label Amount_label1;
        private System.Windows.Forms.TextBox Amount_textBox1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Button Increase_button1;
    }
}