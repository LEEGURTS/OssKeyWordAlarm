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
        functions_h aaa = new functions_h();
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
            }
        }

        #endregion

        private void Notice_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start(_url);
            parents.title.Remove(_title);
            parents.url.Remove(_url.Substring(12));
            aaa.save_file("new_title.txt", parents.title, 0);
            aaa.save_file("new_url.txt", parents.url, 0);
            parents.flowLayoutPanel1.Controls.Remove(this);
        }
       

        private void Notice_Load(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_url);
            parents.title.Remove(_title);
            parents.url.Remove(_url.Substring(12));
            aaa.save_file("new_title.txt", parents.title, 0);
            aaa.save_file("new_url.txt", parents.url, 0);
            parents.flowLayoutPanel1.Controls.Remove(this);
        }
    }
}
