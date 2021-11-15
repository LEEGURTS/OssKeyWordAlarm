using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        User use = new User();
        public makeKey()
        {
            InitializeComponent();
            use.make_keyword_txt();
        }
        private void makeKey_Load(object sender, EventArgs e)
        {
            pnlText.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlText.Width,pnlText.Height, 20, 20));
            keyWord_listBox.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, keyWord_listBox.Width, keyWord_listBox.Height, 20, 20));
            Keyword_TextBox.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Keyword_TextBox.Width, Keyword_TextBox.Height, 5, 5));
            btnDelete.Region= System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnDelete.Width, btnDelete.Height, 10, 10));
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
            // textBox에 입력한 text를 keywords 파일에 저장하는 함수입니다. --------------------------------
            if (Keyword_TextBox.Text != null)
            {
                // txt박스에 있는 모든 txt를 선택
                Keyword_TextBox.SelectAll();
                Keyword_TextBox.Focus();

                // 파일 경로
                string dir_url = Environment.CurrentDirectory;
                string file_name = "keywords.txt";
                string path_string = Path.Combine(dir_url, file_name);

                // 입력한 text를 저장
                System.IO.File.AppendAllText(path_string, Keyword_TextBox.SelectedText + "\n", Encoding.Default);
                // 이후 텍스트 박스 초기화
                Keyword_TextBox.Text = null;

            }

        }

        public void Btn_Load()
        {
            // keywords 파일 내용을 textBox2에 불러오기 ------------------------------------

            // 텍스트 박스 내용 비우기
            Keyword_TextBox.Text = null;
            keyWord_listBox.Items.Clear();
            // txt파일 내용 저장할 List
            List<string> result = new List<string>();
            // 경로
            StreamReader SR = new StreamReader("keywords.txt", Encoding.Default);
            // txt파일 1줄씩 저장 할 임시 변수
            string one_line;

            // result List에 파일 내용 1줄씩 저장
            while ((one_line = SR.ReadLine()) != null)
            {
                result.Add(one_line);
            }

            // textBox2에 result List 원소들 출력
            for (int i = 0; i < result.Count; i++)
            {
                keyWord_listBox.Items.Add(result[i]);
            }// textBox에서는 "\r\n"로 개행을 해야 됨 
            //바꿈
            SR.Close();
        }

        public void Btn_Check()
        {
            // 크롤링으로 받는 문자열 - 재승님이 할거
            String Info = "장학금과 인턴과 휴학생의 상관관계에 대한 학술적 고찰";

            // 키워드 존재 파악 변수
            int key;


            // 파일 읽기
            string dir_url = Environment.CurrentDirectory;
            string file_name = "keywords.txt";
            string path_string = Path.Combine(dir_url, file_name);
            StreamReader SR = new StreamReader(path_string, Encoding.Default);

            // 파일 내용 저장할 변수들
            List<string> result = new List<string>();
            string one_line;

            // List에 키워드(파일 내용)들이 하나씩 저장됨
            while ((one_line = SR.ReadLine()) != null)
            {
                result.Add(one_line);
            }
            SR.Close();


            for (int i = 0; i < result.Count; i++)
            {
                key = Info.IndexOf(result[i]);
                if (key == -1) { }
                else MessageBox.Show("새로운 " + result[i] + " 공지가 업로드 되었습니다.");
                // 나중에 알람으로 변경 ( 임시로 메세지박스 사용 )
            }

            /* int형 변수 = 크롤링결과물.indexOf(키워드)
             * 크롤링결과물에서 키워드에 해당하는 단어가 없으면 -1을 반환
             * 단어가 포함되면 양수 값을 반환
            */
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Btn_Check();
        }
        /*
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (keyWord_listBox.SelectedIndex != -1)
            {
                keyWord_listBox.Items.RemoveAt(keyWord_listBox.SelectedIndex);
            }
        }
        */
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (keyWord_listBox.SelectedIndex != -1)
            {
                keyWord_listBox.Items[keyWord_listBox.SelectedIndex] = Keyword_TextBox.Text;
                Keyword_TextBox.Text = "";
            }
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            keyWord_listBox.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (keyWord_listBox.Items.Count >= 1)
            {
                if (keyWord_listBox.SelectedItem != null)
                {
                    keyWord_listBox.Items.Remove(keyWord_listBox.SelectedItem);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No ITEMS Found");
            }

        }

        private void Keyword_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /* 앞으로 구현 할 것
         * 1. 세이브와 로드 기능을 합치기
         * 설정 폼으로 진입하게 되면 처음에 바로 파일에 저장된 키워드 출력
         * 이후에 키워드 저장 시 바로 키워드 업데이트 되게 하기
         *
         * 2. 키워드 삭제
         * 
         * 3. 크롤링 결과를 string이라고 가정하고 함수들을 구현 했기 때문에
         * 이후 크롤링 결과에 따라서 함수들도 바꾸어야 함.
         * 
         *
         *
         */
    }
}
