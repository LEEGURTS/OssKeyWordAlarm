using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OssKeyWordAlarm.Forms
{
    public partial class recordAlar : Form
    {
        List<Notice> notices=new List<Notice>();
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
        }

        public void RecordShow(List<string> name,List<string> url) //제목과 url의 리스트를 삽입시 리스트를 출력해주는 함수.
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
                notices.Add(new Notice());
                notices[i].Region=System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, notices[i].Width, notices[i].Height, 15, 15));
                notices[i].title = name[i];//name[i];
                notices[i].url = url[i];//url[i];
                flowLayoutPanel1.Controls.Add(notices[i]);
            }
        }
        private void recordAlar_Load(object sender, EventArgs e)
        {
            btnRemove.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRemove.Width, btnRemove.Height, 15, 15));


            //이 문장은 추후 삭제가 필요함.
            List<string> name=new List<string>();
            List<string> url=new List<string>();
            name.Add("테스트문구입니다. 추가 이용시 recordAlar폼의 Load부분을 삭제해주세요.");
            url.Add("https://github.com/LEEGURTS/OssKeyWordAlarm");
            RecordShow(name, url) ;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //호준아 파이팅 너의 파트를 만들어드렸읍니다
            //누르면 모든 글 읽은걸로 처리시키면 됨.
        }
    }
}
