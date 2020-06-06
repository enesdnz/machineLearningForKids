using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class chameleon : Form
    {
        int red, green, blue;
        private VideoCaptureDevice kamera;
        private FilterInfoCollection cihazlar;
        bool detectionIsRunning;
        public chameleon()
        {
            InitializeComponent();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            if (kamera.IsRunning)
            {
                kamera.Stop();

            }
            anaMenu menu = new anaMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void panel_Baslik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chameleon_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            OpenWebCam();
            red = 0;
            green = 0;
            blue = 0;

        }
        private void OpenWebCam()
        {
            kamera = new VideoCaptureDevice();
            cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (kamera.IsRunning)
            {
                kamera.Stop();
                pictureBoxWebCam.Image = null;
                pictureBoxWebCam.Invalidate();
            }
            else
            {
                kamera = new VideoCaptureDevice(cihazlar[0].MonikerString);
                kamera.NewFrame += kamera_NewFrame;
                kamera.Start();
            }

        }
        private void kamera_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxWebCam.BackgroundImage = image;



        }
        private void DetectColor()
        {

            if (pictureBoxWebCam.BackgroundImage == null)
                return;

            Bitmap image = new Bitmap(pictureBoxWebCam.BackgroundImage);
            detectionIsRunning = true;

            for (int i = 0; i < image.Width; i++) // x ve y eksenindeki bütün piksellere erişim
            {
                for (int j = 0; j < image.Height; j++)
                {
                    if (image.GetPixel(i, j).R <= 95 && image.GetPixel(i, j).G <= 95 && image.GetPixel(i, j).B >= 100) // Mavi koşulu
                    {
                        blue++;
                    }
                    if (image.GetPixel(i, j).R <= 95 && image.GetPixel(i, j).G >= 100 && image.GetPixel(i, j).B <= 95) // Yeşil koşulu
                    {
                        green++;
                    }
                    if (image.GetPixel(i, j).R >= 105 && image.GetPixel(i, j).G <= 95 && image.GetPixel(i, j).B <= 95) // Kırmızı koşulu
                    {
                        red++;
                    }
                }
            }

            if (blue > green && blue > red)
            {
                color_lbl.Text = "Blue";
                pictureBoxChameleon.BackgroundImage = Properties.Resources.blue;
                red = 0;
                green = 0;
                blue = 0;
            }
            if (red > green && red > blue)
            {
                color_lbl.Text = "Red";
                pictureBoxChameleon.BackgroundImage = Properties.Resources.red;
                red = 0;
                green = 0;
                blue = 0;
            }
            if (green > blue && green > red)
            {
                color_lbl.Text = "Green";
                pictureBoxChameleon.BackgroundImage = Properties.Resources.green;
                red = 0;
                green = 0;
                blue = 0;
            }

            detectionIsRunning = false;
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            Thread t = new Thread(DetectColor);
            if (!detectionIsRunning)
                t.Start(); 
        }

    }
}
