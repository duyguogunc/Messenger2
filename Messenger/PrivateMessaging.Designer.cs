namespace Messenger
{
    partial class PrivateMessaging
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
            this.rTB_ReceivingMSG = new System.Windows.Forms.RichTextBox();
            this.rTB_SendingMsg = new System.Windows.Forms.RichTextBox();
            this.btn_PrivateMsgSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Emoji = new System.Windows.Forms.Button();
            this.flp_Emoji = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // rTB_ReceivingMSG
            // 
            this.rTB_ReceivingMSG.Location = new System.Drawing.Point(12, 74);
            this.rTB_ReceivingMSG.Name = "rTB_ReceivingMSG";
            this.rTB_ReceivingMSG.Size = new System.Drawing.Size(369, 143);
            this.rTB_ReceivingMSG.TabIndex = 0;
            this.rTB_ReceivingMSG.Text = "";
            // 
            // rTB_SendingMsg
            // 
            this.rTB_SendingMsg.Location = new System.Drawing.Point(12, 235);
            this.rTB_SendingMsg.Name = "rTB_SendingMsg";
            this.rTB_SendingMsg.Size = new System.Drawing.Size(369, 55);
            this.rTB_SendingMsg.TabIndex = 1;
            this.rTB_SendingMsg.Text = "";
            // 
            // btn_PrivateMsgSend
            // 
            this.btn_PrivateMsgSend.Location = new System.Drawing.Point(317, 296);
            this.btn_PrivateMsgSend.Name = "btn_PrivateMsgSend";
            this.btn_PrivateMsgSend.Size = new System.Drawing.Size(64, 23);
            this.btn_PrivateMsgSend.TabIndex = 2;
            this.btn_PrivateMsgSend.Text = "Gönder";
            this.btn_PrivateMsgSend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btn_Emoji
            // 
            this.btn_Emoji.Location = new System.Drawing.Point(248, 296);
            this.btn_Emoji.Name = "btn_Emoji";
            this.btn_Emoji.Size = new System.Drawing.Size(63, 23);
            this.btn_Emoji.TabIndex = 4;
            this.btn_Emoji.Text = "Emoji";
            this.btn_Emoji.UseVisualStyleBackColor = true;
            this.btn_Emoji.Click += new System.EventHandler(this.btn_Emoji_Click);
            // 
            // flp_Emoji
            // 
            this.flp_Emoji.Location = new System.Drawing.Point(12, 296);
            this.flp_Emoji.Name = "flp_Emoji";
            this.flp_Emoji.Size = new System.Drawing.Size(230, 55);
            this.flp_Emoji.TabIndex = 5;
            // 
            // PrivateMessaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 351);
            this.Controls.Add(this.flp_Emoji);
            this.Controls.Add(this.btn_Emoji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PrivateMsgSend);
            this.Controls.Add(this.rTB_SendingMsg);
            this.Controls.Add(this.rTB_ReceivingMSG);
            this.Name = "PrivateMessaging";
            this.Text = "PrivateMessaging";
            this.Load += new System.EventHandler(this.PrivateMessaging_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTB_ReceivingMSG;
        private System.Windows.Forms.RichTextBox rTB_SendingMsg;
        private System.Windows.Forms.Button btn_PrivateMsgSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Emoji;
        private System.Windows.Forms.FlowLayoutPanel flp_Emoji;
    }
}