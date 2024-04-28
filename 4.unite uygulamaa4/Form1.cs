using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.unite_uygulamaa4
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[5]; //Global dizi
        int[] notlar = new int[5]; //Global dizi
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for(int i = 0; i <= notlar.Length; i++)
            {
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }  
            }
            txtEnYuksek.Text = enyuksek.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = txtAdSoyad.Text;
                notlar.  [index] = int.Parse(txtDersNotu.Text);
                // int.Parse fonksiyonu girilen değeri “int” veri türüne dönüştürür
                index++;
                txtAdSoyad.Text = "";
                txtDersNotu.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int endusuk = notlar[0];
            for (int i = 0; i <= notlar.Length; i++)
            {
                if (notlar[i] < endusuk)
                {
                    endusuk = notlar[i];
                }
            }
            txtEnDusuk.Text = endusuk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            double ortalama = 0;
            for (int i = 0; i < notlar.Length; i++)
            {
                toplam += notlar[i];
            }
            ortalama = toplam / notlar.Length;
            txtOrtalama.Text = ortalama.ToString();
        }
    }
}
