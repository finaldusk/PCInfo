namespace PCInfo
{
    partial class MainForm
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
            this.button_copy2Clipboard = new System.Windows.Forms.Button();
            this.button_copyMACAdd = new System.Windows.Forms.Button();
            this.label_MACInfo = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_saveInfo = new System.Windows.Forms.Button();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_copy2Clipboard
            // 
            this.button_copy2Clipboard.Location = new System.Drawing.Point(12, 69);
            this.button_copy2Clipboard.Name = "button_copy2Clipboard";
            this.button_copy2Clipboard.Size = new System.Drawing.Size(220, 23);
            this.button_copy2Clipboard.TabIndex = 0;
            this.button_copy2Clipboard.Text = "复制计算机硬件信息";
            this.button_copy2Clipboard.UseVisualStyleBackColor = true;
            this.button_copy2Clipboard.Click += new System.EventHandler(this.button_copy2Clipboard_Click);
            // 
            // button_copyMACAdd
            // 
            this.button_copyMACAdd.Location = new System.Drawing.Point(12, 40);
            this.button_copyMACAdd.Name = "button_copyMACAdd";
            this.button_copyMACAdd.Size = new System.Drawing.Size(161, 23);
            this.button_copyMACAdd.TabIndex = 1;
            this.button_copyMACAdd.Text = "复制MAC地址";
            this.button_copyMACAdd.UseVisualStyleBackColor = true;
            this.button_copyMACAdd.Click += new System.EventHandler(this.button_copyMACAdd_Click);
            // 
            // label_MACInfo
            // 
            this.label_MACInfo.AutoSize = true;
            this.label_MACInfo.Location = new System.Drawing.Point(12, 9);
            this.label_MACInfo.Name = "label_MACInfo";
            this.label_MACInfo.Size = new System.Drawing.Size(29, 12);
            this.label_MACInfo.TabIndex = 2;
            this.label_MACInfo.Text = "MAC:";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 97);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(245, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel.Text = "欢迎使用！";
            // 
            // button_saveInfo
            // 
            this.button_saveInfo.Location = new System.Drawing.Point(180, 40);
            this.button_saveInfo.Name = "button_saveInfo";
            this.button_saveInfo.Size = new System.Drawing.Size(52, 23);
            this.button_saveInfo.TabIndex = 4;
            this.button_saveInfo.Text = "保存";
            this.button_saveInfo.UseVisualStyleBackColor = true;
            this.button_saveInfo.Click += new System.EventHandler(this.button_saveInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 119);
            this.Controls.Add(this.button_saveInfo);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.label_MACInfo);
            this.Controls.Add(this.button_copyMACAdd);
            this.Controls.Add(this.button_copy2Clipboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统信息检测";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_copy2Clipboard;
        private System.Windows.Forms.Button button_copyMACAdd;
        private System.Windows.Forms.Label label_MACInfo;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button button_saveInfo;
    }
}

