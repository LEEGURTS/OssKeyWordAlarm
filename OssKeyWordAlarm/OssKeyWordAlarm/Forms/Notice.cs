using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OssKeyWordAlarm.Forms
{


    public partial class Notice : UserControl
    {

        public Notice()
        {
            InitializeComponent();
        }
        public Notice(string str)
        {
            lbltitle.Text = str;
            InitializeComponent();          
        }
        #region Properties
        private string _title;
        private string _url;
        [Category ("MyList")]
        public string title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                lbltitle.Text = value;
            }
        }
        [Category("MyList")]
        public string url {
            get
            {
                return _url;
            }
            set
            {
                _url = value;
                lblUrl.Text = value;
            }
        }

        #endregion

        private void Notice_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(_url);
        }
    }
}
