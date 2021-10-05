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
            makeKeyword.BackColor = Color.FromArgb(37, 75, 76);


        }

        public void example()
        {
            var url = @"https://www.kw.ac.kr/ko/life/notice.jsp";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            Console.WriteLine("Node Name :" + node.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            example();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void makeKeyword_Leave(object sender, EventArgs e)
        {
            makeKeyword.BackColor = Color.FromArgb(24,30,54);
        }

        private void addLink_Leave(object sender, EventArgs e)
        {
            addLink.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void recordAlarm_Leave(object sender, EventArgs e)
        {
            recordAlarm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void changeAlarm_Leave(object sender, EventArgs e)
        {
            changeAlarm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void makeKeyword_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNav.Height = makeKeyword.Height;
            pnlNav.Top = makeKeyword.Top;
            pnlNav.Left = makeKeyword.Left;
            makeKeyword.BackColor = Color.FromArgb(37, 75, 76);
        }

        private void recordAlarm_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNav.Height = recordAlarm.Height;
            pnlNav.Top = recordAlarm.Top;
            pnlNav.Left = recordAlarm.Left;
            recordAlarm.BackColor = Color.FromArgb(37, 75, 76);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void addLink_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNav.Height = addLink.Height;
            pnlNav.Top = addLink.Top;
            pnlNav.Left = addLink.Left;
            addLink.BackColor = Color.FromArgb(37, 75, 76);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void changeAlarm_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNav.Height = changeAlarm.Height;
            pnlNav.Top = changeAlarm.Top;
            pnlNav.Left = changeAlarm.Left;
            changeAlarm.BackColor = Color.FromArgb(37, 75, 76);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Program_Exit_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
