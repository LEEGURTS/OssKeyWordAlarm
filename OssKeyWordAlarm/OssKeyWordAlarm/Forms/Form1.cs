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
            makeKeyword.BackColor = Color.FromArgb(37, 75, 76);
 
        }
        private void showDialog()
        {
            Forms.Alert art = new Forms.Alert();
            art.Show();          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Multi_Panel.Controls.Add(childForm);
            this.Multi_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Multi_Panel.Text = childForm.Text;
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
            Form_Title.Text = "KEYWORD";
            OpenChildForm(new makeKey(), sender);         
        }

        private void recordAlarm_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNav.Height = recordAlarm.Height;
            pnlNav.Top = recordAlarm.Top;
            pnlNav.Left = recordAlarm.Left;
            recordAlarm.BackColor = Color.FromArgb(37, 75, 76);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "ALARM LIST";
            OpenChildForm(new Forms.recordAlar(), sender);
        }

        private void addLink_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNav.Height = addLink.Height;
            pnlNav.Top = addLink.Top;
            pnlNav.Left = addLink.Left;
            addLink.BackColor = Color.FromArgb(37, 75, 76);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "ADD LINK";
            OpenChildForm(new Forms.addLin(), sender);
        }

        private void changeAlarm_MouseDown(object sender, MouseEventArgs e)
        {
            pnlNav.Height = changeAlarm.Height;
            pnlNav.Top = changeAlarm.Top;
            pnlNav.Left = changeAlarm.Left;
            changeAlarm.BackColor = Color.FromArgb(37, 75, 76);
            makeKeyword.BackColor = Color.FromArgb(24, 30, 54);
            Form_Title.Text = "CHANGE ALARM";
            OpenChildForm(new Forms.changeAlar(), sender);

        }



        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            showDialog();
        }
    }
}
