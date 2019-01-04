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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.chc_BeniHatirla = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dİLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tÜRKÇEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNGİLİZCEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLMANCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_kullaniciresim = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kullaniciresim)).BeginInit();
            this.SuspendLayout();
            // 
            // chc_BeniHatirla
            // 
            resources.ApplyResources(this.chc_BeniHatirla, "chc_BeniHatirla");
            this.chc_BeniHatirla.Name = "chc_BeniHatirla";
            this.chc_BeniHatirla.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_sifre
            // 
            resources.ApplyResources(this.txt_sifre, "txt_sifre");
            this.txt_sifre.Name = "txt_sifre";
            // 
            // txt_KullaniciAdi
            // 
            resources.ApplyResources(this.txt_KullaniciAdi, "txt_KullaniciAdi");
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_kullaniciadi
            // 
            resources.ApplyResources(this.lbl_kullaniciadi, "lbl_kullaniciadi");
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dİLToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dİLToolStripMenuItem
            // 
            resources.ApplyResources(this.dİLToolStripMenuItem, "dİLToolStripMenuItem");
            this.dİLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tÜRKÇEToolStripMenuItem,
            this.iNGİLİZCEToolStripMenuItem,
            this.aLMANCAToolStripMenuItem});
            this.dİLToolStripMenuItem.Name = "dİLToolStripMenuItem";
            // 
            // tÜRKÇEToolStripMenuItem
            // 
            resources.ApplyResources(this.tÜRKÇEToolStripMenuItem, "tÜRKÇEToolStripMenuItem");
            this.tÜRKÇEToolStripMenuItem.Name = "tÜRKÇEToolStripMenuItem";
            // 
            // iNGİLİZCEToolStripMenuItem
            // 
            resources.ApplyResources(this.iNGİLİZCEToolStripMenuItem, "iNGİLİZCEToolStripMenuItem");
            this.iNGİLİZCEToolStripMenuItem.Name = "iNGİLİZCEToolStripMenuItem";
            this.iNGİLİZCEToolStripMenuItem.Click += new System.EventHandler(this.iNGİLİZCEToolStripMenuItem_Click);
            // 
            // aLMANCAToolStripMenuItem
            // 
            resources.ApplyResources(this.aLMANCAToolStripMenuItem, "aLMANCAToolStripMenuItem");
            this.aLMANCAToolStripMenuItem.Name = "aLMANCAToolStripMenuItem";
            // 
            // pic_kullaniciresim
            // 
            resources.ApplyResources(this.pic_kullaniciresim, "pic_kullaniciresim");
            this.pic_kullaniciresim.BackgroundImage = global::Messenger.Properties.Resources.msn1;
            this.pic_kullaniciresim.Name = "pic_kullaniciresim";
            this.pic_kullaniciresim.TabStop = false;
            // 
            // Giris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chc_BeniHatirla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.Controls.Add(this.pic_kullaniciresim);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Giris";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_kullaniciresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chc_BeniHatirla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.PictureBox pic_kullaniciresim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dİLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tÜRKÇEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNGİLİZCEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLMANCAToolStripMenuItem;
    }
}