using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOQuiz
{
    public partial class tutorial2 : Form
    {
        public tutorial2()
        {
            InitializeComponent();
        }
        private int counter;
        private void tutorial2_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/tutorial.wav");
            Player.PlayLooping();
            counter = 0;
            timer1.Interval = 600;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             if (counter == 36)
             {
                 pictureBox18.Visible = true;
                label1.Visible = true;
                 pictureBox3.Visible = true;
                 pictureBox5.Visible = false;
                 pictureBox4.Visible = true;
                 pictureBox2.Visible = true;
                 pictureBox1.Image = Properties.Resources.fundopreto;
             }
             else
             {
                 
                 counter = counter + 1;
                 
             }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fon = new Form4();
            fon.ShowDialog();
            this.Close();
        }

     

     
    }
}
