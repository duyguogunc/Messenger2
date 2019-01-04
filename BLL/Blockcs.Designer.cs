namespace BLL
{
    partial class Blockcs
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
            this.listBoxBlock = new System.Windows.Forms.ListBox();
            this.Btn_Block = new System.Windows.Forms.Button();
            this.Btn_UnBlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBlock
            // 
            this.listBoxBlock.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxBlock.FormattingEnabled = true;
            this.listBoxBlock.Location = new System.Drawing.Point(0, 0);
            this.listBoxBlock.Name = "listBoxBlock";
            this.listBoxBlock.Size = new System.Drawing.Size(258, 429);
            this.listBoxBlock.TabIndex = 0;
            // 
            // Btn_Block
            // 
            this.Btn_Block.Location = new System.Drawing.Point(305, 34);
            this.Btn_Block.Name = "Btn_Block";
            this.Btn_Block.Size = new System.Drawing.Size(126, 52);
            this.Btn_Block.TabIndex = 1;
            this.Btn_Block.Text = "Block";
            this.Btn_Block.UseVisualStyleBackColor = true;
            // 
            // Btn_UnBlock
            // 
            this.Btn_UnBlock.Location = new System.Drawing.Point(305, 343);
            this.Btn_UnBlock.Name = "Btn_UnBlock";
            this.Btn_UnBlock.Size = new System.Drawing.Size(126, 52);
            this.Btn_UnBlock.TabIndex = 2;
            this.Btn_UnBlock.Text = "UnBlock";
            this.Btn_UnBlock.UseVisualStyleBackColor = true;
            // 
            // Blockcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 429);
            this.Controls.Add(this.Btn_UnBlock);
            this.Controls.Add(this.Btn_Block);
            this.Controls.Add(this.listBoxBlock);
            this.Name = "Blockcs";
            this.Text = "Blockcs";
            this.Load += new System.EventHandler(this.Blockcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBlock;
        private System.Windows.Forms.Button Btn_Block;
        private System.Windows.Forms.Button Btn_UnBlock;
    }
}