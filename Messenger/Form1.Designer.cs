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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lst_KisiListesi = new System.Windows.Forms.ListBox();
            this.rch_GidenYazi = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.lst_KisiListesi.FormattingEnabled = true;
            resources.ApplyResources(this.lst_KisiListesi, "lst_KisiListesi");
            this.lst_KisiListesi.Name = "lst_KisiListesi";
            this.lst_KisiListesi.SelectedIndexChanged += new System.EventHandler(this.lst_KisiListesi_SelectedIndexChanged);
            // 
            // rch_GidenYazi
            // 
            resources.ApplyResources(this.rch_GidenYazi, "rch_GidenYazi");
            this.rch_GidenYazi.Name = "rch_GidenYazi";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Messenger.Properties.Resources.personal;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Gonder.BackgroundImage = global::Messenger.Properties.Resources.email__mail__message__send__online__e_mail__envelope_128;
            resources.ApplyResources(this.btn_Gonder, "btn_Gonder");
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.UseVisualStyleBackColor = false;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_KisiListesi);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.rch_GidenYazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

