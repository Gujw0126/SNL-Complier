namespace WFD.Forms
{
    partial class Formsemantic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Sbegin = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SOutPut = new System.Windows.Forms.TextBox();
            this.Now_L = new System.Windows.Forms.Label();
            this.Now = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Swrongout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Sbegin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 77);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 16);
            this.panel2.TabIndex = 1;
            // 
            // Sbegin
            // 
            this.Sbegin.BackColor = System.Drawing.Color.White;
            this.Sbegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sbegin.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sbegin.ForeColor = System.Drawing.Color.Black;
            this.Sbegin.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.Sbegin.IconColor = System.Drawing.Color.Green;
            this.Sbegin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Sbegin.IconSize = 28;
            this.Sbegin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sbegin.Location = new System.Drawing.Point(5, 3);
            this.Sbegin.Name = "Sbegin";
            this.Sbegin.Size = new System.Drawing.Size(288, 63);
            this.Sbegin.TabIndex = 0;
            this.Sbegin.Text = "开始分析";
            this.Sbegin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sbegin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sbegin.UseVisualStyleBackColor = false;
            this.Sbegin.Click += new System.EventHandler(this.Sbegin_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 77);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.Swrongout);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(970, 531);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.splitContainer2.Panel1.Controls.Add(this.SOutPut);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2.Controls.Add(this.Now_L);
            this.splitContainer2.Panel2.Controls.Add(this.Now);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.ForeColor = System.Drawing.Color.White;
            this.splitContainer2.Size = new System.Drawing.Size(970, 373);
            this.splitContainer2.SplitterDistance = 523;
            this.splitContainer2.TabIndex = 0;
            // 
            // SOutPut
            // 
            this.SOutPut.BackColor = System.Drawing.Color.White;
            this.SOutPut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SOutPut.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOutPut.ForeColor = System.Drawing.Color.Black;
            this.SOutPut.Location = new System.Drawing.Point(0, 0);
            this.SOutPut.Multiline = true;
            this.SOutPut.Name = "SOutPut";
            this.SOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SOutPut.Size = new System.Drawing.Size(523, 373);
            this.SOutPut.TabIndex = 5;
            this.SOutPut.WordWrap = false;
            // 
            // Now_L
            // 
            this.Now_L.AutoSize = true;
            this.Now_L.Font = new System.Drawing.Font("隶书", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Now_L.ForeColor = System.Drawing.Color.DarkGreen;
            this.Now_L.Location = new System.Drawing.Point(3, 3);
            this.Now_L.Name = "Now_L";
            this.Now_L.Size = new System.Drawing.Size(63, 44);
            this.Now_L.TabIndex = 3;
            this.Now_L.Text = "√";
            // 
            // Now
            // 
            this.Now.AutoSize = true;
            this.Now.Location = new System.Drawing.Point(52, 200);
            this.Now.Name = "Now";
            this.Now.Size = new System.Drawing.Size(0, 18);
            this.Now.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(80, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 150);
            this.label3.TabIndex = 1;
            this.label3.Text = "输出：\r\n *标识符符号表\r\n *类型信息表\r\n *过程信息表\r\n *形参信息表";
            // 
            // Swrongout
            // 
            this.Swrongout.BackColor = System.Drawing.Color.White;
            this.Swrongout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Swrongout.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Swrongout.ForeColor = System.Drawing.Color.Black;
            this.Swrongout.Location = new System.Drawing.Point(0, 28);
            this.Swrongout.Multiline = true;
            this.Swrongout.Name = "Swrongout";
            this.Swrongout.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Swrongout.Size = new System.Drawing.Size(970, 126);
            this.Swrongout.TabIndex = 1;
            this.Swrongout.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("楷体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "错误输出：";
            // 
            // Formsemantic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 608);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "Formsemantic";
            this.Text = "semantic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formsemantic_FormClosing);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox Swrongout;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Sbegin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SOutPut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Now;
        private System.Windows.Forms.Label Now_L;
    }
}