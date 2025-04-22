using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace MetroUIManager
{
    public partial class MainForm : MetroForm
    {
        int count = 0;
        int timerFlag = 0;  // 타이머 깜빡임 0,1
        int newsFlag = 0;  // 뉴스크롤러 클릭확인 0,1  기준점을 잡아줌
        string arg = "";
        string filename = "";
        Timer timer = new Timer();

        public MainForm()  //  메인폼이 생성될때 생성자
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;  //  메트로스타일매니저 등록 (설정된 부분이 MainForm에 등록)
        }

        private void MainForm_Load(object sender, EventArgs e)  // 프로그램이 실행됨
        {
            // 초기 설정
            metroPanel1.Hide();  // 패널을 감춰줌

            mcbTheme.SelectedIndex = 0;  //  각각 인덱스별 조절
            mcbColor.SelectedIndex = 7;  
            //mcbFont.SelectedIndex = 0;

            // 이 옵션들이 없으면 컬러를 변경할 수 없음  
            // 타일들의 색상을 변경할 수 있도록 true로 변경
            mtTimer.UseCustomForeColor = true;
            mtNews.UseCustomForeColor = true;
            mtNetPath1.UseCustomForeColor = true;
            mtNetPath2.UseCustomForeColor = true;
            mtPath1.UseCustomForeColor = true;
            mtPath2.UseCustomForeColor = true;
            mtPath3.UseCustomForeColor = true;
            mtPath4.UseCustomForeColor = true;
            mtTaskMgr.UseCustomForeColor = true;

        }


        private void mcbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mcbColor.SelectedIndex);
            // 선택된 인덱스의값 0, 1, 2 등을 형변환해서 열거형에 넣어준다.
            // ToInt32 로 형변환
            // MetroColorStyle 에서 열거형으로 인덱스값 만들어줌
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)  //  폼을 닫을 때의 기능
        {
            Process[] procs = Process.GetProcessesByName("chromdriver");  //  Prcess 를 배열로 받아줌 / 크롤링 할 때 chromdriver 필요함
            foreach (Process proc in procs)  //  하나하나 가져온 Process를
            {
                proc.Kill();  //  다 죽임
            }
        }
        
        // 뉴스 타일 클릭
        private void mtNews_Click(object sender, EventArgs e)
        {
            if(newsFlag == 0)  // 만들어놨던 변수를 활용하여 조건을 걸어주고 0일때와 1일때의 상태를 변경해줌
            {
                ucBoard board = new ucBoard();
                board.Dock = DockStyle.Fill;
                metroPanel1.Show();
                metroPanel1.Controls.Add(board);
                newsFlag = 1;
            }
            else // 한번 더 클릭
            {
                metroPanel1.Hide();
                newsFlag = 0;
            }
        }

        private void mtExe_Click(object sender, EventArgs e)
        {
            if(((MetroTile)sender).Name == "mtPath1")
            {
                filename = "notepad.exe";
            }
            else if (((MetroTile)sender).Name == "mtPath2")
            {
                filename = "Calculator.exe";
            }

            using(Process myProcess = new Process())  // using 키워드를 사용하는 이유? 프로세스를 실행한 후 프로그램을 자동적으로 종료
            {
                myProcess.StartInfo.UseShellExecute = false;
                myProcess.StartInfo.FileName = filename;
                myProcess.Start();
            }

        }

        // 타이머 타일 클릭
        private void mtTimer_Click(object sender, EventArgs e)  // 타이머 클릭
        {   // 0, 1 기준점을 잡아 조건을 줌  0이면 클릭한 상태
            if (timerFlag == 0)  // 타이머 시작
            {
                mtTimer.UseTileImage = false;  //  타일의 아이콘을 적용하지않음 (아이콘 보이지않음)
                timerFlag = 1;  //  1로 바뀌고
                timer.Interval = 1000;  // 간격은 1초
                timer.Tick += new EventHandler(timer_Tick);  // 초마다 틱이벤트 발생
                timer.Start();
            }
            else
            {
                mtTimer.UseTileImage= true;
                timerFlag = 0;
                count = 0;
                timer.Tick -= timer_Tick;
                timer.Stop();
                mtTimer.TextAlign = ContentAlignment.BottomLeft;
                mtTimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
                mtTimer.Text = "Rest Timer";
                mtTimer.UseTileImage = false;
            }
        }
        void timer_Tick(object sender, EventArgs e)
        {
            count++;
            if(count == 1)
            {
                mtTimer.UseTileImage = false;  // 이 설정이 없으면, 커스텀으로 컬러를 변경할 수 없다.
                mtTimer.BackColor = Color.Pink;
                mtTimer.TextAlign = ContentAlignment.TopCenter;
                mtTimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            }
            if(count > 59)
            {
                int minute = count / 60;
                int second = count - (minute * 60);
                mtTimer.Text = DateTime.Now.ToLongTimeString() + "\r\n" + $"{minute}분 {second}초 경과";
            }
            else
            {
                mtTimer.Text = DateTime.Now.ToShortTimeString() + "\r\n" + Container + "초 경과";
            }
            if(count > 20)  // 타일 색 깜빡임
            {
                if(count % 2 == 0)    // 짝수일 때
                {
                    mtTimer.BackColor = Color.DeepPink;
                }
                else  // 홀수일 때
                {
                    mtTimer.BackColor = Color.Pink;
                }
            }
            if(count > 30)
            {
                Console.Beep();
                   
                mtTimer.UseTileImage= true;
                timerFlag = 0;
                count = 0;
                timer.Tick -= timer_Tick;
                timer.Stop();
                mtTimer.TextAlign = ContentAlignment.BottomCenter;
                mtTimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
                mtTimer.Text = "Rest Timer";
                mtTimer.UseCustomBackColor = false;
            }
        }

        // 기타 기능 타일 클릭
        private void mtNetPath_Click(object sender, EventArgs e) // 클릭을 하면 클릭 한 정보들을 sender가 가지고있음
        {
            if(((MetroTile)sender).Name == "mtNetPaht1")
            {
                arg = "http://www.google.co.kr";
            }
            else
            {
                arg = "http//www.naver.com";
            }

            using (Process myprocess = new Process())
            {
                myprocess.StartInfo.UseShellExecute = false;
                myprocess.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application";
                myprocess.StartInfo.Arguments = arg;
                myprocess.Start();
            }
        }

        private void mtPath_Click(object sender, EventArgs e)
        {
            if(((MetroTile)sender).Name == "mtPhth3")
            {
                filename = @"C:\Users\82106\Downloads";
            }
            else
            {
                filename = @"C:\Users\82106\Desktop";
            }

            using(Process myprocess = new Process())
            {
                myprocess.StartInfo.FileName = filename; ;
                myprocess.Start();
            }
        }

        private void mcbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(mcbTheme.SelectedIndex)
            {
                case 0:
                    StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void mtTaskMgr_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^+{ESC}");
        }

        private void mcbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList tiles = new ArrayList();
            tiles.Add(mtPath1);
            tiles.Add(mtPath2);
            tiles.Add(mtPath3);
            tiles.Add(mtPath4);
            tiles.Add(mtNetPath1);
            tiles.Add(mtNetPath2);
            tiles.Add(mtNews);
            tiles.Add(mtTimer);
            tiles.Add(mtTaskMgr);

            switch (mcbFont.SelectedIndex)
            {
                case 0:
                    foreach(MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Black;
                    }
                    break;
                case 1:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.White;
                    }
                    break;
                case 2:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Blue;
                    }
                    break;
                case 3:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Purple;
                    }
                    break;
                case 4:
                    foreach (MetroTile tile in tiles)
                    {
                        tile.ForeColor = Color.Red;
                    }
                    break;
            }

        }

      
    }
}
