namespace WFD.Forms
{
    partial class FormLexical
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LWrongput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbegin = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LWrongput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 258);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "错误输出";
            // 
            // LWrongput
            // 
            this.LWrongput.BackColor = System.Drawing.Color.White;
            this.LWrongput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LWrongput.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LWrongput.ForeColor = System.Drawing.Color.Black;
            this.LWrongput.Location = new System.Drawing.Point(0, 31);
            this.LWrongput.Multiline = true;
            this.LWrongput.Name = "LWrongput";
            this.LWrongput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LWrongput.Size = new System.Drawing.Size(1187, 227);
            this.LWrongput.TabIndex = 0;
            this.LWrongput.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Lbegin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 71);
            this.panel1.TabIndex = 2;
            // 
            // Lbegin
            // 
            this.Lbegin.BackColor = System.Drawing.Color.White;
            this.Lbegin.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lbegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Lbegin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lbegin.ForeColor = System.Drawing.Color.Black;
            this.Lbegin.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.Lbegin.IconColor = System.Drawing.Color.Green;
            this.Lbegin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Lbegin.IconSize = 30;
            this.Lbegin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbegin.Location = new System.Drawing.Point(0, 3);
            this.Lbegin.Name = "Lbegin";
            this.Lbegin.Size = new System.Drawing.Size(290, 56);
            this.Lbegin.TabIndex = 0;
            this.Lbegin.Text = "开始分析";
            this.Lbegin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbegin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Lbegin.UseVisualStyleBackColor = false;
            this.Lbegin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Lbegin_MouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 71);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.Input);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.LOutput);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Size = new System.Drawing.Size(1187, 353);
            this.splitContainer1.SplitterDistance = 524;
            this.splitContainer1.TabIndex = 3;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.White;
            this.Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input.ForeColor = System.Drawing.Color.Black;
            this.Input.Location = new System.Drawing.Point(0, 21);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Input.Size = new System.Drawing.Size(524, 332);
            this.Input.TabIndex = 1;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "请在下方输入语句：";
            // 
            // LOutput
            // 
            this.LOutput.BackColor = System.Drawing.Color.White;
            this.LOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LOutput.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOutput.ForeColor = System.Drawing.Color.Black;
            this.LOutput.Location = new System.Drawing.Point(0, 21);
            this.LOutput.Multiline = true;
            this.LOutput.Name = "LOutput";
            this.LOutput.ReadOnly = true;
            this.LOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LOutput.Size = new System.Drawing.Size(659, 332);
            this.LOutput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Token序列如下：";
            // 
            // FormLexical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1187, 682);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLexical";
            this.Text = "Lexical";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLexical_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LWrongput;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Lbegin;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LOutput;
        private System.Windows.Forms.Label label3;
    }
}