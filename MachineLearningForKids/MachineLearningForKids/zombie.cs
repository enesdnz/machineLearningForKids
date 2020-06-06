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
    public partial class zombie : Form
    {
        public zombie()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

            this.Hide();
            anaMenu menu = new anaMenu();
            menu.ShowDialog();
        }
        int score;
        SetupConfig setupConfig = new SetupConfig();
        private void timerZombieEscape_Tick(object sender, EventArgs e)
        {

            if (DateTime.Now.Second % 3 == 0)
                pictureBoxZombieBackground.BackgroundImage = Properties.Resources.zombieBg0;
            if (DateTime.Now.Second % 3 == 1)
                pictureBoxZombieBackground.BackgroundImage = Properties.Resources.zombieBg1;
            if (DateTime.Now.Second % 3 == 2)
                pictureBoxZombieBackground.BackgroundImage = Properties.Resources.zombieBg3;
        }

        private void zombie_Load(object sender, EventArgs e)
        {
            pictureBoxResult.Visible = false;
            LoadRooms();
            //MessageBox.Show("Rooms loaded");
            TrainModel();
            //MessageBox.Show("Model trained");
            RandomSelection();
            //MessageBox.Show("Random room selected");
            score = 0;
        }
        private void TrainModel()
        {

            PostRequest postRequest = new PostRequest();
            string result = postRequest.ZombieTrainRequest(sensorsActive).ToString().Trim();
            labelModelInfo.Text = "Model Info :" + sensorsActive + "\n" + result;
            MessageBox.Show("Model Info :" + sensorsActive + "\n" + result);
        }

        private void RandomSelection()
        {

            Random rand = new Random();
            int row_count = dataGridViewZombie.RowCount;
            panelDoor1.Controls.Clear();
            panelDoor2.Controls.Clear();
            List<string> SafeRoomValues = new List<string>();
            List<string> ZombieRoomValues = new List<string>();
            string safe = "0";
            while (safe == "0")
            {
                int randomRow = rand.Next(0, row_count);
                SafeRoomValues = new List<string>();
                for (int col = 0; col < dataGridViewZombie.Columns.Count; col++)
                {
                    SafeRoomValues.Add(dataGridViewZombie.Rows[randomRow].Cells[col].Value.ToString());
                }
                safe = SafeRoomValues[12];
            }

            while (safe == "1")
            {
                int randomRow = rand.Next(0, row_count);
                ZombieRoomValues = new List<string>();
                for (int col = 0; col < dataGridViewZombie.Columns.Count; col++)
                {
                    ZombieRoomValues.Add(dataGridViewZombie.Rows[randomRow].Cells[col].Value.ToString());
                }
                safe = ZombieRoomValues[12];
            }



            int leftOrRight = rand.Next(0, 2);
            List<Panel> doorPanels = new List<Panel>() { panelDoor1, panelDoor2 };

            for (int i = 13; i >= 0; i--)
            {
                Label lb1 = new Label();
                lb1.Dock = DockStyle.Top;
                lb1.AutoSize = false;
                lb1.Font = new Font("ComicSans", 10, FontStyle.Bold);

                if (i == 13)
                {
                    lb1.Text = "Prediction : ";
                    doorPanels[leftOrRight].Controls.Add(lb1);
                }
                else if (i == 12)
                {
                    lb1.Text = "Safety : " + SafeRoomValues[i];
                    lb1.Visible = false;
                    doorPanels[leftOrRight].Controls.Add(lb1);
                }
                else
                {
                    lb1.Text = "Sensor" + (i + 1).ToString() + " : " + SafeRoomValues[i];
                    if (sensorsActive.Substring(i, 1) == "1")
                        doorPanels[leftOrRight].Controls.Add(lb1);
                }





            }

            for (int i = 13; i >= 0; i--)
            {
                Label lb1 = new Label();
                lb1.Dock = DockStyle.Top;
                lb1.AutoSize = false;
                lb1.Font = new Font("ComicSans", 10, FontStyle.Bold);

                if (i == 13)
                {
                    lb1.Text = "Prediction : ";
                    doorPanels[(leftOrRight + 1) % 2].Controls.Add(lb1);
                }
                else if (i == 12)
                {
                    lb1.Text = "Safety : " + ZombieRoomValues[i];
                    lb1.Visible = false;
                    doorPanels[(leftOrRight + 1) % 2].Controls.Add(lb1);
                }
                else
                {
                    lb1.Text = "Sensor" + (i + 1).ToString() + " : " + ZombieRoomValues[i];
                    if (sensorsActive.Substring(i, 1) == "1")
                        doorPanels[(leftOrRight + 1) % 2].Controls.Add(lb1);
                }


            }
            MakePrediction();

        }

        private void MakePrediction()
        {
            List<Panel> doorPanels = new List<Panel>() { panelDoor1, panelDoor2 };
            foreach (Panel panel in doorPanels)
            {
                List<double> predictionData = new List<double>();
                for (int i = panel.Controls.Count - 1; i >= 2; i--)
                {
                    string sensor = panel.Controls[i].Text.Split(':')[0];
                    sensor = sensor.Replace("Sensor", "").Trim();
                    string value = panel.Controls[i].Text.Split(':')[1];
                    int _sensor = Convert.ToInt32(sensor);
                    string scaledValue = ScaledValue(value, _sensor - 1);
                    predictionData.Add(Convert.ToDouble(scaledValue));


                }

                string _predictionData = String.Join(";", predictionData);
                PostRequest postRequest = new PostRequest();
                string result = postRequest.ZombiePredictionRequest(_predictionData).ToString();


                panel.Controls[0].Text = "Prediciton : " + result;

            }

        }

        private string ScaledValue(string value, int i)
        {
            List<Double> minMax = setupConfig.ZombieMinMax;
            double min = minMax[i * 2];
            double max = minMax[i * 2 + 1];
            double _value = Convert.ToDouble(value);
            double scaled = Convert.ToDouble(_value - min) / Convert.ToDouble(max - min);
            string result = scaled.ToString();
            return result;
        }





        private void LoadRooms()
        {
            DataTable dataTable;
            dataGridViewZombie.ColumnCount = 13;
            try
            {
                string path = setupConfig.ZombieDefaultDataPath;
                dataTable = ConvertCSVtoDataTable(path);

                dataGridViewZombie.DefaultCellStyle.Font = new Font("Comic Sans", 8);
                dataGridViewZombie.ColumnHeadersDefaultCellStyle.Font = new Font("Comic Sans", 8);
                dataGridViewZombie.Rows.Clear();
                int counter = 0;
                foreach (DataColumn column in dataTable.Columns)
                {
                    dataGridViewZombie.Columns[counter].HeaderText = column.ColumnName.Replace("v", "Sens_");
                    dataGridViewZombie.Columns[counter].Width = 52;
                    counter++;
                }


                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewZombie.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8], row[9], row[10], row[11], row[12]);
                }


            }
            catch
            {
                MessageBox.Show("Veri yolu bozulmuş, ayarları kontrol ediniz!");
            }

            labelRecordCount.Text = dataGridViewZombie.Rows.Count.ToString() + " Records";
        }
        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }

            }

            return dt;
        }
        private void RandomZombie(int doorLeftOrRight)
        {
            int safe = 0;
            string _safe = "";
            if (doorLeftOrRight == 1)
            {
                _safe = panelDoor1.Controls[1].Text.Replace("Safety : ", "");


            }
            if (doorLeftOrRight == 2)
            {
                _safe = panelDoor2.Controls[1].Text.Replace("Safety : ", "");

            }
            safe = Convert.ToInt32(_safe);




            List<Image> images = new List<Image>() {Properties.Resources.zombie1,Properties.Resources.zombie2,Properties.Resources.zombie3,
                                Properties.Resources.zombie4,Properties.Resources.zombie5,Properties.Resources.zombie6,Properties.Resources.zombieFree};
            if (safe == 1)
            {
                pictureBoxResult.BackgroundImage = images[6];
                score++;
                labelScoreBoard.Text = "Your Score : " + score.ToString();
            }

            else
            {
                Random rand = new Random();
                pictureBoxResult.BackgroundImage = images[rand.Next(0, 5)];
                score = 0;
                labelScoreBoard.Text = "Your Score : " + score.ToString();

            }



            pictureBoxResult.Visible = true;


        }
        string sensorsActive = "111111111111";
        private void TrainDataset()
        {
            sensorsActive = "";
            List<CheckBox> sensors = new List<CheckBox>() 
            { 
                checkBoxSensor1, checkBoxSensor2, checkBoxSensor3, checkBoxSensor4, checkBoxSensor5, checkBoxSensor6,
                checkBoxSensor7, checkBoxSensor8, checkBoxSensor9, checkBoxSensor10, checkBoxSensor11, checkBoxSensor12}
              ;


            for (int i = 0; i < 12; i++)
            {
                string selection = "0";
                if (sensors[i].Checked)
                    selection = "1";

                sensorsActive += selection;
            }

            if (sensorsActive == "000000000000")
            {
                MessageBox.Show("En az bir sensör seçili olmalıdır!");
                return;
            }

            TrainModel();
            RandomSelection();
        }

        private void SensorChanged(object sender, EventArgs e)
        {
            CheckBox chb = sender as CheckBox;
            string sensorName = chb.Name;
            int sensorIndex = Convert.ToInt32(sensorName.Replace("checkBoxSensor", "")) - 1;

            if (chb.Checked)
            {
                chb.Text = "ON";
                dataGridViewZombie.Columns[sensorIndex].Visible = true;
            }
            else
            {
                chb.Text = "OFF";
                dataGridViewZombie.Columns[sensorIndex].Visible = false;
            }
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            TrainDataset();
        }

        private void pictureBoxResult_Click(object sender, EventArgs e)
        {
            pictureBoxResult.Visible = false;
            RandomSelection();
        }

        private void buttonChooseLeft_Click(object sender, EventArgs e)
        {
            RandomZombie(1);
        }

        private void buttonChooseRight_Click(object sender, EventArgs e)
        {
            RandomZombie(2);
        }
    }
}
