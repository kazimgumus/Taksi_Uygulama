namespace Taksi_Uygulamasi
{
    partial class SoforEkle
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
            this.Kayıt = new System.Windows.Forms.GroupBox();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.DtpKayit = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Kayıt.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kayıt
            // 
            this.Kayıt.BackColor = System.Drawing.Color.DarkOrange;
            this.Kayıt.Controls.Add(this.dateTimePicker1);
            this.Kayıt.Controls.Add(this.label7);
            this.Kayıt.Controls.Add(this.KaydetBtn);
            this.Kayıt.Controls.Add(this.DtpKayit);
            this.Kayıt.Controls.Add(this.label6);
            this.Kayıt.Controls.Add(this.MskTel);
            this.Kayıt.Controls.Add(this.TxtMail);
            this.Kayıt.Controls.Add(this.TxtKullaniciAdi);
            this.Kayıt.Controls.Add(this.TxtSoyadi);
            this.Kayıt.Controls.Add(this.TxtAdi);
            this.Kayıt.Controls.Add(this.label5);
            this.Kayıt.Controls.Add(this.label4);
            this.Kayıt.Controls.Add(this.label3);
            this.Kayıt.Controls.Add(this.label2);
            this.Kayıt.Controls.Add(this.label1);
            this.Kayıt.Location = new System.Drawing.Point(-2, 1);
            this.Kayıt.Name = "Kayıt";
            this.Kayıt.Size = new System.Drawing.Size(802, 451);
            this.Kayıt.TabIndex = 14;
            this.Kayıt.TabStop = false;
            this.Kayıt.Text = "Kayıt";
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydetBtn.Location = new System.Drawing.Point(143, 358);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(139, 37);
            this.KaydetBtn.TabIndex = 25;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.UseVisualStyleBackColor = true;
            // 
            // DtpKayit
            // 
            this.DtpKayit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpKayit.Location = new System.Drawing.Point(134, 294);
            this.DtpKayit.Name = "DtpKayit";
            this.DtpKayit.Size = new System.Drawing.Size(211, 25);
            this.DtpKayit.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kayıt Tarihi:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // MskTel
            // 
            this.MskTel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTel.Location = new System.Drawing.Point(132, 211);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(213, 22);
            this.MskTel.TabIndex = 22;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMail.Location = new System.Drawing.Point(132, 168);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(213, 22);
            this.TxtMail.TabIndex = 21;
            // 
            // TxtKullaniciAdi
            // 
            this.TxtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtKullaniciAdi.Location = new System.Drawing.Point(132, 128);
            this.TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            this.TxtKullaniciAdi.Size = new System.Drawing.Size(213, 22);
            this.TxtKullaniciAdi.TabIndex = 20;
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtSoyadi.Location = new System.Drawing.Point(132, 86);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(213, 22);
            this.TxtSoyadi.TabIndex = 19;
            // 
            // TxtAdi
            // 
            this.TxtAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtAdi.Location = new System.Drawing.Point(132, 41);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(213, 22);
            this.TxtAdi.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Yaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(-1, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Ehliyet Alım:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 249);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 25);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // SoforEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kayıt);
            this.Name = "SoforEkle";
            this.Text = "SoforEkle";
            this.Kayıt.ResumeLayout(false);
            this.Kayıt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Kayıt;
        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.DateTimePicker DtpKayit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtKullaniciAdi;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}