using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayı_Oyunu
{
    public partial class Form1 : Form
    {
        Random rastgele = new Random();
        List<int> oyunSayilari = new List<int>();
        List<int> tiklananNumaralar = new List<int>();
        int kalanSure = 60;
        bool oyunBasladi = false;

        public Form1()
        {
            InitializeComponent();
            OyunuHazirla();
        }

        private void OyunuHazirla()
        {
            oyunSayilari.Clear();
            tiklananNumaralar.Clear();
            gbOyunAlani.Controls.Clear();

            btnBitir.Visible = false;
            btnBasla.Visible = true;
            lblSure.Text = $"{kalanSure} sn";

            for (int i = 0; i < 10; i++)
            {
                oyunSayilari.Add(rastgele.Next(1, 101));
            }

            int x = 10, y = 10;
            foreach (var num in oyunSayilari)
            {
                Button btn = new Button();
                btn.Text = num.ToString();
                btn.Size = new System.Drawing.Size(50, 50);
                btn.Location = new System.Drawing.Point(x, y);
                btn.Click += Button_Click;
                gbOyunAlani.Controls.Add(btn);

                x += 60;
                if (x > 300)
                {
                    x = 10;
                    y += 60;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!oyunBasladi) return;

            Button tiklananButon = sender as Button;
            int numara = int.Parse(tiklananButon.Text);

            tiklananButon.Visible = false;
            tiklananNumaralar.Add(numara);

            lbTiklananSayilar.Items.Add(numara);

            if (tiklananNumaralar.Count == 10)
            {
                OyunDurumunuKontrolEt();
            }
        }

        private void OyunDurumunuKontrolEt()
        {
            List<int> dogruSiralama = oyunSayilari.Where(n => n % 2 == 0).OrderBy(n => n).ToList();
            List<int> kullaniciSiralama = tiklananNumaralar.ToList();

            if (dogruSiralama.SequenceEqual(kullaniciSiralama))
            {
                MessageBox.Show("Kazandınız!");
            }
            else
            {
                string dogruSiralamaStr = string.Join(", ", dogruSiralama);
                string kullaniciSiralamaStr = string.Join(", ", kullaniciSiralama);

                MessageBox.Show($"Kaybettiniz! Sayılar yanlış sırada veya tek sayı var.\n\n" +
                                 $"Doğru Sıralama: {dogruSiralamaStr}\n" +
                                 $"Sizin Sıralamanız: {kullaniciSiralamaStr}");
            }
        }

        private void OyunZamanlayici_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            lblSure.Text = $"{kalanSure} sn";

            if (kalanSure == 0)
            {
                oyunZamanlayici.Stop();
                MessageBox.Show("Zaman Bitti! Kaybettiniz.");
            }
        }

        private void ButonYerDegistirici_Tick(object sender, EventArgs e)
        {
            if (!oyunBasladi) return;

            foreach (Button buton in gbOyunAlani.Controls)
            {
                int x = rastgele.Next(gbOyunAlani.Width - buton.Width);
                int y = rastgele.Next(gbOyunAlani.Height - buton.Height);
                buton.Location = new System.Drawing.Point(x, y);
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            oyunBasladi = true;
            btnBasla.Visible = false;
            btnBitir.Visible = true;
            oyunZamanlayici.Start();
            kalanSure = 60;
            lblSure.Text = $"{kalanSure} sn";

            butonYerDegistirici.Start();
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            oyunZamanlayici.Stop();
            butonYerDegistirici.Stop();
            foreach (Button item in gbOyunAlani.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = false;
                }
            }
            OyunDurumunuKontrolEt();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBasla_Click_1(object sender, EventArgs e)
        {

        }
    }
}