using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacingGame
{
    public partial class MainMenu : Form
    {
        public static string passingTimes;
        public MainMenu()
        {
            InitializeComponent();
        }
        void ChoosingGameOption()
        {
            if (radioBtn30s.Checked == true)
            {
                passingTimes = "30s";
            }
            else if (radioBtn60s.Checked == true)
            {
                passingTimes = "60s";
            }
            else if (radioBtn120s.Checked == true)
            {
                passingTimes = "120s";
            }
            else if (radioBtnUnlimited.Checked == true)
            {
                passingTimes = "Unlimited";
            }

        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            radioBtnUnlimited.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoosingGameOption();
            Car newForm = new Car();
            this.Hide();
            newForm.ShowDialog();
        }

        private void radioBtn60s_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
