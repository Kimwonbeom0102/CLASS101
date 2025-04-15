using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClick   
{
    public partial class Form1 : Form
    {
        int frequancy = 500;
        int during = 300;
        int Tick = 0;    //   프레임 당 Tick 증가 변수 
        [DllImport("user32.dll")]  //  Dll - user32 라이브러리 사용
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);  //  x, y값 좌표 등

        const uint L_BUTTON_DOWN = 0x00002;  // 좌클릭
        const uint L_BUTTON_UP = 0x00004;    // 
        const uint R_BUTTON_DOWN = 0x00008;  // 우클릭
        const uint R_BUTTON_UP = 0x00010;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)   // 틱 이벤트 발생 함수
        {
            label3.Text = Cursor.Position.X.ToString();  //  x값 포지션 업데이트
            label4.Text = Cursor.Position.Y.ToString();  //  y값 포지션 업데이트
            // MessageBox.Show("타이머기 시작되었습니다");
            Tick++;                                      // 매 프라임마다 Tick 증가

            if (Tick == 30)                              // Tick = 30 이 되었을때 실행
            {
                Cursor.Position = new Point(300, 410);   // 마우스 좌표 포지션 변경 

                mouse_event(R_BUTTON_DOWN, 0, 0, 0, 0);  // 이벤트 발생
                mouse_event(R_BUTTON_UP, 0, 0, 0, 0);
                //MessageBox.Show("매크로가 한번 눌렸습니다.");

                Console.Beep(frequancy, during); // 버튼이 눌리면 삐소리
            }

            if (Tick == 50)
            {
                Cursor.Position = new Point(550, 380);

                mouse_event(R_BUTTON_DOWN, 0, 0, 0, 0);
                mouse_event(R_BUTTON_UP, 0, 0, 0, 0);

                Console.Beep(frequancy, during); 
            }

            if (Tick == 60)
            {
                Cursor.Position = new Point(800, 170);

                mouse_event(R_BUTTON_DOWN, 0, 0, 0, 0);
                mouse_event(R_BUTTON_UP, 0, 0, 0, 0);
                Console.Beep(frequancy, during);

                Tick = 0;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)  // 시작버튼 이벤트
        {
            timer1.Enabled = true;                                // 버튼 클릭시 timer 활성화
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

       
    }
}
