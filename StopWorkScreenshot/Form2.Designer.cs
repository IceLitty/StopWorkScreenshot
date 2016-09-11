namespace StopWorkScreenshot
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.ErrorText = new System.Windows.Forms.Label();
            this.ErrorTitle = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pgb);
            this.panel1.Controls.Add(this.ErrorText);
            this.panel1.Controls.Add(this.ErrorTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 116);
            this.panel1.TabIndex = 0;
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(8, 79);
            this.pgb.MarqueeAnimationSpeed = 20;
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(328, 16);
            this.pgb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgb.TabIndex = 2;
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ErrorText.Location = new System.Drawing.Point(4, 44);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(65, 19);
            this.ErrorText.TabIndex = 1;
            this.ErrorText.Text = "ErrorText";
            // 
            // ErrorTitle
            // 
            this.ErrorTitle.AutoSize = true;
            this.ErrorTitle.Font = new System.Drawing.Font("微软雅黑", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ErrorTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.ErrorTitle.Location = new System.Drawing.Point(4, 9);
            this.ErrorTitle.Name = "ErrorTitle";
            this.ErrorTitle.Size = new System.Drawing.Size(84, 23);
            this.ErrorTitle.TabIndex = 0;
            this.ErrorTitle.Text = "ErrorTitle";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(265, 124);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(70, 25);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelBtn.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cancelBtn_PreviewKeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 155);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label ErrorTitle;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.ProgressBar pgb;
    }
}