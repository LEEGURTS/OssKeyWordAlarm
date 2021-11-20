using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;

namespace OssKeyWordAlarm
{
    public partial class makeKey : Form
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

        functions_h fh = new functions_h();
        User use = new User();

        public makeKey()
        {
            InitializeComponent();
        }
        private void makeKey_Load(object sender, EventArgs e)
        {
            pnlText.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlText.Width, pnlText.Height, 20, 20));
            keyWord_listBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, keyWord_listBox.Width, keyWord_listBox.Height, 20, 20));
            Keyword_TextBox.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Keyword_TextBox.Width, Keyword_TextBox.Height, 5, 5));
            btnDelete.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 10, 10));
            btnClear.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 10, 10));
            btnEdit.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEdit.Width, btnEdit.Height, 10, 10));
            keyWord_listBox.BringToFront();
            Btn_Load();
        }

        private void btnKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Save();
                Btn_Load();
            }
        }

        public void Btn_Save()
        {
            if (Keyword_TextBox.Text != null)
            {
                // txt박스에 있는 모든 txt를 선택
                Keyword_TextBox.SelectAll();
                Keyword_TextBox.Focus();

                // 파일 경로 ( functions_h.cs )
                string path_string = fh.file_path("keywords.txt");

                // 입력한 text를 저장
                System.IO.File.AppendAllText(path_string, Keyword_TextBox.SelectedText + "\n", Encoding.UTF8);
                
                // 이후 텍스트 박스 초기화
                Keyword_TextBox.Text = null;

            }

        }// textBox에 입력한 text를 keywords 파일에 저장하는 함수.

        public void Btn_Load()
        {
            // 텍스트 박스 내용 비우기
            Keyword_TextBox.Text = null;
            keyWord_listBox.Items.Clear();
            // txt파일 내용 저장할 List
            List<string> result = new List<string>();
            // 경로
            StreamReader SR = new StreamReader("keywords.txt", Encoding.UTF8);
            // txt파일 1줄씩 저장 할 임시 변수
            string one_line;

            // result List에 파일 내용 1줄씩 저장
            while ((one_line = SR.ReadLine()) != null)
            {
                result.Add(one_line);
            }

            // listBox에 result List 원소들 출력
            for (int i = 0; i < result.Count; i++)
            {
                keyWord_listBox.Items.Add(result[i]);
            }

            SR.Close();
        } // keywords 파일 내용을 listbox에 불러오기

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Keyword_TextBox.Text == "")
            {
                return;
            }
            if (keyWord_listBox.SelectedIndex != -1)
            {
                keyWord_listBox.Items[keyWord_listBox.SelectedIndex] = Keyword_TextBox.Text;
                // 리스트 박스에 선택된 리스트를 textbox에 입력한 글자로 바꿈
                Keyword_TextBox.Text = "";
                // 텍스트 박스를 비움
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter("keywords.txt");
                foreach (var item in keyWord_listBox.Items)
                { 
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();
                //실행하면 키워드가 모두 지워져버림.
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            keyWord_listBox.Items.Clear();
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "keywords.txt"), String.Empty);
            // 리스트박스 내용을 다 비움
        } 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (keyWord_listBox.Items.Count >= 1 && keyWord_listBox.SelectedItem != null)
            {
                string removeText = keyWord_listBox.SelectedItem.ToString();
                keyWord_listBox.Items.Remove(keyWord_listBox.SelectedItem);
                File.WriteAllLines("keywords.txt",
                    File.ReadAllLines("keywords.txt").Where(l => l != removeText).ToList(), Encoding.UTF8);
            }

            else
            {
                System.Windows.Forms.MessageBox.Show("삭제할 KeyWord가 없습니다.");
            }
        }
    }
}
