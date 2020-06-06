using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace MachineLearningForKids
{
    public partial class imageToTextGame : Form
    {
        public imageToTextGame()
        {
            InitializeComponent();
        }


        private void btnDonustur_Click(object sender, EventArgs e)
        {
            //Görsel secimi yaparken filtreleme islemi yapar
            ofdGorsel.Filter = "(*.jpeg)|*.jpeg |(*.png)|*.png|(*.jpg)|*.jpg| All files (*.*)|*.*";

            if (ofdGorsel.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(ofdGorsel.FileName);
                var ocr = new TesseractEngine("./tessdata", "tur");
                var sonuc = ocr.Process(img);
                richTextBoxMetin.Text = sonuc.GetText();
                pictureBoxMetin.Image = img;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            anaMenu menu = new anaMenu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
