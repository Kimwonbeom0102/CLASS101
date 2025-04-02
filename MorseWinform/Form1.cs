using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //  버튼 이벤트
        {
            int frequency = 500;   
            int dot = 200;
            int dash = 600;
            string morse = " ";

            foreach (char c in textBox1.Text )  //  TextBox의 Text를 c 에 담아줌
            {
                char ch = c;                    // 담아준 c를 문자 ch에 담아줌
                 
                if (c.Equals(' '))              // c가 null이면
                {
                    Thread.Sleep(800);          // 0.8초 중단
                }
                 
                if (c >= 'a' && c <= 'z') { ch = char.Parse(c.ToString().ToUpper()); }  // c 가 소문자 a ~ z일경우 대문자로 바꾸고 ch문자에 담아줌

                switch (ch)  //  담아진 ch 의 문자를 매개변수로 받아 swtich문으로 실행.  case 일 때 : 실행
                {
                    case ' ': morse = " "; break;
                    case 'A': morse = ". - "; break;
                    case 'B': morse = "- . . . "; break;
                    case 'C': morse = "- . - . "; break;
                    case 'D': morse = "- . . "; break;
                    case 'E': morse = ". "; break;
                    case 'F': morse = ". . - . "; break;
                    case 'G': morse = "- - ."; break;
                    case 'H': morse = ". . . ."; break;
                    case 'I': morse = ". ."; break;
                    case 'J': morse = ". - - - "; break;
                    case 'K': morse = "- . - "; break;
                    case 'L': morse = ". - . . "; break;
                    case 'M': morse = "- -"; break;
                    case 'N': morse = "- . "; break;
                    case 'O': morse = "- - - "; break;
                    case 'P': morse = ". - - . "; break;
                    case 'Q': morse = "- - . -"; break;
                    case 'R': morse = ". -  ."; break;
                    case 'S': morse = ". . ."; break;
                    case 'T': morse = " - "; break;
                    case 'U': morse = ". . - "; break;
                    case 'V': morse = ". . . -"; break;
                    case 'W': morse = ". - - "; break;
                    case 'X': morse = "- . . -"; break;
                    case 'Y': morse = "- . - - "; break;
                    case 'Z': morse = "- - . ."; break;
                    case '1': morse = ". - - - -"; break;
                    case '2': morse = ".. - - -"; break;
                    case '3': morse = ". . . - -"; break;
                    case '4': morse = ". . . .-"; break;
                    case '5': morse = ". . . . ."; break;
                    case '6': morse = "- . . . ."; break;
                    case '7': morse = "- - . . ."; break;
                    case '8': morse = "- - - . ."; break;
                    case '9': morse = "- - - - ."; break;
                    case '0': morse = "- - - - -"; break;
                }

                foreach (char ch1 in morse)    //  " " 에 담긴 문자를 ch1에 담아주고
                {
                    if (ch1.Equals('.'))       // 담긴 문자가 . 일 경우 실행
                    {
                        Console.Beep(frequency, dot);  //  Beep 메서드로 주파수( 지속시간, 경고음 )
                    }
                    if (ch1 == '-')            // 담긴 문자가 - 일 경우 실행
                    {
                        Console.Beep(frequency, dash);
                    }

                    if (ch1 == ' ')            // 담긴 문자가 null 일 경우 실행
                    {
                        Thread.Sleep(200);
                    }

                    Thread.Sleep(600);         // 실행 후 0.6초 중단 
                }
            }
        }
    }
}
