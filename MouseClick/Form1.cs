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
        int Tick = 0;
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        const uint L_BUTTON_DOWN = 0x00002;
        const uint L_BUTTON_UP = 0x00004;
        const uint R_BUTTON_DOWN = 0x00008;
        const uint R_BUTTON_UP = 0x00010;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = Cursor.Position.X.ToString();
            label4.Text = Cursor.Position.Y.ToString();
            // MessageBox.Show("타이머기 시작되었습니다");
            Tick++;

            if (Tick == 30)
            {
                Cursor.Position = new Point(500, 391);

                mouse_event(R_BUTTON_DOWN, 0, 0, 0, 0);
                mouse_event(R_BUTTON_UP, 0, 0, 0, 0);
                MessageBox.Show("매크로가 한번 눌렸습니다.");
                
               
            }

            if (Tick == 60)
            {
                Cursor.Position = new Point(800, 391);

                mouse_event(R_BUTTON_DOWN, 0, 0, 0, 0);
                mouse_event(R_BUTTON_UP, 0, 0, 0, 0);
                Tick = 0;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

       
    }
}
