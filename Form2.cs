using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rTxtInfo.Text = "Kod bloğumuz \"basla;\" ile baslayip \"bitir;\" ile bitirilmelidir.\n" +
                "\"yazdir<\" fonksiyonuyla '<' ile ';' arasına yazdığımız metni konsola " +
                "yazdırabiliriz.Her satır ';' ile bitmelidir.\n" +
                "\"topla: , cikar: , carp:\" fonksiyonlarıyla ':' ile ayırdığımız sayıları toplabilir" +
                " çıkarabilir ve çarpabiliriz \nÖrn: topla:5:2:3;\n" +
                "\"bol:\" fonksiyonuyla ':' ile ayırdığımız iki sayıdan ilkini ikinciye böldürebiliriz." +
                "Örn: bol:10:2;";
            rTxtOrnek.Text = "Örnek Kod\n" +
                "basla;\nyazdir<Merhaba;\nyazdir<50+3 sonucu:;\ntopla:50:3;\nyazdir<10-20 sonucu:;\ncikar:10:20;\n" +
                "yazdir<5x4x2 sonucu:;\ncarp:5:4:2;\nyazdir<8/4 sonucu:;\nbol:8:4;\nbitir;";
        }
    }
}
