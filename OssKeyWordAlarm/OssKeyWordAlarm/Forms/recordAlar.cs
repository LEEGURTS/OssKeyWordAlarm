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
                notices.Clear();
            }
            for (int i = 0; i < 10; i++)
            {
                notices.Add(new Notice());
                notices[i].Region=System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, notices[i].Width, notices[i].Height, 15, 15));
                notices[i].title = "Title";//name[i];
                notices[i].url = "URL";//url[i];
                flowLayoutPanel1.Controls.Add(notices[i]);
            }
        }
        private void recordAlar_Load(object sender, EventArgs e)
        {

        }
    }
}
