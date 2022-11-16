namespace Copia.Interface.Book_Folder
{
    partial class Show_Book
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowBook_label1 = new System.Windows.Forms.Label();
            this.ToList_button1 = new System.Windows.Forms.Button();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(578, 282);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowBook_label1
            // 
            this.ShowBook_label1.AutoSize = true;
            this.ShowBook_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBook_label1.Location = new System.Drawing.Point(9, 7);
            this.ShowBook_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowBook_label1.Name = "ShowBook_label1";
            this.ShowBook_label1.Size = new System.Drawing.Size(176, 30);
            this.ShowBook_label1.TabIndex = 2;
            this.ShowBook_label1.Text = "Mostrar libros";
            // 
            // ToList_button1
            // 
            this.ToList_button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToList_button1.Location = new System.Drawing.Point(496, 38);
            this.ToList_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToList_button1.Name = "ToList_button1";
            this.ToList_button1.Size = new System.Drawing.Size(95, 32);
            this.ToList_button1.TabIndex = 30;
            this.ToList_button1.Text = "Listar";
            this.ToList_button1.UseVisualStyleBackColor = true;
            this.ToList_button1.Click += new System.EventHandler(this.Listar_button1_Click);
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(9, 42);
            this.ToClose_button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(74, 28);
            this.ToClose_button3.TabIndex = 31;
            this.ToClose_button3.Text = "Volver";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // Show_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ToList_button1);
            this.Controls.Add(this.ShowBook_label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Show_Book";
            this.Text = "Show_Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ShowBook_label1;
        private System.Windows.Forms.Button ToList_button1;
        private System.Windows.Forms.Button ToClose_button3;
    }
}