namespace StopWorkScreenshot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbCN = new System.Windows.Forms.RadioButton();
            this.rbEN = new System.Windows.Forms.RadioButton();
            this.ApplicationNameWatermark = new System.Windows.Forms.Label();
            this.ApplicationName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbCN
            // 
            this.rbCN.AutoSize = true;
            this.rbCN.Checked = true;
            this.rbCN.Location = new System.Drawing.Point(12, 13);
            this.rbCN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbCN.Name = "rbCN";
            this.rbCN.Size = new System.Drawing.Size(50, 21);
            this.rbCN.TabIndex = 1;
            this.rbCN.TabStop = true;
            this.rbCN.Text = "中文";
            this.rbCN.UseVisualStyleBackColor = true;
            this.rbCN.Click += new System.EventHandler(this.rbCN_Click);
            // 
            // rbEN
            // 
            this.rbEN.AutoSize = true;
            this.rbEN.Location = new System.Drawing.Point(68, 13);
            this.rbEN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbEN.Name = "rbEN";
            this.rbEN.Size = new System.Drawing.Size(67, 21);
            this.rbEN.TabIndex = 2;
            this.rbEN.Text = "English";
            this.rbEN.UseVisualStyleBackColor = true;
            this.rbEN.Click += new System.EventHandler(this.rbEN_Click);
            // 
            // ApplicationNameWatermark
            // 
            this.ApplicationNameWatermark.AutoSize = true;
            this.ApplicationNameWatermark.BackColor = System.Drawing.Color.White;
            this.ApplicationNameWatermark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApplicationNameWatermark.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ApplicationNameWatermark.Location = new System.Drawing.Point(16, 42);
            this.ApplicationNameWatermark.Name = "ApplicationNameWatermark";
            this.ApplicationNameWatermark.Size = new System.Drawing.Size(241, 17);
            this.ApplicationNameWatermark.TabIndex = 5;
            this.ApplicationNameWatermark.Text = "请输入应用程序显示名...file:开头则识为文件";
            this.ApplicationNameWatermark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ApplicationNameWatermark_MouseDown);
            // 
            // ApplicationName
            // 
            this.ApplicationName.AllowDrop = true;
            this.ApplicationName.Location = new System.Drawing.Point(12, 39);
            this.ApplicationName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ApplicationName.Name = "ApplicationName";
            this.ApplicationName.Size = new System.Drawing.Size(270, 23);
            this.ApplicationName.TabIndex = 4;
            this.ApplicationName.TextChanged += new System.EventHandler(this.ApplicationName_TextChanged);
            this.ApplicationName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.ApplicationName_PreviewKeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 75);
            this.Controls.Add(this.ApplicationNameWatermark);
            this.Controls.Add(this.ApplicationName);
            this.Controls.Add(this.rbEN);
            this.Controls.Add(this.rbCN);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F5保存截图至剪切板后F6保存文件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCN;
        private System.Windows.Forms.RadioButton rbEN;
        private System.Windows.Forms.Label ApplicationNameWatermark;
        private System.Windows.Forms.TextBox ApplicationName;
    }
}

