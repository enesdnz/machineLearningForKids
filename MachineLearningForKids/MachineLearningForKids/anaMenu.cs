using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            cikisYap();
        }

        private void btn_oyna_Click(object sender, EventArgs e)
        {
            oyunSecme();

        }

        private void cikisYap()
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }

            else if (cikis == DialogResult.No)
            {

            }
        }

        private void oyunSecme()
        {
            RadioButton radioBtn = this.Controls.OfType<RadioButton>()
                                       .Where(x => x.Checked).FirstOrDefault();
            if (radioBtn != null)
            {
                switch (radioBtn.Name)
                {
                    case "radio_faceLock":

                        faceLock faceLock = new faceLock();
                        this.Hide();
                        faceLock.Show();
                        break;

                    case "radio_snap":

                        snap snap = new snap();
                        this.Hide();
                        //snap.Show();
                        break;

                    case "radio_shyPanda":

                        shypanda shypanda = new shypanda();
                        this.Hide();
                        shypanda.Show();
                        break;

                    case "radio_zombieEscape":

                        zombie zombie = new zombie();
                        this.Hide();
                        zombie.Show();
                        break;

                    case "radio_chameleon":

                        chameleon chameleon = new chameleon();
                        this.Hide();
                        chameleon.Show();
                        break;


                    case "radio_colors":

                        colors color = new colors();
                        this.Hide();
                        color.Show();
                        break;

                    case "radio_imageText":

                        imageToTextGame game = new imageToTextGame();
                        this.Hide();
                        game.Show();
                        break;

                    case "radio_figureGame":

                        figureGame figure = new figureGame();
                        this.Hide();
                        figure.Show();
                        break;

                    case "radio_rockPaperScissors":

                        rockpaperscissors rockpaperscissors = new rockpaperscissors();
                        this.Hide();
                        rockpaperscissors.Show();
                        break;

                    case "radio_titanic":

                        titanic titanic = new titanic();
                        this.Hide();
                        titanic.Show();
                        break;
                }

            }
        }

        private void anaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
