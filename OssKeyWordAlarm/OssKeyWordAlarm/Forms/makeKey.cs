using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OssKeyWordAlarm
{
    public partial class makeKey : Form
    {
        public makeKey()
        {
            InitializeComponent();
        }
        private void makeKey_Load(object sender, EventArgs e)
        {

        }

        private void btnKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(Keyword_TextBox.Text!="")
                    keyWord_listBox.Items.Add(Keyword_TextBox.Text);
                Keyword_TextBox.Clear();
            }
        }

        private void btnRemove_keyWord_Click(object sender, EventArgs e)
        {
            keyWord_listBox.Items.RemoveAt(keyWord_listBox.SelectedIndex);
        }
    }
}
