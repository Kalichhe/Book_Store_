namespace Copia.Interface.Guarantor
{
    partial class Pay_Debt
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
            this.DNI_label1 = new System.Windows.Forms.Label();
            this.DNI_textBox1 = new System.Windows.Forms.TextBox();
            this.PayDebt_label1 = new System.Windows.Forms.Label();
            this.GoBack_button3 = new System.Windows.Forms.Button();
            this.AddPay_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pay_textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DNI_label1
            // 
            this.DNI_label1.AutoSize = true;
            this.DNI_label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI_label1.Location = new System.Drawing.Point(9, 70);
            this.DNI_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DNI_label1.Name = "DNI_label1";
            this.DNI_label1.Size = new System.Drawing.Size(38, 18);
            this.DNI_label1.TabIndex = 20;
            this.DNI_label1.Text = "DNI";
            // 
            // DNI_textBox1
            // 
            this.DNI_textBox1.Location = new System.Drawing.Point(50, 72);
            this.DNI_textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DNI_textBox1.Name = "DNI_textBox1";
            this.DNI_textBox1.Size = new System.Drawing.Size(195, 20);
            this.DNI_textBox1.TabIndex = 2;
            // 
            // PayDebt_label1
            // 
            this.PayDebt_label1.AutoSize = true;
            this.PayDebt_label1.Font = new System.Drawing.Font("Bell MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayDebt_label1.Location = new System.Drawing.Point(70, 7);
            this.PayDebt_label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PayDebt_label1.Name = "PayDebt_label1";
            this.PayDebt_label1.Size = new System.Drawing.Size(153, 30);
            this.PayDebt_label1.TabIndex = 21;
            this.PayDebt_label1.Text = "Pagar deuda";
            // 
            // GoBack_button3
            // 
            this.GoBack_button3.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBack_button3.Location = new System.Drawing.Point(9, 40);
            this.GoBack_button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GoBack_button3.Name = "GoBack_button3";
            this.GoBack_button3.Size = new System.Drawing.Size(74, 28);
            this.GoBack_button3.TabIndex = 1;
            this.GoBack_button3.Text = "Volver";
            this.GoBack_button3.UseVisualStyleBackColor = true;
            this.GoBack_button3.Click += new System.EventHandler(this.GoBack_button3_Click);
            // 
            // AddPay_button1
            // 
            this.AddPay_button1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPay_button1.Location = new System.Drawing.Point(89, 118);
            this.AddPay_button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPay_button1.Name = "AddPay_button1";
            this.AddPay_button1.Size = new System.Drawing.Size(134, 28);
            this.AddPay_button1.TabIndex = 4;
            this.AddPay_button1.Text = "Agregar pago";
            this.AddPay_button1.UseVisualStyleBackColor = true;
            this.AddPay_button1.Click += new System.EventHandler(this.Search_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Pago";
            // 
            // Pay_textBox1
            // 
            this.Pay_textBox1.Location = new System.Drawing.Point(50, 95);
            this.Pay_textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pay_textBox1.Name = "Pay_textBox1";
            this.Pay_textBox1.Size = new System.Drawing.Size(194, 20);
            this.Pay_textBox1.TabIndex = 3;
            // 
            // Pay_Debt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 154);
            this.Controls.Add(this.Pay_textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPay_button1);
            this.Controls.Add(this.GoBack_button3);
            this.Controls.Add(this.PayDebt_label1);
            this.Controls.Add(this.DNI_label1);
            this.Controls.Add(this.DNI_textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pay_Debt";
            this.Text = "Pay_Debt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DNI_label1;
        private System.Windows.Forms.TextBox DNI_textBox1;
        private System.Windows.Forms.Label PayDebt_label1;
        private System.Windows.Forms.Button GoBack_button3;
        private System.Windows.Forms.Button AddPay_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pay_textBox1;
    }
}