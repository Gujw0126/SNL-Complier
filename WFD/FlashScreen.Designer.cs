namespace WFD
{
    partial class FlashScreen
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelProgressbarContainer = new System.Windows.Forms.Panel();
            this.panelProcessbar = new System.Windows.Forms.Panel();
            this.timerProgressbar = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxScreenBack = new System.Windows.Forms.PictureBox();
            this.panelProgressbarContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProgressbarContainer
            // 
            this.panelProgressbarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(128)))), ((int)(((byte)(130)))));
            this.panelProgressbarContainer.Controls.Add(this.panelProcessbar);
            this.panelProgressbarContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProgressbarContainer.Location = new System.Drawing.Point(0, 472);
            this.panelProgressbarContainer.Name = "panelProgressbarContainer";
            this.panelProgressbarContainer.Size = new System.Drawing.Size(882, 24);
            this.panelProgressbarContainer.TabIndex = 1;
            // 
            // panelProcessbar
            // 
            this.panelProcessbar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelProcessbar.Location = new System.Drawing.Point(0, 0);
            this.panelProcessbar.Name = "panelProcessbar";
            this.panelProcessbar.Size = new System.Drawing.Size(40, 31);
            this.panelProcessbar.TabIndex = 2;
            this.panelProcessbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProcessbar_Paint);
            // 
            // timerProgressbar
            // 
            this.timerProgressbar.Enabled = true;
            this.timerProgressbar.Interval = 30;
            this.timerProgressbar.Tick += new System.EventHandler(this.timerProgressbar_Tick);
            // 
            // pictureBoxScreenBack
            // 
            this.pictureBoxScreenBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxScreenBack.Image = global::WFD.Properties.Resources.flash2;
            this.pictureBoxScreenBack.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxScreenBack.Name = "pictureBoxScreenBack";
            this.pictureBoxScreenBack.Size = new System.Drawing.Size(882, 496);
            this.pictureBoxScreenBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScreenBack.TabIndex = 0;
            this.pictureBoxScreenBack.TabStop = false;
            // 
            // FlashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 496);
            this.Controls.Add(this.panelProgressbarContainer);
            this.Controls.Add(this.pictureBoxScreenBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelProgressbarContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxScreenBack;
        private System.Windows.Forms.Panel panelProgressbarContainer;
        private System.Windows.Forms.Panel panelProcessbar;
        private System.Windows.Forms.Timer timerProgressbar;
    }
}

