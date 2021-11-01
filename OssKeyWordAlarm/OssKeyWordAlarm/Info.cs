using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// 다음은 프로그램 사용자가 이미 추가해둔 키워드를 저장하는데 쓰이는 헤더파일입니다.
// 빌드된 위치에 "keyword.txt"가 생성되고, 여기에 사용자가 추가해둔 키워드들이 저장됩니다.
// 이 파일에 저장되어있는 키워드들이 들어가있는 글이 올라오면, 알람이 가는 방식입니다.

namespace OssKeyWordAlarm
{
    class User
    {
        public User()
        {
            make_keyword_txt();
            make_urls();
        }

        // keyword.txt를 만드는 함수입니다.
        // 생성되어있지 않다면 만들고,
        // 생성되어있다면 파일에 들어있는 키워드들을 모두 뽑아내서 list에 저장합니다.
        public void make_keyword_txt()
        {
            string dir_url = Environment.CurrentDirectory;
            string file_name = "keywords.txt";
            string path_string = Path.Combine(dir_url, file_name);
            if (!File.Exists(path_string))
            {
                FileStream fs = File.Create(path_string);
                fs.Close();
            } else
            {
                List<string> result = new List<string>();
                StreamReader file = new StreamReader(path_string);
                string one_line;
                while((one_line = file.ReadLine()) != null){
                    result.Add(one_line);
                }
                keywords = result;
                file.Close();

            }
        }

        // urls.txt를 만드는 함수입니다.
        // 생성되어있지 않다면 만들고,
        // 생성되어있다면 파일에 들어있는 키워드들을 모두 뽑아내서 dictionary에 저장합니다.
        public void make_urls()
        {
            string dir_url = Environment.CurrentDirectory;
            string file_name = "urls.txt";
            string path_string = Path.Combine(dir_url, file_name);
            if (!File.Exists(path_string))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(file_name, FileMode.CreateNew);
                    using (StreamWriter file = new StreamWriter(fs))
                    {
                        file.WriteLine("https://www.kw.ac.kr/ko/life/notice.jsp");
                        file.WriteLine("1");
                    }
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Dispose();
                    }
                }
                fs.Close();
            }
            else
            {
                Dictionary<string, bool> result = new Dictionary<string, bool>();
                StreamReader file = new StreamReader(path_string);
                string one_line;
                while ((one_line = file.ReadLine()) != null)
                {
                    string one_url = one_line;
                    one_line = file.ReadLine();
                    bool is_tracing;
                    if (one_line.Equals("0"))
                    {
                        is_tracing = false;
                    }
                    else
                    {
                        is_tracing = true;
                    }
                    result.Add(one_url,is_tracing);
                }
                urls = result;
                file.Close();
            }
        }

        // keywords.txt에 저장되어있는 것들을 담고 있는 변수입니다.
        // 여기에 모든 키워드들이 저장됩니다.
        private List<string> keywords;

        // 다음은 글이 올라오는지 관측할 사이트의 url을 담고 있는 변수입니다.
        // <url주소, 관측유무>
        // 이후에 많은 사이트에서 글이 올라오는 것을 관측할 수 있을 때,
        // 사용자가 보고싶은 사이트만을 관측할 수 있도록 하기위해서
        // dictionary를 사용하였습니다.
        private Dictionary<string,bool> urls;

        public List<string> Keywords
        {
            get { return keywords; }
            set { keywords = value; }
        }

        public Dictionary<string, bool> Urls
        {
            get { return urls; }
            set { urls = value; }
        }
    }

    //불러온 글에 대한 클래스입니다.
    // 이 클래스는 해당 글에 대한 주소(url), DUID, 글 내용(content)가 들어있습니다.
    class Article
    {
        public Article(string new_url, int new_duid, string new_content)
        {
            url = new_url;
            duid = new_duid;
            content = new_content;
        }

        private string url;
        private int duid;
        private string content;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public int Duid
        {
            get { return duid; }
            set { duid = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
