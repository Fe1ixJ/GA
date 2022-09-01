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

namespace GA
{
    public partial class Form1 : Form
    {
        int rörelse = 0;
        int points = 0;
        int speed1 = 15;
        int speed2 = 15;
        int speed3 = 15;
        int speed4 = 15;
        int speed5 = 15;
        Random rnd = new Random();
        Random rnd2 = new Random();
        //int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Highscore();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            InteMinBil1.Top += speed1;
            InteMinBil2.Top += speed2;
            InteMinBil3.Top += speed3;
            InteMinBil4.Top += speed4;
            InteMinBil5.Top += speed5;

            { //Better system above
                /*
                if (points <= 200)
                {
                    InteMinBil1.Top += 20;
                    InteMinBil2.Top += 20;
                    InteMinBil3.Top += 20;
                    InteMinBil4.Top += 20;
                    InteMinBil5.Top += 20;
                }
                if (points > 200)
                {
                    InteMinBil1.Top += 30;
                    InteMinBil2.Top += 30;
                    InteMinBil3.Top += 30;
                    InteMinBil4.Top += 30;
                    InteMinBil5.Top += 30;
                }
                if (points > 300)
                {
                    InteMinBil1.Top += 40;
                    InteMinBil2.Top += 40;
                    InteMinBil3.Top += 40;
                    InteMinBil4.Top += 40;
                    InteMinBil5.Top += 40;
                }
                if (points > 400)
                {
                    InteMinBil1.Top += 20;
                    InteMinBil2.Top += 20;
                    InteMinBil3.Top += 20;
                    InteMinBil4.Top += 20;
                    InteMinBil5.Top += 20;
                }
                */
            }


            MinBil.Left += rörelse;

            if (MinBil.Bounds.IntersectsWith(InteMinBil1.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GameOver");
                Highscore();

            }
            else if (MinBil.Bounds.IntersectsWith(InteMinBil2.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GameOver");
                Highscore();
            }
            else if (MinBil.Bounds.IntersectsWith(InteMinBil3.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GameOver");
                Highscore();
            }
            else if (MinBil.Bounds.IntersectsWith(InteMinBil4.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GameOver");
                Highscore();
            }
            else if (MinBil.Bounds.IntersectsWith(InteMinBil5.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("GameOver");
                Highscore();

            }
            else
            {
                points++;
            }

            if (InteMinBil1.Bounds.IntersectsWith(SlutPåVäg.Bounds))
            {
                InteMinBil1.Top = 20;
                int num = rnd.Next(3, 6);
                int VänsterEllerHöger = num * 100;
                Console.WriteLine(VänsterEllerHöger);
                InteMinBil1.Left = VänsterEllerHöger;
                speed1 = rnd2.Next(10, 40);
            }
            if (InteMinBil2.Bounds.IntersectsWith(SlutPåVäg.Bounds))
            {
                InteMinBil2.Top = 20;
                int num = rnd.Next(3, 6);
                int VänsterEllerHöger = num * 100;
                Console.WriteLine(VänsterEllerHöger);
                InteMinBil2.Left = VänsterEllerHöger;
                speed2 = rnd2.Next(10, 40);

            }
            if (InteMinBil3.Bounds.IntersectsWith(SlutPåVäg.Bounds))
            {
                InteMinBil3.Top = 20;
                int num = rnd.Next(3, 6);
                int VänsterEllerHöger = num * 100;
                Console.WriteLine(VänsterEllerHöger);
                InteMinBil3.Left = VänsterEllerHöger;
                speed3 = rnd2.Next(10, 40);
            }
            if (InteMinBil4.Bounds.IntersectsWith(SlutPåVäg.Bounds))
            {
                InteMinBil4.Top = 20;
                int num = rnd.Next(3, 6);
                int VänsterEllerHöger = num * 100;
                Console.WriteLine(VänsterEllerHöger);
                InteMinBil4.Left = VänsterEllerHöger;
                speed4 = rnd2.Next(10, 40);
            }
            if (InteMinBil5.Bounds.IntersectsWith(SlutPåVäg.Bounds))
            {
                InteMinBil5.Top = 20;
                int num = rnd.Next(3, 6);
                int VänsterEllerHöger = num * 100;
                Console.WriteLine(VänsterEllerHöger);
                InteMinBil5.Left = VänsterEllerHöger;
                speed5 = rnd2.Next(10, 40);

            }

            if (InteMinBil1.Bounds.IntersectsWith(InteMinBil2.Bounds))
            {
                if (speed1>speed2)
                {
                    speed1 = speed2;
                }
                if (speed2>speed1)
                {
                    speed2 = speed1;
                }
                else
                {
                    speed1 = speed2;
                }

            }
            if (InteMinBil1.Bounds.IntersectsWith(InteMinBil3.Bounds))
            {
                if (speed1>speed3)
                {
                    speed1 = speed3;
                }
                if (speed3>speed1)
                {
                    speed3 = speed1;
                }
                else
                {
                    speed1 = speed3;
                }
            }
            if (InteMinBil1.Bounds.IntersectsWith(InteMinBil4.Bounds))
            {
                if (speed1>speed4)
                {
                    speed1 = speed4;
                }
                if (speed4>speed1)
                {
                    speed4 = speed1;
                }
                else
                {
                    speed1 = speed4;
                }
            }
            if (InteMinBil1.Bounds.IntersectsWith(InteMinBil5.Bounds))
            {
                if (speed1>speed2)
                {
                    speed1 = speed5;
                }
                if (speed5>speed1)
                {
                    speed5 = speed1;
                }
                else
                {
                    speed1 = speed5;
                }
            }

            if (InteMinBil2.Bounds.IntersectsWith(InteMinBil1.Bounds))
            {
                if (speed2>speed1)
                {
                    speed2 = speed1;
                }
                if (speed1>speed2)
                {
                    speed1 = speed2;
                }
                else
                {
                    speed2 = speed1;
                }
            }
            if (InteMinBil2.Bounds.IntersectsWith(InteMinBil3.Bounds))
            {
                if (speed2>speed3)
                {
                    speed2 = speed3;
                }
                if (speed3>speed2)
                {
                    speed3 = speed2;
                }
                else
                {
                    speed2 = speed3;
                }
            }
            if (InteMinBil2.Bounds.IntersectsWith(InteMinBil4.Bounds))
            {
                if (speed2>speed4)
                {
                    speed2 = speed4;
                }
                if (speed4>speed2)
                {
                    speed4 = speed2;
                }
                else
                {
                    speed2 = speed4;
                }
            }
            if (InteMinBil2.Bounds.IntersectsWith(InteMinBil5.Bounds))
            {
                if (speed2>speed5)
                {
                    speed2 = speed5;
                }
                if (speed5>speed2)
                {
                    speed5 = speed2;
                }
                else
                {
                    speed2 = speed5;
                }
            }

            if (InteMinBil3.Bounds.IntersectsWith(InteMinBil2.Bounds))
            {
                if (speed3>speed2)
                {
                    speed3 = speed2;
                }
                if (speed2>speed3)
                {
                    speed2 = speed3;
                }
                else
                {
                    speed3 = speed2;
                }
            }
            if (InteMinBil3.Bounds.IntersectsWith(InteMinBil1.Bounds))
            {
                if (speed3>speed1)
                {
                    speed3 = speed1;
                }
                if (speed1>speed3)
                {
                    speed1 = speed3;
                }
                else
                {
                    speed3 = speed1;
                }

            }
            if (InteMinBil3.Bounds.IntersectsWith(InteMinBil4.Bounds))
            {
                if (speed3>speed4)
                {
                    speed3 = speed4;
                }
                if (speed4>speed3)
                {
                    speed4 = speed3;
                }
                else
                {
                    speed3 = speed4;
                }
            }
            if (InteMinBil3.Bounds.IntersectsWith(InteMinBil5.Bounds))
            {
                if (speed3>speed5)
                {
                    speed3 = speed5;
                }
                if (speed5>speed3)
                {
                    speed5 = speed3;
                }
                else
                {
                    speed3 = speed5;
                }
            }

            if (InteMinBil4.Bounds.IntersectsWith(InteMinBil2.Bounds))
            {
                if (speed4>speed2)
                {
                    speed4 = speed2;
                }
                if (speed2>speed4)
                {
                    speed2 = speed4;
                }
                else
                {
                    speed4 = speed2;
                }
            }
            if (InteMinBil4.Bounds.IntersectsWith(InteMinBil3.Bounds))
            {
                if (speed4>speed3)
                {
                    speed4 = speed3;
                }
                if (speed2>speed4)
                {
                    speed3 = speed4;
                }
                else
                {
                    speed4 = speed3;
                }
            }
            if (InteMinBil4.Bounds.IntersectsWith(InteMinBil1.Bounds))
            {
                if (speed4>speed1)
                {
                    speed4 = speed1;
                }
                if (speed1>speed4)
                {
                    speed1 = speed4;
                }
                else
                {
                    speed4 = speed1;
                }
            }
            if (InteMinBil4.Bounds.IntersectsWith(InteMinBil5.Bounds))
            {
                if (speed4>speed5)
                {
                    speed4 = speed5;
                }
                if (speed5>speed4)
                {
                    speed5 = speed4;
                }
                else
                {
                    speed4 = speed5;
                }
            }

            if (InteMinBil5.Bounds.IntersectsWith(InteMinBil2.Bounds))
            {
                if (speed5>speed2)
                {
                    speed5 = speed2;
                }
                if (speed2>speed5)
                {
                    speed2 = speed5;
                }
                else
                {
                    speed5 = speed2;
                }
            }
            if (InteMinBil5.Bounds.IntersectsWith(InteMinBil3.Bounds))
            {
                if (speed5>speed3)
                {
                    speed5 = speed3;
                }
                if (speed3>speed5)
                {
                    speed3 = speed5;
                }
                else
                {
                    speed5 = speed3;
                }

            }
            if (InteMinBil5.Bounds.IntersectsWith(InteMinBil4.Bounds))
            {
                if (speed5>speed4)
                {
                    speed5 = speed4;
                }
                if (speed4>speed5)
                {
                    speed4 = speed5;
                }
                else
                {
                    speed5 = speed4;
                }
            }
            if (InteMinBil5.Bounds.IntersectsWith(InteMinBil1.Bounds))
            {
                if (speed5>speed1)
                {
                    speed5 = speed1;
                }
                if (speed1>speed5)
                {
                    speed1 = speed5;
                }
                else
                {
                    speed5 = speed1;
                }
            }







            label1.Text = points.ToString();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.Left)
            {
                rörelse = 100;
            }
            if (e.KeyCode == Keys.Right)
            {
                rörelse = 200;
            }

        }
        public void Highscore()
        {

            string HighS = System.IO.File.ReadAllText(@"C:\Users\felix\source\repos\GA\GA\highscore.txt");
            System.Console.WriteLine(HighS);
            int HighSc = int.Parse(HighS);
            label5.Text = HighSc.ToString();

            if (points>HighSc)
            {

                HighSc = points;
                label5.Text = HighSc.ToString();

                System.IO.File.Delete(@"C:\Users\felix\source\repos\GA\GA\highscore.txt");
                MessageBox.Show(HighSc.ToString());
                System.IO.File.WriteAllText(@"C:\Users\felix\source\repos\GA\GA\highscore.txt", HighSc.ToString());
            }
            //else
            //{
            //     MessageBox.Show("NOOB");
            //  }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MinBil.Left = 300;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MinBil.Left = 400;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MinBil.Left = 500;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
