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
    public partial class extra : Form
    {
        public extra()
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/tempo.wav");
            Player.PlayLooping();
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
                if (progressBar1.Value == 100)
                {
                    
                    label4.Visible = true;
                    pictureBox1.Visible = false;
                    pictureBox3.Visible = true;
                    erro1.Visible = false;
                    erro2.Visible = false;
                    erro3.Visible = false;
                    certa.Visible = false;
                    label3.Text = "3";
                    timer1.Stop();
                    System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/tempo.wav");
                    Player.Stop();
                    System.Media.SoundPlayer que = new System.Media.SoundPlayer("som/fail.wav");
                    que.Play();
                    
                }
        }

        private void certa_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            erro1.Visible = false;
            erro2.Visible = false;
            erro3.Visible = false;
            certa.Visible = false;
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/tempo.wav");
            Player.Stop();
             label3.Text = "1";
             timer1.Stop();
        }

        private void erro1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer quo = new System.Media.SoundPlayer("som/errou.wav");
            quo.Play();
            label1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
            erro1.Visible = false;
            erro2.Visible = false;
            erro3.Visible = false;
            certa.Visible = false;
            label3.Text = "3";
            timer1.Stop();

        }

        private void erro2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer quo = new System.Media.SoundPlayer("som/errou.wav");
           quo.Play();
            label1.Visible = true;
            pictureBox3.Visible = true;
            erro1.Visible = false;
            erro2.Visible = false;
            pictureBox1.Visible = false;
            erro3.Visible = false;
            certa.Visible = false;
            label3.Text = "3";
            timer1.Stop();
        }

        private void erro3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer quo = new System.Media.SoundPlayer("som/errou.wav");
            quo.Play();
            label1.Visible = true;
            pictureBox3.Visible = true;
            erro1.Visible = false;
            pictureBox1.Visible = false;
            erro2.Visible = false;
            erro3.Visible = false;
            certa.Visible = false;
            label3.Text = "3";
            timer1.Stop();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            profissional6 fon = new profissional6(label3.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
            this.Hide();
           profissional6 fon = new profissional6(label3.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
