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
using System.Security.Permissions;
using System.IO;
using System.Diagnostics;

namespace OssKeyWordAlarm
{
    public partial class Form1 : Form
    {
        User user = new User();
        functions_h fun = new functions_h();
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
            makeKeyword_MouseDown(null, null);
            Tray_Icon.Visible = false;
            Form_Title.Text = "KEYWORD";
            btnMakeKeyword.BackColor = Color.FromArgb(46, 51, 73); //초기 강조선 설정
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //테두리를 원형으로 설정
            init_parsing();
        }

        public void ThreadProc()
        {
            while (true)
            {
                html_parsing();
                newrecordAlert = new Forms.recordAlar();
                //new_article_detecting();
                Delay(10000);
                // 600000 = 10분
            }
        }

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
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
        Forms.changeAlar newchangeAlert = new Forms.changeAlar(); //폼 적용
        Forms.recordAlar newrecordAlert = new Forms.recordAlar(); // 알람저장 폼 위치 이동
        public static void showDialog(string str) //알람울림
        {
            Forms.Alert art = new Forms.Alert();
            art.chText(str);
            art.Show();

        }

        private void OpenChildForm(Form childForm, object btnSender) //새로운 폼 형성 함수
        {
            childForm.TopLevel = false;
            childForm.Location = Multi_Panel.Location;
            childForm.Dock = DockStyle.Fill; //위에는 차일드 폼에 관한 초기값 형성
            Multi_Panel.Controls.Add(childForm); //차일드 폼에 관한 컨트롤 권한 부여
            Multi_Panel.Tag = childForm;
            //childForm.StartPosition = FormStartPosition.Manual;
            childForm.Size = Multi_Panel.Size;
            childForm.BringToFront();
            childForm.Show(); //출력    
        }

        private void makeKeyword_MouseDown(object sender, MouseEventArgs e) // 키워드 설정 클릭하자마자 강조와 함께 새로운 폼 띄움
        {
            pnlNav.Location = btnMakeKeyword.Location;
            btnMakeKeyword.BackColor = Color.FromArgb(46, 51, 73);
            recordAlarm.BackColor = Color.FromArgb(24, 30, 54);
            changeAlarm.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "KEYWORD";
            OpenChildForm(newkey, sender);
        }

        private void recordAlarm_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Location = recordAlarm.Location;
            recordAlarm.BackColor = Color.FromArgb(46, 51, 73);
            btnMakeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            changeAlarm.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "ALARM LIST";
            OpenChildForm(newrecordAlert, sender);
        }

        private void changeAlarm_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Location = changeAlarm.Location;
            changeAlarm.BackColor = Color.FromArgb(46, 51, 73);
            btnMakeKeyword.BackColor = Color.FromArgb(24, 30, 54);

            btnMakeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            recordAlarm.BackColor = Color.FromArgb(24, 30, 54);
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

        public void init_parsing()
        {
            //html_parsing();
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
        }
        // user가 키워드 알람을 허용해놓은 url들만 들어가서 가장 상단의 글 번호를 출력
        public void html_parsing()
        {
            List<string> saving_str = new List<string>();
            List<string> Title = new List<string>();
            // -> list에 넣어 -> 쌓여 -> 삭제 버튼
            // 
            foreach (KeyValuePair<string, bool> pair in user.Urls)
            {
                if (pair.Value)
                {
                    string target_url = pair.Key;
                    HtmlWeb target_web = new HtmlWeb();
                    char[] delimiterChars = { '=', '&' };
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
                            //string duid_str = hrefValue.Split(delimiterChars)[3]; // duid
                            //Console.WriteLine(hrefValue);
                            string[] separatingStrings = { "DUID=", "&tpage=" };
                            string[] words = hrefValue.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                            Char[] delimiters = { '|', ' ', ' ', ' ', '|', ' ', ' ' };
                            string date = date_node[index].InnerText.Split(delimiters)[9];
                            articles.Add(new Article(hrefValue, Int32.Parse(words[1]), "content", date));
                            //Console.WriteLine(hrefValue + date + " " + duid_str);
                            Title.Add(link.InnerText.Split('\n')[3].Substring(36));
                            if ((hrefValue + date) != null)
                                saving_str.Add(hrefValue + date); // 저장 위한 문자열
                            index++;
                        }
                    }
                    // 파싱 비교-----------------
                    Check(saving_str, Title);
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
                            if (!articles.Contains(new Article(hrefValue, Int32.Parse(words[1]), "content", date)))
                            {
                                articles.Add(new Article(hrefValue, Int32.Parse(words[1]), "content", date));
                                Console.WriteLine("new article detected : " + hrefValue);
                            }
                            index++;
                        }
                    }
                }
            }
        }

        public List<string> new_title = new List<string>();
        public List<string> new_url = new List<string>();
        // Check : 파싱 비교, 업데이트 함수입니다.
        public void Check(List<string> str, List<string> title)
        {
            // str은 url, title은 글 제목
            List<string> before = fun.read_file("parsing.txt");
            if (before.Count == 0)
            {
                fun.save_file("parsing.txt", str, 0);
                //Console.WriteLine("암것도 없어용");
                //save_parsing(str);
                before = fun.read_file("parsing.txt");
            } // 1) 처음 생성 시(txt 파일이 비어있다면) parsing을 최신화함.

            if (str[0] == before[0])
            {
                //Console.WriteLine("새 글 없음");
            }
            // 새 글이 올라오면 첫 번째 글이 바뀜 -> 첫 번째 글만 비교하면 됨.
            else
            {
                int point = -1, index3 = 0;
                while (point == -1 && index3 <= str.Count)
                { // point는 이전 파싱의 index3번째 주소의 현재 파싱 결과에서의 위치
                    point = str.IndexOf(before[index3]);
                    index3++;
                }

                if (point == -1 && index3 <= str.Count)
                {
                    //save_parsing(str);
                    fun.save_file("parsing.txt", str, 0);
                    //Console.WriteLine("업데이트");
                    return;
                }// 이전 파싱에서 현재 파싱과 일치하는 것이 없음 -> 업데이트 오랫동안 안됨 -> 현재 파싱 업데이트

                new_title.Clear();
                new_url.Clear();
                List<string> result = fun.read_file2("keywords.txt"); // 키워드를 담은 List
                List<bool> Alert_bool = new List<bool>();
                for (int i = 0; i < result.Count; i++)
                {
                    Alert_bool.Add(false);
                } // 키워드 별로 새 글에서 키워드가 존재하는지 여부 (bool)
                // ex) result[0]="장학" 이고, 제목에 "장학"이 존재하면 Alert_bool[0]=true
                for (int i = 0; i < point; i++)
                {
                    for (int k = 0; k < result.Count; k++)
                    {
                        Alert_bool[k] = false; // 초기화
                        if (title[i].IndexOf(result[k]) != -1)
                        {
                            Console.WriteLine("*" + title[i]);
                            Console.WriteLine("**" + result[k]);
                            Console.WriteLine("진짜잇음?" + title[i].IndexOf(result[k]));
                            Alert_bool[k] = true;
                        }
                    }
                    if (Alert_bool.IndexOf(true) != -1)
                    {
                        //Console.WriteLine("새거가 있네");
                        new_title.Add(title[i].Substring(0, title[i].Length - 1));
                        new_url.Add(str[i].Substring(0, str[i].Length - 10));
                    }
                }// 키워드가 새 글의 제목에 있는지 확인

                if (new_title.Count != 0)
                {
                    showDialog("");
                } // 새 글에 키워드가 있으면 알림
                foreach (string s in new_title)
                {
                    //Console.WriteLine(s);
                }
                fun.save_file("new_title.txt", new_title, 0);
                fun.save_file("new_url.txt", new_url, 0);
                fun.save_file("parsing.txt", str, 0);
                //Console.WriteLine("새 글 있음!");
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                Tray_Icon.Visible = true;
            }
        }

        private void Tray_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            Tray_Icon.Visible = false;
        }
    }
}