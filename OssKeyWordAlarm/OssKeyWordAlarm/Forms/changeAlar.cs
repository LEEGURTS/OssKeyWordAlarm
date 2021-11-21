using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace OssKeyWordAlarm.Forms
{
    public partial class changeAlar : Form
    {

        [DllImport("winmm.dll", SetLastError = true)] 
        private static extern int waveOutSetVolume(IntPtr device, uint volume);
        [DllImport("winmm.dll", SetLastError = true)]
        public static extern int waveOutGetVolume(IntPtr hwo, out uint dwVolume);


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse);

        public changeAlar()
        {
            InitializeComponent();
        }
        public static System.IO.Stream AlarmSound= Properties.Resources.Bamboo;
        private void changeAlar_Load(object sender, EventArgs e)
        {
            btnBamboo.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBamboo.Width, btnBamboo.Height, 20, 20));
            btnPlayground.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPlayground.Width, btnPlayground.Height, 20, 20));
            btnYa.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnYa.Width, btnYa.Height, 20, 20));
            btnBBiBBi.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnBBiBBi.Width, btnBBiBBi.Height, 20, 20));
            btnWater.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnWater.Width, btnWater.Height, 20, 20));
            btnAscent.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAscent.Width, btnAscent.Height, 20, 20));
            btnLoad.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLoad.Width, btnLoad.Height, 20, 20));
            btnTest.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnTest.Width, btnTest.Height, 20, 20));
            trackBar1.Value = 50;
            SetVolume(trackBar1.Value);
        }
        private void btnBamboo_Click(object sender, EventArgs e)
        {
            AlarmSound= Properties.Resources.Bamboo;
        }

        private void btnYa_Click(object sender, EventArgs e)
        {
            AlarmSound = Properties.Resources.야;
        }

        private void btnPlayground_Click(object sender, EventArgs e)
        {
            AlarmSound = Properties.Resources.놀이터;
        }

        private void btnBBiBBi_Click(object sender, EventArgs e)
        {
            AlarmSound = Properties.Resources.삐비동_알람소리;
        }

        private void btnAscent_Click(object sender, EventArgs e)
        {
            AlarmSound = Properties.Resources.상승;
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            AlarmSound = Properties.Resources.물방울;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "wav";
            openFile.Filter = "Audio File(*.wav|*.wav;";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    AlarmSound = File.OpenRead(filename);
                }
            }
        }
        private void SetVolume(int volume)
        {
            int newVolume = ((ushort.MaxValue / 100) * volume);
            uint newVolumeAll=(((uint)newVolume*0x00010000)+((uint)newVolume*0x00000001));
            waveOutSetVolume(IntPtr.Zero, (uint)newVolumeAll);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                SetVolume(trackBar1.Value);
            }
            else
            {
                waveOutSetVolume(IntPtr.Zero, (uint)0x00000000);
            }
        }
    }
}
