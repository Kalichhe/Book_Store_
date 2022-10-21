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
            this.textBox1.Location = new System.Drawing.Point(19, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(769, 346);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowBook_label1
            // 
            this.ShowBook_label1.AutoSize = true;
            this.ShowBook_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBook_label1.Location = new System.Drawing.Point(12, 9);
            this.ShowBook_label1.Name = "ShowBook_label1";
            this.ShowBook_label1.Size = new System.Drawing.Size(168, 37);
            this.ShowBook_label1.TabIndex = 2;
            this.ShowBook_label1.Text = "Show Book";
            // 
            // ToList_button1
            // 
            this.ToList_button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToList_button1.Location = new System.Drawing.Point(661, 47);
            this.ToList_button1.Name = "ToList_button1";
            this.ToList_button1.Size = new System.Drawing.Size(127, 39);
            this.ToList_button1.TabIndex = 30;
            this.ToList_button1.Text = "To List";
            this.ToList_button1.UseVisualStyleBackColor = true;
            this.ToList_button1.Click += new System.EventHandler(this.Listar_button1_Click);
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 52);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 31;
            this.ToClose_button3.Text = "Go Back";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // Show_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ToList_button1);
            this.Controls.Add(this.ShowBook_label1);
            this.Controls.Add(this.textBox1);
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