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
        recordAlar parents;
        public Notice()
        {
            InitializeComponent();
        }
        public Notice(recordAlar a)
        {
            InitializeComponent();
            parents = a;
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
                lblLink.Text = value;
            }
        }

        #endregion

        private void btn_link_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_url);
            parents.forms.new_title.Remove(_title);
            parents.forms.new_url.Remove(_url.Substring(12));
            parents.flowLayoutPanel1.Controls.Remove(this);
        }

        private void Notice_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
       

        private void Notice_Load(object sender, EventArgs e)
        {

        }

        private void lblLink_Click(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }

    }
}
