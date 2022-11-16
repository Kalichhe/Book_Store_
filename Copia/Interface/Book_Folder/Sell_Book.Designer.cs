namespace Copia.Interface.Book_Folder
{
    partial class Sell_Book
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
            this.Sell_button1 = new System.Windows.Forms.Button();
            this.AddBook_label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Legit_button1 = new System.Windows.Forms.Button();
            this.CalculateTotal_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(9, 40);
            this.ToClose_button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(74, 28);
            this.ToClose_button3.TabIndex = 1;
            this.ToClose_button3.Text = "Volver";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // Sell_button1
            // 
            this.Sell_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell_button1.Location = new System.Drawing.Point(59, 247);
            this.Sell_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sell_button1.Name = "Sell_button1";
            this.Sell_button1.Size = new System.Drawing.Size(64, 30);
            this.Sell_button1.TabIndex = 3;
            this.Sell_button1.Text = "Vender";
            this.Sell_button1.UseVisualStyleBackColor = true;
            this.Sell_button1.Click += new System.EventHandler(this.Sell_button1_Click);
            // 
            // AddBook_label1
            // 
            this.AddBook_label1.AutoSize = true;
            this.AddBook_label1.BackColor = System.Drawing.SystemColors.Control;
            this.AddBook_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBook_label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddBook_label1.Location = new System.Drawing.Point(198, 9);
            this.AddBook_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddBook_label1.Name = "AddBook_label1";
            this.AddBook_label1.Size = new System.Drawing.Size(165, 30);
            this.AddBook_label1.TabIndex = 21;
            this.AddBook_label1.Text = "Vender libros";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bell MT", 100F);
            this.textBox1.Location = new System.Drawing.Point(9, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(583, 149);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Legit_button1
            // 
            this.Legit_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Legit_button1.Location = new System.Drawing.Point(470, 244);
            this.Legit_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Legit_button1.Name = "Legit_button1";
            this.Legit_button1.Size = new System.Drawing.Size(78, 36);
            this.Legit_button1.TabIndex = 4;
            this.Legit_button1.Text = "Fiar";
            this.Legit_button1.UseVisualStyleBackColor = true;
            this.Legit_button1.Click += new System.EventHandler(this.Legit_button1_Click);
            // 
            // CalculateTotal_button1
            // 
            this.CalculateTotal_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateTotal_button1.Location = new System.Drawing.Point(422, 40);
            this.CalculateTotal_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CalculateTotal_button1.Name = "CalculateTotal_button1";
            this.CalculateTotal_button1.Size = new System.Drawing.Size(170, 30);
            this.CalculateTotal_button1.TabIndex = 2;
            this.CalculateTotal_button1.Text = "Calcular Total";
            this.CalculateTotal_button1.UseVisualStyleBackColor = true;
            this.CalculateTotal_button1.Click += new System.EventHandler(this.CalculateTotal_button1_Click);
            // 
            // Sell_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 310);
            this.Controls.Add(this.CalculateTotal_button1);
            this.Controls.Add(this.Legit_button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.Sell_button1);
            this.Controls.Add(this.AddBook_label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sell_Book";
            this.Text = "Sell_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Button Sell_button1;
        private System.Windows.Forms.Label AddBook_label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Legit_button1;
        private System.Windows.Forms.Button CalculateTotal_button1;
    }
}