using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;

namespace OssKeyWordAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
