using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OssKeyWordAlarm
{ // 현재 함수 3개
    class functions_h
    {
        public functions_h() { }
        public string file_path(string str)
        {
            string dir_url = Environment.CurrentDirectory;
            string file_name = str;
            return Path.Combine(dir_url, file_name);
        } // 파일이름을 입력하면 경로를 반환

        public List<string> read_file(string str)
        {
            StreamReader reader = new StreamReader(file_path(str), Encoding.UTF8);
            string one_line;
            List<string> result = new List<string>();

            while ((one_line = reader.ReadLine()) != null)
            {
                result.Add(one_line);
            }
            reader.Close();
            return result;
        } // 경로를 입력하면 그 파일의 정보를 읽어 리스트에 저장 후 리스트 반환

        public List<string> read_file2(string str)
        {
            StreamReader reader = new StreamReader(file_path(str), Encoding.Default);
            string one_line;
            List<string> result = new List<string>();

            while ((one_line = reader.ReadLine()) != null)
            {
                result.Add(one_line);
            }
            reader.Close();
            return result;
        }
        // keyword는 read_file로 읽으면 오류 발생!
        public void save_file(string str, List<string> list1, int mode)
        { // mode 0은 덮어쓰기, mode1은 이어쓰기
            StreamWriter writer;
            if (mode == 0)
            {
                writer = File.CreateText(file_path(str));
            }
            else {
                writer = File.AppendText(file_path(str));
            }
            foreach (string line in list1) { writer.WriteLine(line); }
            writer.Close();
        }
    }
}

