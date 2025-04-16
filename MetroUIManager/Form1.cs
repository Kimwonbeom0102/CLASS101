using System;
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
            mtPaht2.UseCustomForeColor = true;

        }

        private void mcbColor_Click(object sender, EventArgs e)
        {

        }

        private void mcbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mcbColor.SelectedIndex);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)  //  폼을 닫을 때의 기능
        {
            Process[] procs = Process.GetProcessesByName("chromdriver");  //  Prcess 를 배열로 받아줌 / 크롤링 할 때 chromdriver 필요함
            foreach (Process proc in procs)  //  하나하나 가져온 Process를
            {
                proc.Kill();  //  다 죽임
            }
        }


        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                filename = "calc.exe";
            }

            using(Process myProcess = new Process())
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

        }
        
    }
}
