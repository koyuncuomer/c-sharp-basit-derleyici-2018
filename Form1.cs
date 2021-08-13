using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniDerleyiciV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool bolknt = true;//Bölüm fonksiyonun da bölünen 0 mı kontrolü.
        bool kontrol = true;//Tanımsız bir fonksiyon kullanıldığını kontrol ettireceğimiz değişken.
        string alinan;//Giriş text box'ından girilen kodu saklayacağımız değişken.
        string[] bolunmus;//Girilen kodu ";" göre bölüp saklayacağımız dizi.
        ArrayList konsolSon = new ArrayList(); //Konsola yazılacakları saklayacağımız arraylist.

        void yazdirfonk(string alinan) //Konsola yazdırılacak kısmı bulup yazdıran fonksiyon.
        {
            string[] bolunmus;
            bolunmus = alinan.Split('<');
            konsolSon.Add(bolunmus[1] + "\n");
        }
        void toplafonk(string alinan)//Toplanacak sayıları bulup toplayan fonksiyon.
        {
            string[] bolunmus;
            float sonuc = 0;
            bolunmus = alinan.Split(':');
            for (int i = 1; i < bolunmus.Length; i++)
            {
                sonuc = sonuc + float.Parse(bolunmus[i]);
            }
            konsolSon.Add(sonuc.ToString() + "\n");
        }
        void cikarfonk(string alinan)//Çıkarılacak sayıları bulup çıkaran fonksiyon.
        {
            string[] bolunmus;
            bolunmus = alinan.Split(':');
            float sonuc = float.Parse(bolunmus[1]);
            for (int i = 2; i < bolunmus.Length; i++)
            {
                sonuc = sonuc - float.Parse(bolunmus[i]);
            }
            konsolSon.Add(sonuc.ToString() + "\n");
        }
        void carpfonk(string alinan)//Çarpılacak sayıları bulup çarpan fonksiyon.
        {
            string[] bolunmus;
            bolunmus = alinan.Split(':');
            float sonuc = 1;
            for (int i = 1; i < bolunmus.Length; i++)
            {
                sonuc = sonuc * float.Parse(bolunmus[i]);
            }
            konsolSon.Add(sonuc.ToString() + "\n");
        }
        void bolfonk(string alinan)//Bölünecek sayıları bulup bölen fonksiyon.
        {
            string[] bolunmus;
            bolunmus = alinan.Split(':');
            float sonuc = float.Parse(bolunmus[1]);
            float bolen = float.Parse(bolunmus[2]);
            if (bolen == 0)
            {
                bolknt = false;
            }
            else
            {
                sonuc = sonuc / bolen;
            }
            konsolSon.Add(sonuc.ToString() + "\n");
        }
        private void btnDerle_Click(object sender, EventArgs e)
        {
            alinan = "";
            konsolSon.Clear();
            kontrol = true; bolknt = true;
            rTxtKonsol.Clear();
            alinan = rTxtGiris.Text; //yazılan kodu aktarıyoruz
            alinan = alinan.Replace("\n", ""); //koddaki alt satıra geçişleri siliyoruz
            alinan = alinan.Trim(); //string başındaki ve sonundaki boşlukları siliyoruz
            bolunmus = alinan.Split(';'); //alınan kodu ";" göre bölüyoruz
            try
            {
                if (bolunmus[0] == "basla" && bolunmus[(bolunmus.Length - 2)] == "bitir")//sona boşluk eklediği için -2
                {
                    for (int i = 1; i < bolunmus.Length - 2; i++)
                    {
                        if (bolunmus[i].Substring(0, 7) == "yazdir<")
                        {
                            yazdirfonk(bolunmus[i]);
                        }
                        else if (bolunmus[i].Substring(0, 6) == "topla:")
                        {
                            toplafonk(bolunmus[i]);
                        }
                        else if (bolunmus[i].Substring(0, 6) == "cikar:")
                        {
                            cikarfonk(bolunmus[i]);
                        }
                        else if (bolunmus[i].Substring(0, 5) == "carp:")
                        {
                            carpfonk(bolunmus[i]);
                        }
                        else if (bolunmus[i].Substring(0, 4) == "bol:")
                        {
                            bolfonk(bolunmus[i]);
                        }
                        else
                        {
                            kontrol = false;
                        }
                    }
                }
                else { rTxtKonsol.Text = "Derleme Başarısız! Kod bloğu açılmamış veya kapatılmamış.00"; }
            }
            catch (Exception)
            {
                rTxtKonsol.Text = "Derleme Başarısız! Tanımsız fonksiyon.01";
                konsolSon.Clear();
            }
            if (kontrol == false)
            {
                rTxtKonsol.Text = "Derleme Başarısız! Tanımsız fonksiyon.02";
            }
            else if (bolknt == false)
            {
                rTxtKonsol.Text = "Derleme Başarısız! Bölen 0 olamaz.03";
            }
            else
            {
                foreach (string eleman in konsolSon)
                {
                    rTxtKonsol.Text = rTxtKonsol.Text + eleman;
                }
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
                Form2 f2 = new Form2();
                f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}