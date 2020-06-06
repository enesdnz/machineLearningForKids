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
    public partial class titanic : Form
    {
        public titanic()
        {
            InitializeComponent();
        }
        SetupConfig setupConfig = new SetupConfig();
        private void buttonPrediction_Click(object sender, EventArgs e)
        {
            MakePrediction();
        }
        private void MakePrediction()
        {
            pictureBoxResult.Visible = false;
            labelTitanicResult.Visible = false;
            pictureBoxTitanicBackGround.BringToFront();
            string data = ProcessData();



            PostRequest postRequest = new PostRequest();
            string result = postRequest.TitanicPredictionRequest(data).ToString().Trim();


            pictureBoxResult.Visible = true;
            labelTitanicResult.Visible = true;
            pictureBoxResult.BringToFront();

            if (result == "0")
            {
                pictureBoxResult.BackgroundImage = Properties.Resources.Jack;
                labelTitanicResult.Text = "You Died !";
            }
            else
            {
                pictureBoxResult.BackgroundImage = Properties.Resources.Rose;
                labelTitanicResult.Text = "You Survived !";
            }
        }
        private string ProcessData()
        {
            double ticketClass = Convert.ToDouble(comboBoxTicketClass.SelectedItem.ToString().Replace(". Class", ""));
            int gender = (comboBoxGender.SelectedItem.ToString().ToLower() == "male") ? 0 : 1;        //male 0,female 1   
            double age = Convert.ToDouble(comboBoxAge.SelectedItem.ToString());
            double siblings = Convert.ToDouble(comboBoxSiblings.SelectedItem.ToString());
            double parCh = Convert.ToDouble(comboBoxParentChild.SelectedItem.ToString());
            double fare = (comboBoxFare.SelectedIndex + 1) * 500.0;
            if (comboBoxFare.SelectedIndex == 100)
                fare = maxFare;

            double embarked = comboBoxEmbarked.SelectedIndex;//S=0,C=1,Q=2

            //1-0 dışındaki değerler için scaling uyguluyoruz
            ticketClass = ticketClass * 0.5;
            age = (age - minAge) / (maxAge - minAge);
            siblings = (siblings - minSib) / (maxSib - minSib);
            parCh = (parCh - minParCh) / (maxParCh - minParCh);
            fare = (fare - minFare) / (maxFare - minFare);

            embarked = embarked * 0.5;
            string data = "[" + ticketClass.ToString().Replace(",", ".") + "," + gender.ToString().Replace(",", ".") + "," + age.ToString().Replace(",", ".") + "," + siblings.ToString().Replace(",", ".") + ","
                + parCh.ToString().Replace(",", ".") + "," + fare.ToString().Replace(",", ".") + "," + embarked.ToString().Replace(",", ".") + "]";
            return data;
        }
        private void buttonAddData_Click(object sender, EventArgs e)
        {
            string TicketClass = (comboBoxAddTicketClass.SelectedIndex + 1).ToString();
            string Gender = comboBoxAddGender.SelectedItem.ToString().ToLower();
            string Age = comboBoxAddAge.SelectedIndex.ToString();
            string SibSp = comboBoxAddSiblings.SelectedIndex.ToString();
            string Parch = comboBoxAddParentChild.SelectedIndex.ToString();
            string Fare = ((comboBoxAddFare.SelectedIndex + 1) * 500.0).ToString();
            if (comboBoxAddFare.SelectedIndex == 100)
                Fare = maxFare.ToString();
            string Embarked = comboBoxAddEmbarked.SelectedItem.ToString().Split('=')[0].Trim();
            string Survived = comboBoxAddSurvived.SelectedIndex.ToString();

            dataTable.Rows.Add(TicketClass, Gender, Age, SibSp, Parch, Fare, Embarked, Survived);
            dataGridViewTitanicData.Rows.Add(TicketClass, Gender, Age, SibSp, Parch, Fare, Embarked, Survived);
            labelRecordCount.Text = dataGridViewTitanicData.Rows.Count.ToString() + " Records";
        }
        int maxAge;
        int minAge;
        int maxSib;
        int minSib;
        int maxParCh;
        int minParCh;
        double maxFare;
        double minFare;
        DataTable dataTable;
        private void titanic_Load(object sender, EventArgs e)
        {
            //Tahmin ve veri girşi için comboboxları doldur
            LoadComboBoxes();
            //Defautlt Model ve Dataları Oku, değişkenleri tanımla
            LoadDefaults();    
        }
        private void LoadDefaults()
        {
            try
            {
                string path = setupConfig.TitanicUserDataPath;
                dataTable = ConvertCSVtoDataTable(path);
                dataGridViewTitanicData.ColumnCount = 8;
                dataGridViewTitanicData.DefaultCellStyle.Font = new Font("Comic Sans", 9);
                dataGridViewTitanicData.Rows.Clear();
                int counter = 0;
                foreach (DataColumn column in dataTable.Columns)
                {
                    dataGridViewTitanicData.Columns[counter].HeaderText = column.ColumnName;
                    counter++;
                }


                foreach (DataRow row in dataTable.Rows)
                {
                    dataGridViewTitanicData.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
                }



                maxAge = dataTable.AsEnumerable().Max(row => Convert.ToInt32(row["Age"]));
                minAge = dataTable.AsEnumerable().Min(row => Convert.ToInt32(row["Age"]));

                maxSib = dataTable.AsEnumerable().Max(row => Convert.ToInt32(row["SibSp"]));
                minSib = dataTable.AsEnumerable().Min(row => Convert.ToInt32(row["SibSp"]));

                maxParCh = dataTable.AsEnumerable().Max(row => Convert.ToInt32(row["Parch"]));
                minParCh = dataTable.AsEnumerable().Min(row => Convert.ToInt32(row["Parch"]));


                maxFare = dataTable.AsEnumerable().Max(row => Convert.ToDouble(row["Fare"].ToString().Replace(".", ",")));
                minFare = dataTable.AsEnumerable().Min(row => Convert.ToDouble(row["Fare"].ToString().Replace(".", ",")));




            }
            catch
            {
                MessageBox.Show("Veri yolu bozulmuş, ayarları kontrol ediniz!");
            }

            labelRecordCount.Text = dataGridViewTitanicData.Rows.Count.ToString() + " Records";



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
        private void LoadComboBoxes()
        {
            comboBoxAddTicketClass.Items.Add("1. Class");
            comboBoxAddTicketClass.Items.Add("2. Class");
            comboBoxAddTicketClass.Items.Add("3. Class");
            comboBoxAddTicketClass.SelectedIndex = 0;

            comboBoxTicketClass.Items.Add("1. Class");
            comboBoxTicketClass.Items.Add("2. Class");
            comboBoxTicketClass.Items.Add("3. Class");
            comboBoxTicketClass.SelectedIndex = 0;

            comboBoxGender.Items.Add("Male");
            comboBoxGender.Items.Add("Female");
            comboBoxGender.SelectedIndex = 0;

            comboBoxAddGender.Items.Add("Male");
            comboBoxAddGender.Items.Add("Female");
            comboBoxAddGender.SelectedIndex = 0;


            for (int i = 0; i < 100; i++)
            {
                comboBoxAge.Items.Add(i.ToString());
                comboBoxAddAge.Items.Add(i.ToString());
            }
            comboBoxAge.SelectedIndex = 0;
            comboBoxAddAge.SelectedIndex = 0;


            for (int i = 0; i < 20; i++)
            {
                comboBoxSiblings.Items.Add(i.ToString());
                comboBoxAddSiblings.Items.Add(i.ToString());
                comboBoxParentChild.Items.Add(i.ToString());
                comboBoxAddParentChild.Items.Add(i.ToString());


            }
            comboBoxSiblings.SelectedIndex = 0;
            comboBoxAddSiblings.SelectedIndex = 0;
            comboBoxParentChild.SelectedIndex = 0;
            comboBoxAddParentChild.SelectedIndex = 0;


            for (int i = 0; i < 100; i++)
            {
                string limit = (i * 500).ToString() + " - " + ((i + 1) * 500).ToString() + "$";
                comboBoxFare.Items.Add(limit);
                comboBoxAddFare.Items.Add(limit);
            }
            comboBoxFare.Items.Add("More ...");
            comboBoxAddFare.Items.Add("More ...");
            comboBoxFare.SelectedIndex = 0;
            comboBoxAddFare.SelectedIndex = 0;

            comboBoxEmbarked.Items.Add("S = Southampton");
            comboBoxEmbarked.Items.Add("C = Cherbourg");
            comboBoxEmbarked.Items.Add("Q = Queenstown");
            comboBoxEmbarked.SelectedIndex = 0;

            comboBoxAddEmbarked.Items.Add("S = Southampton");
            comboBoxAddEmbarked.Items.Add("C = Cherbourg");
            comboBoxAddEmbarked.Items.Add("Q = Queenstown");
            comboBoxAddEmbarked.SelectedIndex = 0;

            comboBoxAddSurvived.Items.Add("0 = No");
            comboBoxAddSurvived.Items.Add("1 = Yes");
            comboBoxAddSurvived.SelectedIndex = 0;

        }

        private void buttonTitanicTrain_Click(object sender, EventArgs e)
        {
            WriteDataToCsv();
            TrainDataset();
            LoadDefaults();
        }
        private void WriteDataToCsv()
        {
            StringBuilder sb = new StringBuilder();

            string[] columnNames = dataTable.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName).
                                              ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dataTable.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).
                                                ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(setupConfig.TitanicUserDataPath, sb.ToString());
        }
        private void TrainDataset()
        {
            PostRequest postRequest = new PostRequest();
            string result = postRequest.TitanicTrainRequest().ToString().Trim();
            MessageBox.Show(result);
        }

        private void dataGridViewTitanicData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridViewTitanicData.SelectedRows[0].Index;
            dataGridViewTitanicData.Rows.RemoveAt(rowIndex);
            dataTable.Rows.RemoveAt(rowIndex);
            labelRecordCount.Text = dataGridViewTitanicData.Rows.Count.ToString() + " Records";
        }

        private void buttonRestoreData_Click(object sender, EventArgs e)
        {
            //copy csv
            File.Delete(setupConfig.TitanicUserDataPath);
            File.Copy(setupConfig.TitanicDefaultDataPath, setupConfig.TitanicUserDataPath);
            //copy sav
            File.Delete(setupConfig.TitanicUserModelPath);
            File.Copy(setupConfig.TitanicDefaultModelPath, setupConfig.TitanicUserModelPath);

            LoadDefaults();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            anaMenu menu = new anaMenu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}
