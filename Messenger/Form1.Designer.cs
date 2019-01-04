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
            this.label1 = new System.Windows.Forms.Label();
            this.lst_KisiListesi = new System.Windows.Forms.ListBox();
            this.rch_GidenYazi = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Gonder = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Online Kontakte";
            // 
            // lst_KisiListesi
            // 
            this.lst_KisiListesi.FormattingEnabled = true;
            this.lst_KisiListesi.ItemHeight = 16;
            this.lst_KisiListesi.Location = new System.Drawing.Point(12, 53);
            this.lst_KisiListesi.Name = "lst_KisiListesi";
            this.lst_KisiListesi.Size = new System.Drawing.Size(209, 468);
            this.lst_KisiListesi.TabIndex = 9;
            // 
            // rch_GidenYazi
            // 
            this.rch_GidenYazi.Location = new System.Drawing.Point(236, 367);
            this.rch_GidenYazi.Name = "rch_GidenYazi";
            this.rch_GidenYazi.Size = new System.Drawing.Size(585, 109);
            this.rch_GidenYazi.TabIndex = 7;
            this.rch_GidenYazi.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Messenger.Properties.Resources.personal;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Gonder
            // 
            this.btn_Gonder.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Gonder.BackgroundImage = global::Messenger.Properties.Resources.email__mail__message__send__online__e_mail__envelope_128;
            this.btn_Gonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Gonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_Gonder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Gonder.Location = new System.Drawing.Point(729, 482);
            this.btn_Gonder.Name = "btn_Gonder";
            this.btn_Gonder.Size = new System.Drawing.Size(92, 51);
            this.btn_Gonder.TabIndex = 8;
            this.btn_Gonder.UseVisualStyleBackColor = false;
            this.btn_Gonder.Click += new System.EventHandler(this.btn_Gonder_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(236, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(585, 286);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(837, 549);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lst_KisiListesi);
            this.Controls.Add(this.btn_Gonder);
            this.Controls.Add(this.rch_GidenYazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Unterhaltung";
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

