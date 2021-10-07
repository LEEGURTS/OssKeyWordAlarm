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


namespace OssKeyWordAlarm
{
    public partial class Form1 : Form
    {
        private Form activeForm;
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
            pnlNav.Height = makeKeyword.Height;
            pnlNav.Top = makeKeyword.Top;
            pnlNav.Left = makeKeyword.Left;
            Form_Title.Text = "KEYWORD";
            makeKeyword.BackColor = Color.FromArgb(46, 51, 73); //초기 강조선 설정
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }    
        private Point MouseDownLocation; //마우스 위치
        private void Panel_Drag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Panel_Drag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Left = e.X + Left - MouseDownLocation.X;
                Top = e.Y + Top - MouseDownLocation.Y;
            }
        }
        private void showDialog() //알람울림
        {
            Forms.Alert art = new Forms.Alert();
            art.Show();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void OpenChildForm(Form childForm, object btnSender) //새로운 폼 형성 함수
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Multi_Panel.Controls.Add(childForm);
            Multi_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Multi_Panel.Text = childForm.Text;
        }
        private void makeKeyword_Leave(object sender, EventArgs e) //키워드 설정 나올때
        {
            makeKeyword.BackColor = Color.FromArgb(24,30,54);
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
            pnlNav.Height = makeKeyword.Height;
            pnlNav.Top = makeKeyword.Top;
            pnlNav.Left = makeKeyword.Left;
            makeKeyword.BackColor = Color.FromArgb(46, 51, 73);
            Form_Title.Text = "KEYWORD";
            OpenChildForm(new makeKey(), sender);         
        }

        private void recordAlarm_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Height = recordAlarm.Height;
            pnlNav.Top = recordAlarm.Top;
            pnlNav.Left = recordAlarm.Left;
            recordAlarm.BackColor = Color.FromArgb(46, 51, 73);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "ALARM LIST";
            OpenChildForm(new Forms.recordAlar(), sender);
        }

        private void addLink_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Height = addLink.Height;
            pnlNav.Top = addLink.Top;
            pnlNav.Left = addLink.Left;
            addLink.BackColor = Color.FromArgb(46, 51, 73);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "ADD LINK";
            OpenChildForm(new Forms.addLin(), sender);
        }

        private void changeAlarm_MouseDown(object sender, MouseEventArgs e) //위와 같음
        {
            pnlNav.Height = changeAlarm.Height;
            pnlNav.Top = changeAlarm.Top;
            pnlNav.Left = changeAlarm.Left;
            changeAlarm.BackColor = Color.FromArgb(46, 51, 73);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "CHANGE ALARM";
            OpenChildForm(new Forms.changeAlar(), sender);

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
    }
}
