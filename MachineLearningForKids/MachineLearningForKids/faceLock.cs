using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class faceLock : Form
    {

        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
        HaarCascade faceDetection;
        Image<Bgr, Byte> Frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> trainedFace = null;
        Image<Gray, byte> grayFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> users = new List<string>();
        int count, numLabeles, t;
        string name;

        private void btn_tani_Click(object sender, EventArgs e)
        {
            pictureBox_icon.Visible = false;
            groupBox_egitim.Visible = true;
            lbl_ad.Visible = true;
            textBoxAd.Visible = true;
            btn_egit.Visible = true;
            cameraBox.Visible = true;
            btn_dur.Visible = true;
            btn_tani.Visible = false;

            camera = new Capture();
            Application.Idle += new EventHandler(FrameProcedure);
        }

        private void btn_egit_Click(object sender, EventArgs e)
        {
            count = count + 1;
            grayFace = camera.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            MCvAvgComp[][] DetectedFaces = grayFace.DetectHaarCascade(faceDetection, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            foreach (MCvAvgComp item in DetectedFaces[0])
            {
                trainedFace = Frame.Copy(item.rect).Convert<Gray, byte>();
                break;
            }
            trainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(trainedFace);
            labels.Add(textBoxAd.Text);
            File.WriteAllText(Application.StartupPath + "/Faces/Faces.txt", trainingImages.ToArray().Length.ToString() + ",");
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/Faces/fac" + i + ".bmp");
                File.AppendAllText(Application.StartupPath + "/Faces/Faces.txt", labels.ToArray()[i - 1] + ",");
            }
            MessageBox.Show(textBoxAd.Text + " yüzün başarı ile eklendi.");
        }

        public faceLock()
        {
            InitializeComponent();

            faceDetection = new HaarCascade("haarcascade_frontalface_default.xml");
            try
            {
                string Labelsinf = File.ReadAllText(Application.StartupPath + "/Faces/Faces.txt");
                string[] Labels = Labelsinf.Split(',');
                
                numLabeles = Convert.ToInt16(Labels[0]);
                count = numLabeles;
                string FacesLoad;
                for (int i = 1; i < numLabeles + 1; i++)
                {
                    FacesLoad = "face" + i + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/Faces/Faces.txt"));
                    labels.Add(labels[i]);
                }
            }
            catch (Exception E)
            {
               // MessageBox.Show("Elimizde hiç görsel yok");
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            camera.Dispose();

            this.Hide();
            anaMenu menu = new anaMenu();
            menu.ShowDialog();
        }



        private void FrameProcedure(object sender, EventArgs e)
        {
            try
            {
                users.Add("");
                Frame = camera.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                grayFace = Frame.Convert<Gray, Byte>();
                MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(faceDetection, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
                foreach (MCvAvgComp item in facesDetectedNow[0])
                {
                    result = Frame.Copy(item.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    Frame.Draw(item.rect, new Bgr(Color.Yellow), 3);
                    if (trainingImages.ToArray().Length != 0)
                    {
                        MCvTermCriteria termCriterias = new MCvTermCriteria(count, 0.001);
                        EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
                        name = recognizer.Recognize(result);
                        Frame.Draw(name, ref font, new Point(item.rect.X - 2, item.rect.Y - 2), new Bgr(Color.White));
                    }
                    users.Add("");
                }
                cameraBox.Image = Frame;

                users.Clear();
            }
            catch { }
        }

        private void btn_dur_Click(object sender, EventArgs e)
        {
            camera.Dispose();
            groupBox_egitim.Visible = false;
            cameraBox.Visible = false;
            pictureBox_icon.Visible = true;
            btn_dur.Visible = false;
            btn_tani.Visible = true;

        }

        private void faceLock_Load(object sender, EventArgs e)
        {
            acilistaGorunmeyecekler();
            name = "";
        }

        private void acilistaGorunmeyecekler()
        {
            btn_dur.Visible = false;
            cameraBox.Visible = false;
            lbl_ad.Visible = false;
            textBoxAd.Visible = false;
            btn_egit.Visible = false;
            groupBox_egitim.Visible = false;

        }
            
    }
}
