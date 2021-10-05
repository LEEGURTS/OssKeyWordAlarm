using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer1.Stop();   //this stops the timer if the form is completely displayed
            else
                Opacity += 0.05;
        }
        private void fadeout(object sender,EventArgs e)
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
            System.IO.Stream str = Properties.Resources.Bamboo;
            SoundPlayer player = new SoundPlayer(str);
            Opacity = 0;      //first the opacity is 0
            timer1.Interval = 10;  //we'll increase the opacity every 10ms
            timer1.Tick += new EventHandler(fadeIn);  //this calls the function that changes opacity         
            timer1.Start();
            timer2.Start();
            player.Play();
            Top = 920;
            Left = Screen.PrimaryScreen.Bounds.Width-Width;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 10;
            timer3.Tick += new EventHandler(fadeout);
            timer3.Start();
        }
    }
}
