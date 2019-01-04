namespace Messenger
{
    partial class KayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitOl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi1 = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.rd_kadin = new System.Windows.Forms.RadioButton();
            this.rd_erkek = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sifretekrar = new System.Windows.Forms.TextBox();
            this.btn_fotosec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_Ad
            // 
            resources.ApplyResources(this.txt_Ad, "txt_Ad");
            this.txt_Ad.Name = "txt_Ad";
            // 
            // txt_soyad
            // 
            resources.ApplyResources(this.txt_soyad, "txt_soyad");
            this.txt_soyad.Name = "txt_soyad";
            // 
            // txt_KullaniciAdi1
            // 
            resources.ApplyResources(this.txt_KullaniciAdi1, "txt_KullaniciAdi1");
            this.txt_KullaniciAdi1.Name = "txt_KullaniciAdi1";
            // 
            // txt_sifre
            // 
            resources.ApplyResources(this.txt_sifre, "txt_sifre");
            this.txt_sifre.Name = "txt_sifre";
            // 
            // btn_kaydol
            // 
            resources.ApplyResources(this.btn_kaydol, "btn_kaydol");
            this.btn_kaydol.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_kaydol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.UseVisualStyleBackColor = false;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // rd_kadin
            // 
            resources.ApplyResources(this.rd_kadin, "rd_kadin");
            this.rd_kadin.Name = "rd_kadin";
            this.rd_kadin.TabStop = true;
            this.rd_kadin.UseVisualStyleBackColor = true;
            // 
            // rd_erkek
            // 
            resources.ApplyResources(this.rd_erkek, "rd_erkek");
            this.rd_erkek.Name = "rd_erkek";
            this.rd_erkek.TabStop = true;
            this.rd_erkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt_sifretekrar
            // 
            resources.ApplyResources(this.txt_sifretekrar, "txt_sifretekrar");
            this.txt_sifretekrar.Name = "txt_sifretekrar";
            // 
            // btn_fotosec
            // 
            resources.ApplyResources(this.btn_fotosec, "btn_fotosec");
            this.btn_fotosec.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_fotosec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_fotosec.Name = "btn_fotosec";
            this.btn_fotosec.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // KayitOl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.btn_fotosec);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rd_erkek);
            this.Controls.Add(this.rd_kadin);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.txt_sifretekrar);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_KullaniciAdi1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KayitOl";
            this.Load += new System.EventHandler(this.KayitOl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_KullaniciAdi1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.RadioButton rd_kadin;
        private System.Windows.Forms.RadioButton rd_erkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_sifretekrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_fotosec;
    }
}