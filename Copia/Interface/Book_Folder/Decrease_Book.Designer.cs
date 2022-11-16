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
            this.Decrease_button1.Location = new System.Drawing.Point(98, 117);
            this.Decrease_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Decrease_button1.Name = "Decrease_button1";
            this.Decrease_button1.Size = new System.Drawing.Size(125, 30);
            this.Decrease_button1.TabIndex = 4;
            this.Decrease_button1.Text = "Restar";
            this.Decrease_button1.UseVisualStyleBackColor = true;
            this.Decrease_button1.Click += new System.EventHandler(this.Decrease_button1_Click);
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(7, 40);
            this.ToClose_button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(86, 28);
            this.ToClose_button3.TabIndex = 1;
            this.ToClose_button3.Text = "Volver";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // Amount_label1
            // 
            this.Amount_label1.AutoSize = true;
            this.Amount_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount_label1.Location = new System.Drawing.Point(4, 89);
            this.Amount_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Amount_label1.Name = "Amount_label1";
            this.Amount_label1.Size = new System.Drawing.Size(67, 18);
            this.Amount_label1.TabIndex = 42;
            this.Amount_label1.Text = "Cantidad";
            // 
            // Amount_textBox1
            // 
            this.Amount_textBox1.Location = new System.Drawing.Point(108, 94);
            this.Amount_textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Amount_textBox1.Name = "Amount_textBox1";
            this.Amount_textBox1.Size = new System.Drawing.Size(195, 20);
            this.Amount_textBox1.TabIndex = 3;
            // 
            // Code_label1
            // 
            this.Code_label1.AutoSize = true;
            this.Code_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_label1.Location = new System.Drawing.Point(7, 70);
            this.Code_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Code_label1.Name = "Code_label1";
            this.Code_label1.Size = new System.Drawing.Size(55, 18);
            this.Code_label1.TabIndex = 40;
            this.Code_label1.Text = "Código";
            // 
            // Code_textBox1
            // 
            this.Code_textBox1.Location = new System.Drawing.Point(108, 72);
            this.Code_textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Code_textBox1.Name = "Code_textBox1";
            this.Code_textBox1.Size = new System.Drawing.Size(195, 20);
            this.Code_textBox1.TabIndex = 2;
            // 
            // Decrease_label1
            // 
            this.Decrease_label1.AutoSize = true;
            this.Decrease_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrease_label1.Location = new System.Drawing.Point(82, 7);
            this.Decrease_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Decrease_label1.Name = "Decrease_label1";
            this.Decrease_label1.Size = new System.Drawing.Size(157, 30);
            this.Decrease_label1.TabIndex = 38;
            this.Decrease_label1.Text = "Restar libros";
            // 
            // Decrease_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.Decrease_button1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.Amount_label1);
            this.Controls.Add(this.Amount_textBox1);
            this.Controls.Add(this.Code_label1);
            this.Controls.Add(this.Code_textBox1);
            this.Controls.Add(this.Decrease_label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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