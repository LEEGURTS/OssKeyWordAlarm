using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HtmlAgilityPack;
using System.Xml;
using System.Threading;

namespace OssKeyWordAlarm
{
    public partial class Form1 : Form
    {
        User user = new User();
        HashSet<Article> articles = new HashSet<Article>();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);


        public Form1()
        {
            InitializeComponent();
            pnlNav.Height = btnMakeKeyword.Height;
            pnlNav.Top = btnMakeKeyword.Top;
            pnlNav.Left = btnMakeKeyword.Left;
            Form_Title.Text = "KEYWORD";
            btnMakeKeyword.BackColor = Color.FromArgb(46, 51, 73); //초기 강조선 설정
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //테두리를 원형으로 설정
            html_parsing();
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
        }

        public void ThreadProc()
        {
            while (true)
            {
                new_article_detecting();
            }
        }

        private Point MouseDownLocation; //마우스 위치
        private void Panel_Drag_MouseDown(object sender, MouseEventArgs e) //마우스 위치 전달
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }
        private void Panel_Drag_MouseMove(object sender, MouseEventArgs e) //드래그로 폼을 이동시키는 함수
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Left = e.X + Left - MouseDownLocation.X;
                Top = e.Y + Top - MouseDownLocation.Y;
            }
        }
        makeKey newkey = new makeKey(); //폼 작성
        Forms.addLin newaddLink = new Forms.addLin(); //폼 적용
        Forms.changeAlar newchangeAlert = new Forms.changeAlar(); //폼 적용
        Forms.recordAlar newrecordAlert = new Forms.recordAlar(); //폼 적용

        private void showDialog() //알람울림
        {
            Forms.Alert art = new Forms.Alert();
            art.Show();
        }

        private void OpenChildForm(Form childForm, object btnSender) //새로운 폼 형성 함수
        {
            childForm.TopLevel = false;
            childForm.Height = this.Height;
            childForm.Width = this.Width;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill; //위에는 차일드 폼에 관한 초기값 형성
            Multi_Panel.Controls.Add(childForm); //차일드 폼에 관한 컨트롤 권한 부여
            Multi_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); //출력
            Multi_Panel.Text = childForm.Text;
        }
        private void makeKeyword_Leave(object sender, EventArgs e) //키워드 설정 나올때
        {
            btnMakeKeyword.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void addLink_Leave(object sender, EventArgs e) //링크 추가 나올때
        {
            addLink.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void recordAlarm_Leave(object sender, EventArgs e) //알람기록 나올때
        {
            recordAlarm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void changeAlarm_Leave(object sender, EventArgs e) //알람소리 바꾸기에서 나올때
        {
            changeAlarm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void makeKeyword_MouseDown(object sender, MouseEventArgs e) // 키워드 설정 클릭하자마자 강조와 함께 새로운 폼 띄움
        {
            pnlNav.Height = btnMakeKeyword.Height;
            pnlNav.Top = btnMakeKeyword.Top;
            pnlNav.Left = btnMakeKeyword.Left;
            btnMakeKeyword.BackColor = Color.FromArgb(46, 51, 73);
            Form_Title.Text = "KEYWORD";
            OpenChildForm(newkey, sender);
        }

        private void recordAlarm_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Height = recordAlarm.Height;
            pnlNav.Top = recordAlarm.Top;
            pnlNav.Left = recordAlarm.Left;
            recordAlarm.BackColor = Color.FromArgb(46, 51, 73);
            btnMakeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "ALARM LIST";
            OpenChildForm(newrecordAlert, sender);
        }

        private void addLink_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Height = addLink.Height;
            pnlNav.Top = addLink.Top;
            pnlNav.Left = addLink.Left;
            addLink.BackColor = Color.FromArgb(46, 51, 73);
            btnMakeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "ADD LINK";
            OpenChildForm(newaddLink, sender);
        }

        private void changeAlarm_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Height = changeAlarm.Height;
            pnlNav.Top = changeAlarm.Top;
            pnlNav.Left = changeAlarm.Left;
            changeAlarm.BackColor = Color.FromArgb(46, 51, 73);
            btnMakeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "CHANGE ALARM";
            OpenChildForm(newchangeAlert, sender);
        }



        private void Exit_Button_Click(object sender, EventArgs e) //프로그램 종료 버튼
        {
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e) //확대버튼
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }

        }

        private void Minimize_Click(object sender, EventArgs e) //축소 버튼
        {
            WindowState = FormWindowState.Minimized;
        }

        private void testButton_Click(object sender, EventArgs e) //임시 알림용 버튼
        {
            showDialog();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // user가 키워드 알람을 허용해놓은 url들만 들어가서 가장 상단의 글 번호를 출력
        public void html_parsing()
        {
            foreach (KeyValuePair<string, bool> pair in user.Urls)
            {
                if (pair.Value)
                {
                    string target_url = pair.Key;
                    HtmlWeb target_web = new HtmlWeb();
                    for (int page_num = 1; page_num <= 1; page_num++)
                    {
                        string now_target_url = target_url + "?MaxRows=10&tpage=" + page_num.ToString() + "&searchKey=1&searchVal=&srCategoryId=";
                        var target_doc = target_web.Load(now_target_url);

                        var node = target_doc.DocumentNode.SelectNodes("//body//div//div//div//div//div//div//div//div//li//div//a[@href]");
                        var date_node = target_doc.DocumentNode.SelectNodes("//body//div//p[contains(@class, 'info')]");
                        int index = 0;
                        foreach (HtmlNode link in node)
                        {
                            string hrefValue = link.GetAttributeValue("href", string.Empty);
                            //Console.WriteLine(hrefValue);
                            string[] separatingStrings = { "DUID=", "&tpage=" };
                            string[] words = hrefValue.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                            Char[] delimiters = { '|', ' ', ' ', ' ', '|', ' ', ' ' };
                            string date = date_node[index].InnerText.Split(delimiters)[9];
                            articles.Add(new Article(hrefValue, Int32.Parse(words[1]), "content",date));
                            Console.WriteLine(hrefValue);
                            Console.WriteLine(date);
                            index++;
                        }
                    }
                }
            }
        }

        public void new_article_detecting()
        {
            foreach (KeyValuePair<string, bool> pair in user.Urls)
            {
                if (pair.Value)
                {
                    string target_url = pair.Key;
                    HtmlWeb target_web = new HtmlWeb();
                    for (int page_num = 1; page_num <= 1; page_num++)
                    {
                        string now_target_url = target_url + "?MaxRows=10&tpage=" + page_num.ToString() + "&searchKey=1&searchVal=&srCategoryId=";
                        var target_doc = target_web.Load(now_target_url);

                        var node = target_doc.DocumentNode.SelectNodes("//body//div//div//div//div//div//div//div//div//li//div//a[@href]");
                        var date_node = target_doc.DocumentNode.SelectNodes("//body//div//p[contains(@class, 'info')]");
                        int index = 0;

                        foreach (HtmlNode link in node)
                        {
                            string hrefValue = link.GetAttributeValue("href", string.Empty);
                            //Console.WriteLine(hrefValue);
                            string[] separatingStrings = { "DUID=", "&tpage=" };
                            string[] words = hrefValue.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                            Char[] delimiters = { '|', ' ', ' ', ' ', '|', ' ', ' ' };
                            string date = date_node[index].InnerText.Split(delimiters)[9];
                            if (!articles.Contains(new Article(hrefValue, Int32.Parse(words[1]), "content",date)))
                            {
                                articles.Add(new Article(hrefValue, Int32.Parse(words[1]), "content",date));
                                Console.WriteLine("new article detected : " + hrefValue);
                            }
                            index++;
                        }
                    }
                }
            }
        }
    }
}
