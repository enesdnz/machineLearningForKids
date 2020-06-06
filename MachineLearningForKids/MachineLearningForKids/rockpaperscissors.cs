using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class rockpaperscissors : Form
    {
        public rockpaperscissors()
        {
            InitializeComponent();
        }

        private void timerRPS_Tick(object sender, EventArgs e)
        {
            labelCountDown.Text = countDown.ToString();
            countDown--;
            labelCountDown.Visible = true;
            pictureBoxSnapShot.BackgroundImage = null;
            pictureBoxAI.BackgroundImage = null;
            pictureBoxWinner.Visible = false;
            labelPredictionResult.Visible = false;
            labelAISelection.Visible = false;

            if (countDown == -1)
            {
                timerRPS.Enabled = false;
                Bitmap image = (Bitmap)pictureBoxWebcam.BackgroundImage;
                Bitmap croppedImage = new Bitmap(200, 300);

                for (int i = 0; i < 200; i++)
                {
                    for (int j = 0; j < 300; j++)
                    {

                        croppedImage.SetPixel(i, j, image.GetPixel(i + 200, j + 30));
                    }
                }
                pictureBoxSnapShot.BackgroundImage = croppedImage;


                labelCountDown.Visible = false;
                pictureBoxSnapShot.BackgroundImage.Save(setupConfig.RPSImageToPredict, ImageFormat.Jpeg);
                labelPredictionResult.Visible = true;
                labelAISelection.Visible = true;


                Random rand = new Random();
                int AI_selection = rand.Next(0, 2);

                string aiSelection = "";
                if (AI_selection == 0)
                {
                    pictureBoxAI.BackgroundImage = Properties.Resources.Paper;
                    aiSelection = "Paper";
                }
                if (AI_selection == 1)
                {
                    pictureBoxAI.BackgroundImage = Properties.Resources.Rock;
                    aiSelection = "Rock";
                }
                if (AI_selection == 2)
                {
                    pictureBoxAI.BackgroundImage = Properties.Resources.Scissors;
                    aiSelection = "Scissors";
                }






                PostRequest postRequest = new PostRequest();
                string result = postRequest.RPS_Request();
                result = result.Replace("[", "").Replace("]", "").Replace(".", "").Replace(" ", "").Trim();

                string prediction = "";
                int userIsWinner = 0;
                if (result == "100")
                {
                    prediction = "Paper";

                    if (AI_selection == 0)
                        userIsWinner = 0;
                    if (AI_selection == 1)
                        userIsWinner = 1;
                    if (AI_selection == 2)
                        userIsWinner = 2;
                }
                if (result == "010")
                {
                    prediction = "Rock";
                    if (AI_selection == 0)
                        userIsWinner = 2;
                    if (AI_selection == 1)
                        userIsWinner = 0;
                    if (AI_selection == 2)
                        userIsWinner = 1;
                }
                if (result == "001")
                {
                    prediction = "Scissors";
                    if (AI_selection == 0)
                        userIsWinner = 1;
                    if (AI_selection == 1)
                        userIsWinner = 2;
                    if (AI_selection == 2)
                        userIsWinner = 0;
                }



                if (userIsWinner == 1)
                {
                    pictureBoxWinner.Left = 58;
                    pictureBoxWinner.Visible = true;
                }
                if (userIsWinner == 2)
                {
                    pictureBoxWinner.Left = 349;
                    pictureBoxWinner.Visible = true;
                }
                else
                {

                }
                //MessageBox.Show(userIsWinner.ToString());


                labelPredictionResult.Text = "AI Prediction : " + prediction;
                labelAISelection.Text = "AI Selection : " + aiSelection;
            }
        }
        private VideoCaptureDevice kamera;
        private FilterInfoCollection cihazlar;
        int countDown;
        SetupConfig setupConfig = new SetupConfig();
        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (kamera.IsRunning)
            {
                kamera.Stop();

            }
            anaMenu menu = new anaMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void rockpaperscissors_Load(object sender, EventArgs e)
        {
            comboBoxClassLabel.SelectedIndex = 0;
            OpenWebCam();
            LoadImages();
        }
        private void LoadImages()
        {
            DirectoryInfo d = new DirectoryInfo(@"Data/RockPaperScissors/Rock/");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files

            foreach (FileInfo file in Files)
            {

                Image image;
                using (Stream stream = File.OpenRead(@"Data/RockPaperScissors/Rock/" + file.Name))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }


                PictureBox pc = new PictureBox();
                pc.Height = 125;
                pc.Width = 125;
                pc.BorderStyle = BorderStyle.Fixed3D;
                pc.BackgroundImage = image;
                pc.BackgroundImageLayout = ImageLayout.Stretch;
                pc.Dock = DockStyle.Top;


                pc.Name = file.Name;
                pc.MouseClick += new MouseEventHandler(DeleteImage);
                panelRock.Controls.Add(pc);

            }



            d = new DirectoryInfo(@"Data/RockPaperScissors/Paper/");//Assuming Test is your Folder
            Files = d.GetFiles("*.jpg"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                Image image;
                using (Stream stream = File.OpenRead(@"Data/RockPaperScissors/Paper/" + file.Name))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }
                PictureBox pc = new PictureBox();
                pc.Height = 125;
                pc.Width = 125;
                pc.BorderStyle = BorderStyle.Fixed3D;
                pc.BackgroundImage = image;
                pc.BackgroundImageLayout = ImageLayout.Stretch;
                pc.Dock = DockStyle.Top;


                pc.Name = pc.Name = file.Name; ;
                pc.MouseClick += new MouseEventHandler(DeleteImage);
                panelPaper.Controls.Add(pc);

            }


            d = new DirectoryInfo(@"Data/RockPaperScissors/Scissors/");//Assuming Test is your Folder
            Files = d.GetFiles("*.jpg"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                Image image;
                using (Stream stream = File.OpenRead(@"Data/RockPaperScissors/Scissors/" + file.Name))
                {
                    image = System.Drawing.Image.FromStream(stream);
                }
                PictureBox pc = new PictureBox();
                pc.Height = 125;
                pc.Width = 125;
                pc.BorderStyle = BorderStyle.Fixed3D;
                pc.BackgroundImage = image;
                pc.BackgroundImageLayout = ImageLayout.Stretch;
                pc.Dock = DockStyle.Top;


                pc.Name = pc.Name = file.Name;
                pc.MouseClick += new MouseEventHandler(DeleteImage);
                panelScissors.Controls.Add(pc);

            }

        }

        private void OpenWebCam()
        {
            kamera = new VideoCaptureDevice();
            cihazlar = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (kamera.IsRunning)
            {
                kamera.Stop();
                pictureBoxWebcam.Image = null;
                pictureBoxWebcam.Invalidate();
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
            pictureBoxWebcam.BackgroundImage = image;
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            countDown = 3;
            timerRPS.Enabled = true;
            labelCountDown.Visible = false;
        }

        private void buttonAddImageWithLabel_Click(object sender, EventArgs e)
        {

            Bitmap image = (Bitmap)pictureBoxWebcam.BackgroundImage;
            Bitmap croppedImage = new Bitmap(200, 300);

            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < 300; j++)
                {

                    croppedImage.SetPixel(i, j, image.GetPixel(i + 200, j + 30));
                }
            }
            image = croppedImage;



            PictureBox pc = new PictureBox();
            pc.Height = 180;
            pc.Width = 120;
            pc.BorderStyle = BorderStyle.Fixed3D;
            pc.BackgroundImage = image;
            pc.BackgroundImageLayout = ImageLayout.Stretch;
            pc.Dock = DockStyle.Top;

            string imageName = DateTime.Now.ToLongTimeString() + DateTime.Now.ToShortDateString();
            imageName = imageName.Replace(":", "").Replace(".", "");
            imageName = imageName + ".jpg";
            pc.Name = imageName;
            pc.MouseClick += new MouseEventHandler(DeleteImage);


            if (comboBoxClassLabel.SelectedIndex == 0)
            {
                panelRock.Controls.Add(pc);

                image.Save(@"Data/RockPaperScissors/Rock/" + imageName, ImageFormat.Jpeg);
            }

            if (comboBoxClassLabel.SelectedIndex == 1)
            {
                panelPaper.Controls.Add(pc);

                image.Save(@"Data/RockPaperScissors/Paper/" + imageName, ImageFormat.Jpeg);
            }

            if (comboBoxClassLabel.SelectedIndex == 2)
            {
                panelScissors.Controls.Add(pc);

                image.Save(@"Data/RockPaperScissors/Scissors/" + imageName, ImageFormat.Jpeg);
            }

        }
        private void DeleteImage(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            string path = @"Data/RockPaperScissors/" + pb.Parent.Name.Replace("panel", "") + "/" + pb.Name;
            DialogResult result = MessageBox.Show(pb.Name + " adlı dosyayı silmek istiyor musunuz?", "Dosya Silme!!!", MessageBoxButtons.YesNo);
            //MessageBox.Show(path);
            if (result == DialogResult.Yes)
            {
                pb.BackgroundImage = null;
                pb.Parent.Controls.Remove(pb);
                File.Delete(path);

            }
        }

        private void buttonTrainRPS_Click(object sender, EventArgs e)
        {
            List<string> folders = new List<string>() { "Rock", "Paper", "Scissors" };

            foreach (string folder in folders)
            {
                DirectoryInfo d = new DirectoryInfo(@"Data/RockPaperScissors/" + folder + "/");//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.jpg"); //Getting Text files


                int counter = 0;
                int total = Files.Count();
                foreach (FileInfo file in Files)
                {

                    Image image;
                    using (Stream stream = File.OpenRead(@"Data/RockPaperScissors/" + folder + "/" + file.Name))
                    {
                        image = System.Drawing.Image.FromStream(stream);
                    }
                    image.RotateFlip(RotateFlipType.Rotate90FlipY);


                    if (counter < total / 3 * 2)
                        image.Save(@"C:\ProjeYonetimiOrcunOzdil\ProjeYonetimiOrcunOzdil\bin\Debug\PythonServer\RockPaperSic\datasetUser\test_set\" + folder.ToLower() + "\\" + file.Name);
                    else
                        image.Save(@"C:\ProjeYonetimiOrcunOzdil\ProjeYonetimiOrcunOzdil\bin\Debug\PythonServer\RockPaperSic\datasetUser\training_set\" + folder.ToLower() + "\\" + file.Name);

                    counter++;
                }
            }






            PostRequest postRequest = new PostRequest();
            string result = postRequest.RPS_TrainRequest();
            MessageBox.Show(result);
        }

        private void pictureBoxWebcam_Paint(object sender, PaintEventArgs e)
        {
            Rectangle ee = new Rectangle(200, 30, 200, 300);
            using (Pen pen = new Pen(Color.Red, 4))
            {
                e.Graphics.DrawRectangle(pen, ee);
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //copy sav
            File.Delete(setupConfig.RPSUserModelPath);
            File.Copy(setupConfig.RPSDefaultDataPath, setupConfig.RPSUserModelPath);
        }
    }
}
