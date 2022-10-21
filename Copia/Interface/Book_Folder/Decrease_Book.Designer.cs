namespace Copia.Interface.Book_Folder
{
    partial class Decrease_Book
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
            this.Decrease_button1 = new System.Windows.Forms.Button();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.Amount_label1 = new System.Windows.Forms.Label();
            this.Amount_textBox1 = new System.Windows.Forms.TextBox();
            this.Code_label1 = new System.Windows.Forms.Label();
            this.Code_textBox1 = new System.Windows.Forms.TextBox();
            this.Decrease_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Decrease_button1
            // 
            this.Decrease_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrease_button1.Location = new System.Drawing.Point(130, 144);
            this.Decrease_button1.Name = "Decrease_button1";
            this.Decrease_button1.Size = new System.Drawing.Size(167, 37);
            this.Decrease_button1.TabIndex = 4;
            this.Decrease_button1.Text = "Decrease";
            this.Decrease_button1.UseVisualStyleBackColor = true;
            this.Decrease_button1.Click += new System.EventHandler(this.Decrease_button1_Click);
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(9, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(114, 34);
            this.ToClose_button3.TabIndex = 1;
            this.ToClose_button3.Text = "Go Back";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // Amount_label1
            // 
            this.Amount_label1.AutoSize = true;
            this.Amount_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_label1.Location = new System.Drawing.Point(5, 109);
            this.Amount_label1.Name = "Amount_label1";
            this.Amount_label1.Size = new System.Drawing.Size(78, 23);
            this.Amount_label1.TabIndex = 42;
            this.Amount_label1.Text = "Amount";
            // 
            // Amount_textBox1
            // 
            this.Amount_textBox1.Location = new System.Drawing.Point(144, 116);
            this.Amount_textBox1.Name = "Amount_textBox1";
            this.Amount_textBox1.Size = new System.Drawing.Size(259, 22);
            this.Amount_textBox1.TabIndex = 3;
            // 
            // Code_label1
            // 
            this.Code_label1.AutoSize = true;
            this.Code_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_label1.Location = new System.Drawing.Point(9, 86);
            this.Code_label1.Name = "Code_label1";
            this.Code_label1.Size = new System.Drawing.Size(52, 23);
            this.Code_label1.TabIndex = 40;
            this.Code_label1.Text = "Code";
            // 
            // Code_textBox1
            // 
            this.Code_textBox1.Location = new System.Drawing.Point(144, 88);
            this.Code_textBox1.Name = "Code_textBox1";
            this.Code_textBox1.Size = new System.Drawing.Size(259, 22);
            this.Code_textBox1.TabIndex = 2;
            // 
            // Decrease_label1
            // 
            this.Decrease_label1.AutoSize = true;
            this.Decrease_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrease_label1.Location = new System.Drawing.Point(109, 9);
            this.Decrease_label1.Name = "Decrease_label1";
            this.Decrease_label1.Size = new System.Drawing.Size(215, 37);
            this.Decrease_label1.TabIndex = 38;
            this.Decrease_label1.Text = "Decrease Book";
            // 
            // Decrease_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 198);
            this.Controls.Add(this.Decrease_button1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.Amount_label1);
            this.Controls.Add(this.Amount_textBox1);
            this.Controls.Add(this.Code_label1);
            this.Controls.Add(this.Code_textBox1);
            this.Controls.Add(this.Decrease_label1);
            this.Name = "Decrease_Book";
            this.Text = "Decrease_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Decrease_button1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label Amount_label1;
        private System.Windows.Forms.TextBox Amount_textBox1;
        private System.Windows.Forms.Label Code_label1;
        private System.Windows.Forms.TextBox Code_textBox1;
        private System.Windows.Forms.Label Decrease_label1;
    }
}