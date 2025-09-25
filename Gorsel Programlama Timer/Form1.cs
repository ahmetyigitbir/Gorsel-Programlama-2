using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel_Programlama_Timer
{
    public partial class Form1 : Form
    {
        int saat = 0, dakika = 0, saniye = 0, salise = 0;
        bool ilerisayim = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label9.Text = now.Hour.ToString("D2");
            label10.Text = now.Minute.ToString("D2");
            label11.Text = now.Second.ToString("D2");
            label12.Text = now.Millisecond.ToString("D3");

            if (ilerisayim)
            {
                saat = 0;
                dakika = 0;
                saniye = 0;
                salise = 0;
            }

            button1.Enabled = false;
            button1.BackColor = SystemColors.Control;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ilerisayim)
            { 
           

            salise++;
            if (salise == 10)
            {
                salise = 0;
                saniye++;
            }
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
                if (dakika == 60)
                {
                    dakika = 0;
                    saat++;
                }
                DateTime now = DateTime.Now;

                if (saat == now.Hour &&  dakika == now.Minute && saniye== now.Second)
                {
                    timer1.Stop();

                    ilerisayim = false;
                    button1.Enabled=true;
                    button1.BackColor = Color.Green;
                }
            }
            else
            { if (saat == 0 && dakika == 0 && saniye == 0) {
                    timer1.Stop();

                   
                }

                label13.Text = saat.ToString("D2");
            label14.Text = dakika.ToString("D2");
            label15.Text = saniye.ToString("D2");
            label16.Text = salise.ToString("D3");

            DateTime now = DateTime.Now;

            label9.Text = now.Hour.ToString("D2");
            label10.Text = now.Minute.ToString("D2");
            label11.Text = now.Second.ToString("D2");
            label12.Text = now.Millisecond.ToString("D3");

            if (saat == now.Hour &&  dakika == now.Minute && saniye == now.Second)
            {
                timer1.Stop();

                button1.Enabled = true;
                button1.BackColor = Color.Green;
               
            }

        }
    }
}
