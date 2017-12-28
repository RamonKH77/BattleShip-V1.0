using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BattleshipDemo.Coordinates;

namespace BattleshipDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Coordinates CC = new Coordinates();
        int ClickCount = 0;
        int TimeCount = 120;
        public bool TimerBool { get; set; }


        private void Form2_Load(object sender, EventArgs e)
        {
            //var elem = new Coordinates();

            
            for (int Y = 0; Y < 10; Y++)
            {
                for (int X = 0; X < 10; X++)
                {
                    Button BtnNew = new Button();
                    BtnNew.Height = 40;
                    BtnNew.Width = 40;

                    BtnNew.Location = new Point(40 * Y + 40, 40 * X + 40);
                    BtnNew.Tag = X + "" + Y;
                    string tag = BtnNew.Tag.ToString();
                    BtnNew.Click += new EventHandler(this.button_Click);//adds button_click method to click
                    int tagInt = int.Parse(BtnNew.Tag.ToString());


                    this.Controls.Add(BtnNew);
                }

            }
            bool CheckForm1 = TimerBool;
            if (CheckForm1 == true)
            {
                timer1.Enabled = true;
            }

        }




        void button_Click(object sender, System.EventArgs e)
        {
            Button b = sender as Button;
            ClickCount++;
            if (ClickCount <= 30)
            {
                string tagDesc = b.Tag.ToString();
                int ButtonX = int.Parse(tagDesc);
                List<int> Mylist = CC.GetList();
                if (Mylist.Contains(ButtonX) == true)
                {
                    b.Text = "X";
                    Score.Text = "Score: " + ClickCount * 50;
                    b.ForeColor = Color.Red;
                    b.Font = new Font("Arial", 24);


                }
                else
                {
                    b.Text = "X";
                    b.ForeColor = Color.Aqua;
                    b.Font = new Font("Arial", 24);
                }
            }
            else
            {
                MessageBox.Show("Game Over. Your " + Score.Text);
                timer1.Enabled = false;
            }



        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
            
        }

        private void changeUsernameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }

        private void playAgainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.ShowDialog();
            this.Close();
        }

        private void timeRunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeCount == 0)
            {
                MessageBox.Show("Game Over. Your " + Score.Text);
            }
            else TimeCount--;
            TimerL.Text = "Timer: Last: " + TimeCount + " second(s)";
        }
    }
}