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
using Alturos.Yolo;
namespace MachineLearningForKids
{
    public partial class snap : Form
    {
        public snap()
        {
            InitializeComponent();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            anaMenu menu = new anaMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Visible = false;
            OpenFileDialog choose = new OpenFileDialog();
            if (choose.ShowDialog() == DialogResult.OK)
            {
                pictureBoxSelected.Image = Image.FromFile(choose.FileName);
            }
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            dataGridViewResult.Visible = true;
            var configurationDetector = new ConfigurationDetector();
            var config = configurationDetector.Detect();
            using (var yoloWrapper = new YoloWrapper(config))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBoxSelected.Image.Save(ms, ImageFormat.Png);
                    var items = yoloWrapper.Detect(ms.ToArray());
                    yoloItemBindingSource.DataSource = items;
                }
            }
            this.Focus();
        }

        private void snap_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in this.dataGridViewResult.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null)
                    {
                        continue;

                    }
                    else
                    {
                        string colnum;
                        colnum = dataGridViewResult.Columns[1].Name;
                    }
                }
            }

            //dataGridViewResult.Visible = false;
            //dataGridViewResult.Columns[0].Width = 100;
            //dataGridViewResult.Columns[1].Width = 50;
            //dataGridViewResult.Columns[2].Width = 50;
            //dataGridViewResult.Columns[3].Width = 50;
            //dataGridViewResult.Columns[4].Width = 50;
            //dataGridViewResult.Columns[5].Width = 50;
        }
    }
}
