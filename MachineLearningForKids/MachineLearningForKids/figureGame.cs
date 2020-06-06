using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace MachineLearningForKids
{
    public partial class figureGame : Form
    {
        public figureGame()
        {
            InitializeComponent();
        }

        private void figureGame_Load(object sender, EventArgs e)
        {
            lblSekil.Text = "";
            lblSekilSayisi.Text = "";
        }
        Blob[] blobs;
        int sayac;
        int toplamSekilSayisi;
        Bitmap kaynakResim;
        Bitmap siyahBeyazResim;


        private void btnresim1_Click(object sender, EventArgs e)
        {
            pictureBoxAna.Image = Properties.Resources.sample2;
        }

        private void btnresim2_Click(object sender, EventArgs e)
        {
            pictureBoxAna.Image = Properties.Resources.img2;
        }

        private void btnresim3_Click(object sender, EventArgs e)
        {
            pictureBoxAna.Image = Properties.Resources.yt;
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            sayac = 1;
            Bitmap kaynakResim;
            kaynakResim = (Bitmap)pictureBoxAna.Image;
            // kaynakResim = (Bitmap)System.Drawing.Image.FromFile("sample2.jpg");
            OtsuThreshold otsuFiltre = new OtsuThreshold();
            //resim eğer renkliyse önce griye çeviriyor sonra filtre uygular,zaten renkliyse direkt filtreyi uygular.
            siyahBeyazResim = otsuFiltre.Apply(kaynakResim.PixelFormat != PixelFormat.Format8bppIndexed ? Grayscale.CommonAlgorithms.BT709.Apply(kaynakResim) : kaynakResim);

            BlobCounterBase bc = new BlobCounter();
            bc.FilterBlobs = true;
            bc.MinHeight = 5;
            bc.MinWidth = 5;

            bc.ProcessImage(siyahBeyazResim);
            blobs = bc.GetObjectsInformation();
            lblSekilSayisi.Text = "Toplam Şekil Sayısı = " + bc.ObjectsCount.ToString();
            toplamSekilSayisi = bc.ObjectsCount;

            for (int i = 0, n = blobs.Length; i < n; i++)
            {
                if (blobs.Length > 0)
                {

                    bc.ExtractBlobsImage(siyahBeyazResim, blobs[i], true);
                    pictureBoxAna.Image = siyahBeyazResim;
                    pictureBoxAna.Refresh();
                }
            }

        }

        private void btnKenarlariSil_Click(object sender, EventArgs e)
        {
            pictureBoxAna.Image = blobs[sayac - 1].Image.ToManagedImage();
            lblSekil.Text = "Şekil " + sayac.ToString() + " / " + toplamSekilSayisi.ToString();

            if (sayac == toplamSekilSayisi)
            {
                sayac = 0;
            }
            sayac++;
        }

        private void btnSekliGetir_Click(object sender, EventArgs e)
        {
            ExtractBiggestBlob filtre = new ExtractBiggestBlob();
            Bitmap temizResim = filtre.Apply((Bitmap)pictureBoxAna.Image);
            pictureBoxAna.Image = temizResim;
        }

        private void btnSekliRenklendir_Click(object sender, EventArgs e)
        {
            ConnectedComponentsLabeling filtre = new ConnectedComponentsLabeling();
            Bitmap boyaliResim = filtre.Apply((Bitmap)pictureBoxAna.Image);
            pictureBoxAna.Image = boyaliResim;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            anaMenu menu = new anaMenu();
            this.Hide();
            menu.ShowDialog();

        }
    }
}
