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
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Setting();
        }
        void Setting()
        {
            moveline(gamespeed);
            policecarandcoin(gamespeed);
            collectedcoin();
            gameover();
        }
        Random r = new Random();
        int x, y;

        void policecarandcoin(int speed)
        {
            if(PoliceCar1.Top >= 500)
            {
                x = r.Next(11, 200);
                PoliceCar1.Location = new Point(x, 40);
            }
            else
            {
                PoliceCar1.Top += speed;
            }

            if (PoliceCar2.Top >= 500)
            {
                x = r.Next(11, 332);
                PoliceCar2.Location = new Point(x, 40);
            }
            else
            {
                PoliceCar2.Top += speed;
            }

            if (PoliceCar3.Top >= 500)
            {
                x = r.Next(200, 332);
                PoliceCar3.Location = new Point(x, 40);
            }
            else
            {
                PoliceCar3.Top += speed;
            }
            if (coin3.Top >= 500)
            {
                x = r.Next(11, 200);
                coin3.Location = new Point(x, 40);
            }
            else
            {
                coin3.Top += speed;
            }

            if (coin1.Top >= 500)
            {
                x = r.Next(11, 332);
                coin1.Location = new Point(x, 0);
            }
            else
            {
                coin1.Top += speed;
            }

            if (coin2.Top >= 500)
            {
                x = r.Next(11, 200);
                coin2.Location = new Point(x, 40);
            }
            else
            {
                coin2.Top += speed;
            }

            if (coin4.Top >= 500)
            {
                x = r.Next(200, 332);
                coin4.Location = new Point(x, 40);
            }
            else
            {
                coin4.Top += speed;
            }
        }
        void gameover()
        {
            if(MainCar.Bounds.IntersectsWith(PoliceCar1.Bounds))
            {
                timer1.Enabled = false;
                lblgameover.Visible = true;
                button1.Visible = true;
            }

            if (MainCar.Bounds.IntersectsWith(PoliceCar2.Bounds))
            {
                timer1.Enabled = false;
                lblgameover.Visible = true;
                button1.Visible = true;
            }

            if (MainCar.Bounds.IntersectsWith(PoliceCar3.Bounds))
            {
                timer1.Enabled = false;
                lblgameover.Visible = true;
                button1.Visible = true;
            }
        }
        int totalcoin = 0;
        void collectedcoin()
        {
            if(MainCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                totalcoin++;
                label3.Text = totalcoin.ToString();
                x = r.Next(11, 200);
                coin1.Location = new Point(x, 0);
            }

            if (MainCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                totalcoin++;
                label3.Text = totalcoin.ToString();
                x = r.Next(11,332);
                coin2.Location = new Point(x, 0);
            }

            if (MainCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                totalcoin++;
                label3.Text = totalcoin.ToString();
                x = r.Next(11, 200);
                coin3.Location = new Point(x, 0);
            }

            if(MainCar.Bounds.IntersectsWith(coin4.Bounds))
            {
                totalcoin++;
                label3.Text = totalcoin.ToString();
                x = r.Next(200,332);
                coin4.Location = new Point(x, 0);
            }
        }


        void moveline(int speed)
        {
            if(middleRoad1.Top >= 540)
            {
                middleRoad1.Top = 0;
                lblspeed.Text = "0";
            }
            else
            {
                middleRoad1.Top += speed;
                lblspeed.Text = speed.ToString();
            }

            if (middleRoad2.Top >= 540)
            {
                middleRoad2.Top = 0;
            }
            else
            {
                middleRoad2.Top += speed;
            }

            if (middleRoad3.Top >= 540)
            {
                middleRoad3.Top = 0;
            }
            else
            {
                middleRoad3.Top += speed;
            }

            if (middleRoad4.Top >= 540)
            {
                middleRoad4.Top = 0;
            }
            else
            {
                middleRoad4.Top += speed;
            }

            if (middleRoad5.Top >= 500)
            {
                middleRoad5.Top = 0;
            }
            else
            {
                middleRoad5.Top += speed;
            }

        }
        int counter;
        private System.Windows.Forms.Timer timer2;
        private void CarRacing_Load(object sender, EventArgs e)
        {
            if (MainMenu.passingTimes == "30s")
            {
                counter = 30;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();
                lblTimes.Text = counter.ToString()+" s";
            }
            else if (MainMenu.passingTimes == "60s")
            {
                counter = 60;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();
                lblTimes.Text = counter.ToString() + " s";
            }
            else if (MainMenu.passingTimes == "120s")
            {
                counter = 120;
                timer2 = new System.Windows.Forms.Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();
                lblTimes.Text = counter.ToString() + " s";
            }
            else if(MainMenu.passingTimes == "Unlimited")
            {
                lblTimes.Visible = false;
            }

           
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer2.Stop();
                timer1.Enabled = false;
                lblgameover.Visible = true;
                button1.Visible = true;

            }
                
            lblTimes.Text = counter.ToString()+" s";
        }

        int gamespeed = 0;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void middleRoad4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car newForm = new Car();
            this.Hide();
            newForm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainMenu newForm = new MainMenu();
            this.Hide();
            newForm.ShowDialog();
        }

        private void speed_Click(object sender, EventArgs e)
        {

        }

        private void CarRacing_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(MainCar.Left > 20)
                {
                    MainCar.Left += -10;
                }
            }
            if(e.KeyCode ==Keys.Right)
            {
                if (MainCar.Right < 370)
                {
                    MainCar.Left += 8;
                }    
            }
            if(e.KeyCode == Keys.Up)
            {
                if (gamespeed < 10)
                {
                    gamespeed++;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                if(gamespeed > 0)
                {
                    gamespeed--;
                }
            }

            if(e.KeyCode == Keys.Escape)
            {
                MainMenu oldForm = new MainMenu();
                this.Hide();
                oldForm.ShowDialog();
            }
        }
    }
}
