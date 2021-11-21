using System;
using System.Windows.Forms;
using System.Media;

namespace OssKeyWordAlarm.Forms
{
    public partial class Alert : Form
    {
        public Alert()
        {
            InitializeComponent();
        }
        private void fadeIn(object sender, EventArgs e) //페이드인
        {
            if (Opacity >= 1)
            {
                timer1.Stop();
            }//다보이면 함수 종료
            else
                Opacity += 0.05;
        }
        private void fadeout(object sender, EventArgs e) //페이드 아웃
        {
            if (Opacity <= 0)
            {
                timer3.Stop();
                Close();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            Forms.changeAlar.AlarmSound.Position = 0;
            System.IO.Stream str = Forms.changeAlar.AlarmSound;
            SoundPlayer player;
            player = new SoundPlayer();
            player.Stream = str;
            Opacity = 0;      //처음엔 투명하게 설정
            timer1.Interval = 10;  //10ms 딜레이
            timer1.Tick += new EventHandler(fadeIn);  //Opacity변경         
            timer1.Start();
            timer2.Start();
            player.Play();
            Top = Screen.PrimaryScreen.Bounds.Height - 160;
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 10;
            timer3.Tick += new EventHandler(fadeout);
            timer3.Start();
        }
        public void chText(string str)
        {
            testTxt.Text = str + " 공지사항이 업로드 되었습니다.";
        }
    }
}
