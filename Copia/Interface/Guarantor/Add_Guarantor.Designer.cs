namespace Copia.Interface.Guarantor
{
    partial class Add_Guarantor
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
            this.Name_label1 = new System.Windows.Forms.Label();
            this.Name_textBox1 = new System.Windows.Forms.TextBox();
            this.ToClose_button3 = new System.Windows.Forms.Button();
            this.IdentificationCard_label1 = new System.Windows.Forms.Label();
            this.IdentificationCard_textBox1 = new System.Windows.Forms.TextBox();
            this.AddGuarantor_label1 = new System.Windows.Forms.Label();
            this.Payment_label1 = new System.Windows.Forms.Label();
            this.Payment_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Send_button1
            // 
            this.Send_button1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_button1.Location = new System.Drawing.Point(187, 172);
            this.Send_button1.Name = "Send_button1";
            this.Send_button1.Size = new System.Drawing.Size(86, 37);
            this.Send_button1.TabIndex = 24;
            this.Send_button1.Text = "Send";
            this.Send_button1.UseVisualStyleBackColor = true;
            this.Send_button1.Click += new System.EventHandler(this.Send_button1_Click);
            // 
            // Name_label1
            // 
            this.Name_label1.AutoSize = true;
            this.Name_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label1.Location = new System.Drawing.Point(12, 109);
            this.Name_label1.Name = "Name_label1";
            this.Name_label1.Size = new System.Drawing.Size(59, 23);
            this.Name_label1.TabIndex = 26;
            this.Name_label1.Text = "Name";
            // 
            // Name_textBox1
            // 
            this.Name_textBox1.Location = new System.Drawing.Point(187, 116);
            this.Name_textBox1.Name = "Name_textBox1";
            this.Name_textBox1.Size = new System.Drawing.Size(259, 22);
            this.Name_textBox1.TabIndex = 23;
            // 
            // ToClose_button3
            // 
            this.ToClose_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToClose_button3.Location = new System.Drawing.Point(12, 49);
            this.ToClose_button3.Name = "ToClose_button3";
            this.ToClose_button3.Size = new System.Drawing.Size(98, 34);
            this.ToClose_button3.TabIndex = 20;
            this.ToClose_button3.Text = "Go Back";
            this.ToClose_button3.UseVisualStyleBackColor = true;
            this.ToClose_button3.Click += new System.EventHandler(this.ToClose_button3_Click);
            // 
            // IdentificationCard_label1
            // 
            this.IdentificationCard_label1.AutoSize = true;
            this.IdentificationCard_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdentificationCard_label1.Location = new System.Drawing.Point(12, 86);
            this.IdentificationCard_label1.Name = "IdentificationCard_label1";
            this.IdentificationCard_label1.Size = new System.Drawing.Size(169, 23);
            this.IdentificationCard_label1.TabIndex = 25;
            this.IdentificationCard_label1.Text = "Identification Card";
            // 
            // IdentificationCard_textBox1
            // 
            this.IdentificationCard_textBox1.Location = new System.Drawing.Point(187, 88);
            this.IdentificationCard_textBox1.Name = "IdentificationCard_textBox1";
            this.IdentificationCard_textBox1.Size = new System.Drawing.Size(259, 22);
            this.IdentificationCard_textBox1.TabIndex = 22;
            // 
            // AddGuarantor_label1
            // 
            this.AddGuarantor_label1.AutoSize = true;
            this.AddGuarantor_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuarantor_label1.Location = new System.Drawing.Point(122, 9);
            this.AddGuarantor_label1.Name = "AddGuarantor_label1";
            this.AddGuarantor_label1.Size = new System.Drawing.Size(223, 37);
            this.AddGuarantor_label1.TabIndex = 21;
            this.AddGuarantor_label1.Text = "Add Guarantor";
            // 
            // Payment_label1
            // 
            this.Payment_label1.AutoSize = true;
            this.Payment_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment_label1.Location = new System.Drawing.Point(12, 132);
            this.Payment_label1.Name = "Payment_label1";
            this.Payment_label1.Size = new System.Drawing.Size(84, 23);
            this.Payment_label1.TabIndex = 28;
            this.Payment_label1.Text = "Payment";
            // 
            // Payment_textBox1
            // 
            this.Payment_textBox1.Location = new System.Drawing.Point(187, 144);
            this.Payment_textBox1.Name = "Payment_textBox1";
            this.Payment_textBox1.Size = new System.Drawing.Size(259, 22);
            this.Payment_textBox1.TabIndex = 27;
            // 
            // Add_Guarantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 218);
            this.Controls.Add(this.Payment_label1);
            this.Controls.Add(this.Payment_textBox1);
            this.Controls.Add(this.Send_button1);
            this.Controls.Add(this.Name_label1);
            this.Controls.Add(this.Name_textBox1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.IdentificationCard_label1);
            this.Controls.Add(this.IdentificationCard_textBox1);
            this.Controls.Add(this.AddGuarantor_label1);
            this.Name = "Add_Guarantor";
            this.Text = "Add_Guarantor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button1;
        private System.Windows.Forms.Label Name_label1;
        private System.Windows.Forms.TextBox Name_textBox1;
        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label IdentificationCard_label1;
        private System.Windows.Forms.TextBox IdentificationCard_textBox1;
        private System.Windows.Forms.Label AddGuarantor_label1;
        private System.Windows.Forms.Label Payment_label1;
        private System.Windows.Forms.TextBox Payment_textBox1;
    }
}