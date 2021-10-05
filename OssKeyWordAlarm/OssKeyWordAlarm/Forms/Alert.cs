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

        private void Alert_Load(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Bamboo;
            SoundPlayer player = new SoundPlayer(str);
            player.Play();
            timer1.Start();
            Top = 920;
            Left = Screen.PrimaryScreen.Bounds.Width-Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
