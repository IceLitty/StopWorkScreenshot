using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StopWorkScreenshot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private string _applicationName = "_application_name";
        private string _language = "en";
        private int _timetick = 0;
        private bool isExpand = false;
        private bool isExpand2 = false;

        public void setApplicationName(string applicationName)
        {
            _applicationName = applicationName;
        }

        public void setLanguage(string language)
        {
            if (language == "cn" || language == "en")
            {
                _language = language;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (_language == "en")
            {
                cancelBtn.Text = "Cancel";
                if (_applicationName != string.Empty)
                {
                    this.Text = _applicationName;
                    string temp = _applicationName + " has stopped working";
                    expandText(temp);
                }
                else
                {
                    this.Text = "Microsoft Windows";
                    ErrorTitle.Text = "Microsoft Windows has stopped working";
                }
            }
            else if (_language == "cn")
            {
                cancelBtn.Text = "取消";
                if (_applicationName != string.Empty)
                {
                    this.Text = _applicationName;
                    string temp = _applicationName + " 已停止工作";
                    expandText(temp);
                }
                else
                {
                    this.Text = "Microsoft Windows";
                    ErrorTitle.Text = "Microsoft Windows 已停止工作";
                }
            }
            cancelBtn.Select();
            Timer.Start();
        }

        private void expandText(string temp)
        {
            if (Regex.IsMatch(_applicationName, @"[\u4e00-\u9fbb]+"))
            {
                if (temp.Length > 18)
                {
                    ErrorTitle.Text = temp.Substring(0, 18) + "\r\n" + temp.Substring(18, temp.Length - 18);
                    expandForm("title");
                }
                else
                {
                    ErrorTitle.Text = temp;
                }
            }
            else
            {
                if (_applicationName.IndexOf(' ') != -1)
                {
                    if (temp.Length > 35)
                    {
                        int index = temp.Substring(10, temp.Length - 10).IndexOf(' ') + 10;
                        ErrorTitle.Text = temp.Substring(0, index) + "\r\n" + temp.Substring(index, temp.Length - index);
                        expandForm("title");
                    }
                    else
                    {
                        ErrorTitle.Text = temp;
                    }
                }
                else
                {
                    if (temp.Length > 30)
                    {
                        ErrorTitle.Text = temp.Substring(0, 30) + "\r\n" + temp.Substring(30, temp.Length - 30);
                        expandForm("title");
                    }
                    else
                    {
                        ErrorTitle.Text = temp;
                    }
                }
            }
        }

        private void expandForm(string titleORsubtitle)
        {
            if (titleORsubtitle == "subtitle3cn")
            {
                int heightAdd = 30;
                pgb.Hide();
                this.Height -= heightAdd;
                cancelBtn.Location = new Point(cancelBtn.Location.X, cancelBtn.Location.Y - heightAdd);
                panel1.Height -= heightAdd;
            }
            else
            {
                int heightAdd = 20;
                this.Height += heightAdd;
                cancelBtn.Location = new Point(cancelBtn.Location.X, cancelBtn.Location.Y + heightAdd);
                pgb.Location = new Point(pgb.Location.X, pgb.Location.Y + heightAdd);
                panel1.Height += heightAdd;
                if (titleORsubtitle == "title")
                {
                    ErrorText.Location = new Point(ErrorText.Location.X, ErrorText.Location.Y + heightAdd);
                }
                else if (titleORsubtitle == "subtitle3")
                {
                    heightAdd = 30;
                    pgb.Hide();
                    this.Height -= heightAdd;
                    cancelBtn.Location = new Point(cancelBtn.Location.X, cancelBtn.Location.Y - heightAdd);
                    panel1.Height -= heightAdd;
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //debug
            //this.Text = _timetick.ToString();
            //5s
            if (_timetick < 50)
            {
                if (_language == "en")
                {
                    ErrorText.Text = "Windows is checking for a solution to the problem...";
                }
                else if (_language == "cn")
                {
                    ErrorText.Text = "Windows 正在查找该问题的解决方案…";
                }
            }
            //8s
            else if (_timetick < 80)
            {
                if (_language == "en")
                {
                    ErrorText.Text = "Windows is collecting more information about the\r\nproblem. This might take several minutes...";
                }
                else if (_language == "cn")
                {
                    ErrorText.Text = "Windows 正在收集有关该问题的详细信息。这可能需要\r\n几分钟的时间…";
                }
                if (!isExpand)
                {
                    expandForm("subtitle");
                    isExpand = true;
                }
            }
            //15s
            else if (_timetick < 150)
            {
                if (_language == "en")
                {
                    ErrorText.Text = "A problem caused the program to stop working\r\ncorrectly. Windows will close the program and notify\r\nyou if a solution is available.";
                    cancelBtn.Text = "Close Program";
                    if (!isExpand2)
                    {
                        expandForm("subtitle3");
                        cancelBtn.Width += 70;
                        cancelBtn.Location = new Point(cancelBtn.Location.X - 70, cancelBtn.Location.Y);
                        isExpand2 = true;
                    }
                }
                else if (_language == "cn")
                {
                    ErrorText.Text = "出现了一个问题，导致程序停止正常工作。如果有可用的\r\n解决方案，Windows 将关闭程序并通知你。";
                    cancelBtn.Text = "关闭程序";
                    if (!isExpand2)
                    {
                        expandForm("subtitle3cn");
                        cancelBtn.Width += 30;
                        cancelBtn.Location = new Point(cancelBtn.Location.X - 30, cancelBtn.Location.Y);
                        isExpand2 = true;
                    }
                }
            }
            else
            {
                Timer.Stop();
            }
            _timetick++;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                SendKeys.Send("%{PRTSC}");
            }
            else if (e.KeyCode == Keys.F6)
            {
                DateTime dt = DateTime.Now;
                string time = "" + dt.Year + dt.Month + dt.Day + dt.Hour + dt.Minute + dt.Second;
                string path = System.AppDomain.CurrentDomain.BaseDirectory + time;
                if (Clipboard.GetDataObject() != null)
                {
                    IDataObject data = Clipboard.GetDataObject();
                    if (data.GetDataPresent(DataFormats.Bitmap))
                    {
                        Image image = (Image)data.GetData(DataFormats.Bitmap, true);
                        image.Save(path + @".png", ImageFormat.Png);
                        Clipboard.Clear();
                        //MessageBox.Show("Successfully");
                    }
                    else
                    {
                        //MessageBox.Show("Not image");
                    }
                }
                else
                {
                    //MessageBox.Show("Empty");
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (isExpand2 == true && e.KeyCode == Keys.C)
            {
                this.Close();
            }
        }
    }
}
