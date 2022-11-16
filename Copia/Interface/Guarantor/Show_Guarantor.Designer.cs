namespace Copia.Interface.Guarantor
{
    partial class Show_Guarantor
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
            this.ShowGuarantor_label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowGuarantor_button1 = new System.Windows.Forms.Button();
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
            // ShowGuarantor_label1
            // 
            this.ShowGuarantor_label1.AutoSize = true;
            this.ShowGuarantor_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGuarantor_label1.Location = new System.Drawing.Point(9, 7);
            this.ShowGuarantor_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowGuarantor_label1.Name = "ShowGuarantor_label1";
            this.ShowGuarantor_label1.Size = new System.Drawing.Size(200, 30);
            this.ShowGuarantor_label1.TabIndex = 4;
            this.ShowGuarantor_label1.Text = "Mostrar fiadores";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(9, 72);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(583, 220);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ShowGuarantor_button1
            // 
            this.ShowGuarantor_button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGuarantor_button1.Location = new System.Drawing.Point(423, 40);
            this.ShowGuarantor_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowGuarantor_button1.Name = "ShowGuarantor_button1";
            this.ShowGuarantor_button1.Size = new System.Drawing.Size(139, 28);
            this.ShowGuarantor_button1.TabIndex = 2;
            this.ShowGuarantor_button1.Text = "Mostrar fiadores";
            this.ShowGuarantor_button1.UseVisualStyleBackColor = true;
            this.ShowGuarantor_button1.Click += new System.EventHandler(this.ShowGuarantor_button1_Click);
            // 
            // Show_Guarantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 301);
            this.Controls.Add(this.ShowGuarantor_button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ToClose_button3);
            this.Controls.Add(this.ShowGuarantor_label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Show_Guarantor";
            this.Text = "Show_Guarantor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToClose_button3;
        private System.Windows.Forms.Label ShowGuarantor_label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowGuarantor_button1;
    }
}