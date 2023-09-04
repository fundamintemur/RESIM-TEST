using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESIM_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        string resim;
        private void BtnResimSeç_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }
        Color renk;
        private void BtnRenkSeç_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp;
        private void BtnYazdır_Click(object sender, EventArgs e)
        {

            bmp = new Bitmap(resim);//bitmap ne işe yarar? bilgisayardan alacağımız resim üzerine işlem yaparak ekranda görmek istiyoruz.kullanılan sınıf
            Graphics gr = Graphics.FromImage(bmp);//bu resim üzerinde işle demek

            gr.DrawString(TxtMetin.Text, new Font("Segue UI", Convert.ToInt16(TxtBoyut.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
            //drawstringle(üstüne çiz)resim üzerinde işlemler yaptık,boyut belirleme,resim font,yazı tipi
            pictureBox1.Image = bmp;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Resim|.jpg";
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
