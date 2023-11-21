namespace button._43
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTopla = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSonuc2 = new System.Windows.Forms.Label();
            this.lblSonuc3 = new System.Windows.Forms.Label();
            this.lblSonuc4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı 2";
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(88, 148);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(84, 66);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "Sonuç";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(88, 47);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 9;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(88, 79);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 10;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(197, 134);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(48, 13);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "Toplama";
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // lblSonuc2
            // 
            this.lblSonuc2.AutoSize = true;
            this.lblSonuc2.Location = new System.Drawing.Point(197, 161);
            this.lblSonuc2.Name = "lblSonuc2";
            this.lblSonuc2.Size = new System.Drawing.Size(45, 13);
            this.lblSonuc2.TabIndex = 12;
            this.lblSonuc2.Text = "Çıkarma";
            // 
            // lblSonuc3
            // 
            this.lblSonuc3.AutoSize = true;
            this.lblSonuc3.Location = new System.Drawing.Point(197, 187);
            this.lblSonuc3.Name = "lblSonuc3";
            this.lblSonuc3.Size = new System.Drawing.Size(43, 13);
            this.lblSonuc3.TabIndex = 13;
            this.lblSonuc3.Text = "Çarpma";
            // 
            // lblSonuc4
            // 
            this.lblSonuc4.AutoSize = true;
            this.lblSonuc4.Location = new System.Drawing.Point(197, 212);
            this.lblSonuc4.Name = "lblSonuc4";
            this.lblSonuc4.Size = new System.Drawing.Size(36, 13);
            this.lblSonuc4.TabIndex = 14;
            this.lblSonuc4.Text = "Bölme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 411);
            this.Controls.Add(this.lblSonuc4);
            this.Controls.Add(this.lblSonuc3);
            this.Controls.Add(this.lblSonuc2);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonuc2;
        private System.Windows.Forms.Label lblSonuc3;
        private System.Windows.Forms.Label lblSonuc4;
    }
}

