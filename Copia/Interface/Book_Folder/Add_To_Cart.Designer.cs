namespace Copia.Interface.Book_Folder
{
    partial class Add_To_Cart
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
            this.Units_textBox1 = new System.Windows.Forms.TextBox();
            this.NumberUnits_label1 = new System.Windows.Forms.Label();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.BookCode_label1 = new System.Windows.Forms.Label();
            this.BookCode_textBox1 = new System.Windows.Forms.TextBox();
            this.AddBookToCart_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Send_button1
            // 
            this.Send_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button1.Location = new System.Drawing.Point(167, 144);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(86, 37);
            this.Send_button1.TabIndex = 4;
            this.Send_button1.Text = "Send";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // Units_textBox1
            // 
            this.Units_textBox1.Location = new System.Drawing.Point(155, 116);
            this.Units_textBox1.Name = "Units_textBox1";
            this.Units_textBox1.Size = new System.Drawing.Size(259, 22);
            this.Units_textBox1.TabIndex = 3;
            // 
            // NumberUnits_label1
            // 
            this.NumberUnits_label1.AutoSize = true;
            this.NumberUnits_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberUnits_label1.Location = new System.Drawing.Point(14, 114);
            this.NumberUnits_label1.Name = "NumberUnits_label1";
            this.NumberUnits_label1.Size = new System.Drawing.Size(135, 23);
            this.NumberUnits_label1.TabIndex = 25;
            this.NumberUnits_label1.Text = "Number_Units";
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(14, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 1;
            this.ToClose_button3.Text = "To Close";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // BookCode_label1
            // 
            this.BookCode_label1.AutoSize = true;
            this.BookCode_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCode_label1.Location = new System.Drawing.Point(14, 86);
            this.BookCode_label1.Name = "BookCode_label1";
            this.BookCode_label1.Size = new System.Drawing.Size(99, 23);
            this.BookCode_label1.TabIndex = 24;
            this.BookCode_label1.Text = "Book Code";
            // 
            // BookCode_textBox1
            // 
            this.BookCode_textBox1.Location = new System.Drawing.Point(155, 88);
            this.BookCode_textBox1.Name = "BookCode_textBox1";
            this.BookCode_textBox1.Size = new System.Drawing.Size(259, 22);
            this.BookCode_textBox1.TabIndex = 2;
            // 
            // AddBookToCart_label1
            // 
            this.AddBookToCart_label1.AutoSize = true;
            this.AddBookToCart_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBookToCart_label1.Location = new System.Drawing.Point(87, 9);
            this.AddBookToCart_label1.Name = "AddBookToCart_label1";
            this.AddBookToCart_label1.Size = new System.Drawing.Size(266, 37);
            this.AddBookToCart_label1.TabIndex = 20;
            this.AddBookToCart_label1.Text = "Add Book To Cart";
            // 
            // Add_To_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 192);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.Units_textBox1);
            this.Controls.Add(this.NumberUnits_label1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.BookCode_label1);
            this.Controls.Add(this.BookCode_textBox1);
            this.Controls.Add(this.AddBookToCart_label1);
            this.Name = "Add_To_Cart";
            this.Text = "Add_To_Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.TextBox Units_textBox1;
        private System.Windows.Forms.Label NumberUnits_label1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label BookCode_label1;
        private System.Windows.Forms.TextBox BookCode_textBox1;
        private System.Windows.Forms.Label AddBookToCart_label1;
    }
}