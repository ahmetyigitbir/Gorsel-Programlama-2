using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselhafta3x4
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }
        int btn1x = 265, btn1y = 130;
        int btn2x = 315, btn2y = 130;
        int btn3x = 265, btn3y = 180;
        int btn4x = 315, btn4y = 180;
        Timer timer = new Timer();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();



        private void Form1_Load(object sender, EventArgs e)
        {

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            btn1.SetBounds(btn1x, btn1y, 50, 50);
            btn2.SetBounds(btn2x, btn2y, 50, 50);
            btn3.SetBounds(btn3x, btn3y, 50, 50);
            btn4.SetBounds(btn4x, btn4y, 50, 50);
            timer.Tick += Timer1_Tick;
            timer.Start();
        }
        bool control = false;

        private void Timer1_Tick(object sender, EventArgs e)
        {

            btn1.SetBounds(btn1x, btn1y, 50, 50);
            btn2.SetBounds(btn2x, btn2y, 50, 50);
            btn3.SetBounds(btn3x, btn3y, 50, 50);
            btn4.SetBounds(btn4x, btn4y, 50, 50);
            if (control == false)
            {
                btn1x -= 10;
                btn1y -= 10;
                btn2x += 10;
                btn2y -= 10;
                btn3x -= 10;
                btn3y += 10;
                btn4x += 10;
                btn4y += 10;
            }

            if (btn1y == -10)
            {
                control = true;
            }

            if (control == true)
            {
                btn1x += 10;
                btn1y += 10;
                btn2x -= 10;
                btn2y += 10;
                btn3x += 10;
                btn3y -= 10;
                btn4x -= 10;
                btn4y -= 10;
            }

            if (btn1y == 140)
            {
                control = false;
            }

        }

    }
}
