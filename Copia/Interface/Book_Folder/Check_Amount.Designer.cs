namespace Copia.Interface.Book_Folder
{
    partial class Check_Amount
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
            this.CheckAmount_label1 = new System.Windows.Forms.Label();
            this.Send_button1 = new System.Windows.Forms.Button();
            this.BookCode_label1 = new System.Windows.Forms.Label();
            this.BookCode_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(8, 40);
            this.ToClose_button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(74, 28);
            this.ToClose_button3.TabIndex = 33;
            this.ToClose_button3.Text = "Volver";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // CheckAmount_label1
            // 
            this.CheckAmount_label1.AutoSize = true;
            this.CheckAmount_label1.BackColor = System.Drawing.SystemColors.Control;
            this.CheckAmount_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAmount_label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckAmount_label1.Location = new System.Drawing.Point(75, 7);
            this.CheckAmount_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckAmount_label1.Name = "CheckAmount_label1";
            this.CheckAmount_label1.Size = new System.Drawing.Size(210, 30);
            this.CheckAmount_label1.TabIndex = 37;
            this.CheckAmount_label1.Text = "Verificar cantidad";
            // 
            // Send_button1
            // 
            this.Send_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button1.Location = new System.Drawing.Point(112, 102);
            this.Send_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(109, 30);
            this.Send_button1.TabIndex = 35;
            this.Send_button1.Text = "Verificar";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // BookCode_label1
            // 
            this.BookCode_label1.AutoSize = true;
            this.BookCode_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCode_label1.Location = new System.Drawing.Point(8, 77);
            this.BookCode_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BookCode_label1.Name = "BookCode_label1";
            this.BookCode_label1.Size = new System.Drawing.Size(55, 18);
            this.BookCode_label1.TabIndex = 36;
            this.BookCode_label1.Text = "Código";
            // 
            // BookCode_textBox1
            // 
            this.BookCode_textBox1.Location = new System.Drawing.Point(92, 80);
            this.BookCode_textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookCode_textBox1.Name = "BookCode_textBox1";
            this.BookCode_textBox1.Size = new System.Drawing.Size(200, 20);
            this.BookCode_textBox1.TabIndex = 34;
            // 
            // Check_Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 139);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.CheckAmount_label1);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.BookCode_label1);
            this.Controls.Add(this.BookCode_textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Check_Amount";
            this.Text = "Check_Amount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label CheckAmount_label1;
        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.Label BookCode_label1;
        private System.Windows.Forms.TextBox BookCode_textBox1;
    }
}