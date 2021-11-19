using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace OssKeyWordAlarm.Forms
{
    public partial class recordAlar : Form
    {
        List<Notice> notices = new List<Notice>();

        functions_h aaa = new functions_h();
        public List<string> title = new List<string>();
        public List<string> url = new List<string>();
        // Notice 폼의 List -> 시작 시 RecordShow함수로 List를 채움 + 채우자 마자 화면에 출력
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);

        public recordAlar()
        {
            InitializeComponent();
            load_info();
            RecordShow(title, url);
            flowLayoutPanel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, flowLayoutPanel1.Width, flowLayoutPanel1.Height, 20, 20));
            flowLayoutPanel1.VerticalScroll.Enabled = false;
            flowLayoutPanel1.VerticalScroll.Visible = false;
            btnRemoveAll.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRemoveAll.Width, btnRemoveAll.Height, 20, 20));
        }

        public recordAlar(Form1 fom)
        {
            InitializeComponent();
            load_info();
            RecordShow(title, url);
        }

        public void load_info()
        {
            title = aaa.read_file("new_title.txt");
            url = aaa.read_file("new_url.txt");
        }

        public void RecordShow(List<string> name, List<string> url) //제목과 url의 리스트를 삽입시 리스트를 출력해주는 함수.
        {
            if (notices.Count != 0)
            {
                label1.Text = "알람을 클릭시 웹사이트로 이동합니다.";
                notices.Clear();
            }
            else
            {
                label1.Text = "읽지 않은 알람이 없습니다.";
            }

            for (int i = 0; i < name.Count; i++)
            {
                notices.Add(new Notice(this));
                notices[i].Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, notices[i].Width, notices[i].Height, 15, 15));
                notices[i].title = name[i];
                notices[i].url = "www.kw.ac.kr" + url[i];
                flowLayoutPanel1.Controls.Add(notices[i]);
            }
        }

        private void recordAlar_Load(object sender, EventArgs e)
        {
            btnRemoveAll.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRemoveAll.Width, btnRemoveAll.Height, 15, 15));


            //이 문장은 추후 삭제가 필요함.
            List<string> name = new List<string>();
            List<string> url = new List<string>();
            RecordShow(name, url);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "new_url.txt"), String.Empty);
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "new_title.txt"), String.Empty);
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(label1);
            load_info();
            RecordShow(title, url);
        }
        // 모든 알림 기록을 지움 ****************************
        
    }
}
