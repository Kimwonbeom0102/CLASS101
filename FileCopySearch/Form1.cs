using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCopySearch  //  파일 검색 및 복사
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_SearchPath_Click(object sender, EventArgs e)  // 이벤트 핸들러 생성
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();  // 객체로 FolderBrowserDialog 생성(클릭실행)
            if (fbd .ShowDialog() == DialogResult.OK)              // 폴더에서 파일 선택하고
            {
                lbl_SearchPath.Text = fbd.SelectedPath;            // 선택된 파일경로를 경로.Text에 담아줌
                lbl_ExcuteResult.Text = "검색 경로가 설정 되었습니다.";  // 문구 출력
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Search_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // 파일실행기 생성
            if(ofd.ShowDialog() == DialogResult.OK)    // 파일선택
            {
                lbl_Search.Text = ofd.FileName;    // 경로에 넣어주고
                lbl_ExcuteResult.Text = "복사 할 파일이 선택 되었습니다."; // 출력

            }
        }

        private void lbl_DestPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();  // 탐색기 생성
            if (fbd.ShowDialog() == DialogResult.OK)    //  파일선택
            {
                lbl_DestPath.Text = fbd.SelectedPath;   // 선택한 경로를 목적지에 넣어주고
                lbl_ExcuteResult.Text = "파일을 복사할 위치가 선택 되었습니다.";  //  출력

            }
        }

        private void btn_Serach_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(btn_Serach.Text, $"*.txt", SearchOption.AllDirectories);  // GetFiles 메서드로 해당 경로 모든 txt 파일을 가져와
            foreach (string s in files)      //  foreach로 하나하나 꺼내줌
            {
                try
                {
                    FileInfo file1 = new FileInfo(s);  //  객체 생성 
                    if (file1.Length > 100 && file1.Name.Length < 10 && file1.DirectoryName.Replace(lbl_SearchPath.Text + "\\", "").Length < 30)  // 조건을 만족하면
                    {
                        string pathemp = file1.DirectoryName.Replace(lbl_SearchPath.Text + "\\", "");

                        string filename = "파일명 : " + String.Format("{0,15}", file1.Name);
                        string filepath = "/ 파일 경로 : " + String.Format("{0:30}", pathemp);
                        string filesize = "/ 파일 크기 : " + file1.Length + "byte";
                        listBox1.Items.Add(filename + filepath + filesize);  //  리스트박스에 아이템들을 담아서 추가
                    }
                }
                catch { }
            }
            lbl_ExcuteResult.Text = " 파일 검색이 완료되었습니다."; // 출력
        }


        private void btn_Copy_Click(object sender, EventArgs e)
        {
            string[] source = lbl_Search.Text.Split('\\');  //  해당 파일 경로를 \\기준으로 나눠 soure에 담아줌
            string name = source[source.Length - 1];  //  마지막 파일을 name 에 담아
            File.Copy(lbl_Search.Text, lbl_DestPath.Text + "\\" + name);  //  \\ 뒤에 copy
            lbl_ExcuteResult.Text = "파일 복사가 완료되었습니다.";  //  출력
        }   
    }
}
