namespace Messenger
{
    partial class Giris
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
            this.chc_BeniHatirla = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.pic_kullaniciresim = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kullaniciresim)).BeginInit();
            this.SuspendLayout();
            // 
            // chc_BeniHatirla
            // 
            this.chc_BeniHatirla.AutoSize = true;
            this.chc_BeniHatirla.Location = new System.Drawing.Point(67, 408);
            this.chc_BeniHatirla.Name = "chc_BeniHatirla";
            this.chc_BeniHatirla.Size = new System.Drawing.Size(103, 21);
            this.chc_BeniHatirla.TabIndex = 14;
            this.chc_BeniHatirla.Text = "Beni Hatırla";
            this.chc_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Oturum Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(67, 363);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(266, 22);
            this.txt_sifre.TabIndex = 12;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(67, 296);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(266, 22);
            this.txt_eposta.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Parola:";
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(64, 261);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(88, 17);
            this.lbl_kullaniciadi.TabIndex = 9;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı:";
            // 
            // pic_kullaniciresim
            // 
            this.pic_kullaniciresim.BackgroundImage = global::Messenger.Properties.Resources.msn1;
            this.pic_kullaniciresim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_kullaniciresim.Location = new System.Drawing.Point(135, 85);
            this.pic_kullaniciresim.Name = "pic_kullaniciresim";
            this.pic_kullaniciresim.Size = new System.Drawing.Size(143, 137);
            this.pic_kullaniciresim.TabIndex = 8;
            this.pic_kullaniciresim.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 15;
            this.button2.Text = "Kayıt Ol";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(397, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chc_BeniHatirla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_eposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Controls.Add(this.pic_kullaniciresim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Giris";
            this.Text = "Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pic_kullaniciresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chc_BeniHatirla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.PictureBox pic_kullaniciresim;
        private System.Windows.Forms.Button button2;
    }
}