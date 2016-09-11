using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace StopWorkScreenshot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplicationName.Select();
        }

        private string tCNStr = "F5保存截图至剪切板后F6保存文件";
        private string tENStr = "F5 Save Screenshot and F6 save to file";
        private string aCNStr = "请输入应用程序显示名...file:开头则识为文件";
        private string aENStr = "App Name...Import file with file: prefix";

        private void rbCN_Click(object sender, EventArgs e)
        {
            this.Text = tCNStr;
            textChanged();
            ApplicationName.Focus();
        }

        private void rbEN_Click(object sender, EventArgs e)
        {
            this.Text = tENStr;
            textChanged();
            ApplicationName.Focus();
        }

        private void ApplicationName_TextChanged(object sender, EventArgs e)
        {
            textChanged();
        }

        private void textChanged()
        {
            if (ApplicationName.Text.Length > 0)
            {
                ApplicationNameWatermark.Text = string.Empty;
            }
            else
            {
                if (rbCN.Checked)
                {
                    ApplicationNameWatermark.Text = aCNStr;
                }
                else if (rbEN.Checked)
                {
                    ApplicationNameWatermark.Text = aENStr;
                }
            }
        }

        private void ApplicationName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ApplicationName.Text.Length >= 5 && ApplicationName.Text.Substring(0, 5).ToLower() == "file:")
                {
                    string path = ApplicationName.Text.Substring(5, ApplicationName.Text.Length - 5);
                    List<string> txt = new List<string>();
                    using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                    {
                        int lineCount = 0;
                        while (sr.Peek() > 0)
                        {
                            lineCount++;
                            string temp = sr.ReadLine();
                            txt.Add(temp);
                        }
                    }
                    for (int i = 0; i < txt.Count - 1; i++)
                    {
                        nextWindow(txt[i], true);
                    }
                    nextWindow(txt[txt.Count - 1], false);
                }
                else
                {
                    nextWindow();
                }
            }
        }

        private void nextWindow()
        {
            nextWindow(ApplicationName.Text, false);
        }

        private void nextWindow(string appname, bool showORshowDialog)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.setApplicationName(appname);
            if (rbCN.Checked)
            {
                f2.setLanguage("cn");
            }
            else if (rbEN.Checked)
            {
                f2.setLanguage("en");
            }
            if (showORshowDialog)
            {
                f2.Show();
            }
            else
            {
                f2.ShowDialog();
            }
            this.Show();
        }

        private void ApplicationNameWatermark_MouseDown(object sender, MouseEventArgs e)
        {
            ApplicationName.Select();
        }
    }
}
