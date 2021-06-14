namespace Taksi_Uygulamasi
{
    partial class Soforler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyadı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Yaş = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ehliyet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kayıt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Adı,
            this.Soyadı,
            this.Yaş,
            this.Mail,
            this.Telefon,
            this.Ehliyet,
            this.Kayıt});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 299);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(803, 151);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No";
            // 
            // Adı
            // 
            this.Adı.Text = "Adı";
            this.Adı.Width = 79;
            // 
            // Soyadı
            // 
            this.Soyadı.Text = "Soyadı";
            this.Soyadı.Width = 101;
            // 
            // Yaş
            // 
            this.Yaş.Text = "Yaş";
            // 
            // Mail
            // 
            this.Mail.Text = "Mail";
            this.Mail.Width = 141;
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            this.Telefon.Width = 123;
            // 
            // Ehliyet
            // 
            this.Ehliyet.Text = "Ehliyet";
            this.Ehliyet.Width = 95;
            // 
            // Kayıt
            // 
            this.Kayıt.Text = "Kayıt";
            this.Kayıt.Width = 153;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Şoförler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 97);
            this.button2.TabIndex = 2;
            this.button2.Text = "Şoför Ekle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(654, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(394, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 97);
            this.button4.TabIndex = 4;
            this.button4.Text = "Şoför Sil";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(654, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "Güncelle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 97);
            this.button6.TabIndex = 6;
            this.button6.Text = "Şoför Ara";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Soforler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Soforler";
            this.Text = "Soforler";
            this.Load += new System.EventHandler(this.Soforler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Adı;
        private System.Windows.Forms.ColumnHeader Soyadı;
        private System.Windows.Forms.ColumnHeader Yaş;
        private System.Windows.Forms.ColumnHeader Mail;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Ehliyet;
        private System.Windows.Forms.ColumnHeader Kayıt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}