using AForge.Video.DirectShow;
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

namespace MachineLearningForKids
{
    public partial class shypanda : Form
    {
        public shypanda()
        {
            InitializeComponent();
        }

        private void shypanda_Load(object sender, EventArgs e)
        {
            
            OpenWebCam();
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
            image = (Bitmap)resizeImage(image, new Size(640, 360));
            pictureBoxWebCam.BackgroundImage = image;
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        private void buttonTakeSnapShot_Click(object sender, EventArgs e)
        {
            pictureBoxWebCam.BackgroundImage.Save("C:\\SmileDetect\\test.jpg", ImageFormat.Jpeg);
            string pred = SmilePredictionRequest().Trim();

            if (pred == "0")
            {
                pictureBoxSnapShot.BackgroundImage = Properties.Resources.QMarkSmiley;
                labelResult.Text = "No Face Detected";
            }

            if (pred == "1")
            {
                pictureBoxSnapShot.BackgroundImage = Properties.Resources.Smiley;
                labelResult.Text = "Happy";
            }
            if (pred == "2")
            {
                pictureBoxSnapShot.BackgroundImage = Properties.Resources.SadSmiley;
                labelResult.Text = "Sad";
            }
        }
        public string SmilePredictionRequest()
        {
            string fileName = "C:\\Python36\\python.exe";
            string arguments = "C:\\SmileDetect\\smileDetect.py";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = false,
                CreateNoWindow = false,
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = fileName,
                Arguments = arguments,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            process.Start();
            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return output;
        }

        private VideoCaptureDevice kamera;
        private FilterInfoCollection cihazlar;

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

    }
}
