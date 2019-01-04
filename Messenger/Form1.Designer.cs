namespace Messenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lst_KisiListesi = new System.Windows.Forms.ListBox();
            this.rch_GidenYazi = new System.Windows.Forms.RichTextBox();
            this.rch_GelenYazi = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lst_KisiListesi
            // 
            resources.ApplyResources(this.lst_KisiListesi, "lst_KisiListesi");
            this.lst_KisiListesi.FormattingEnabled = true;
            this.lst_KisiListesi.Name = "lst_KisiListesi";
            // 
            // rch_GidenYazi
            // 
            resources.ApplyResources(this.rch_GidenYazi, "rch_GidenYazi");
            this.rch_GidenYazi.Name = "rch_GidenYazi";
            // 
            // rch_GelenYazi
            // 
            resources.ApplyResources(this.rch_GelenYazi, "rch_GelenYazi");
            this.rch_GelenYazi.Name = "rch_GelenYazi";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = global::Messenger.Properties.Resources.personal;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_Gonder
            // 
            resources.ApplyResources(this.btn_Gonder, "btn_Gonder");
            this.btn_Gonder.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Gonder.BackgroundImage = global::Messenger.Properties.Resources.email__mail__message__send__online__e_mail__envelope_128;
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_KisiListesi);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.rch_GidenYazi);
            this.Controls.Add(this.rch_GelenYazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_KisiListesi;
        private System.Windows.Forms.Button btn_Gonder;
        private System.Windows.Forms.RichTextBox rch_GidenYazi;
        private System.Windows.Forms.RichTextBox rch_GelenYazi;
    }
}

