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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/lucky.wav"); 
            Player.PlayLooping();
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fon = new Form2();
            fon.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            tutorial2 fon = new tutorial2();
            fon.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fon = new Form4();
            fon.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fon-entertainment.000webhostapp.com/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
            System.Media.SoundPlayer fon = new System.Media.SoundPlayer();
            fon.Stop();
           
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
            System.Media.SoundPlayer fon = new System.Media.SoundPlayer("som/lucky.wav");
            fon.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            
           
            System.Media.SoundPlayer fon = new System.Media.SoundPlayer();
            fon.Stop();
            System.Media.SoundPlayer que = new System.Media.SoundPlayer("som/que.wav");
            que.Play();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            
            if (pictureBox8.Visible == true)
            {
                System.Media.SoundPlayer fon = new System.Media.SoundPlayer("som/lucky.wav");
                fon.Stop();
            }
            else
            {
                System.Media.SoundPlayer fon = new System.Media.SoundPlayer("som/lucky.wav");
                fon.Play();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            

            System.Media.SoundPlayer fon = new System.Media.SoundPlayer();
            fon.Stop();
            System.Media.SoundPlayer que = new System.Media.SoundPlayer("som/fon.wav");
            que.Play();
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
           
            if (pictureBox8.Visible == true)
            {
                System.Media.SoundPlayer fon = new System.Media.SoundPlayer("som/lucky.wav");
                fon.Stop();
            }
            else
            {
                System.Media.SoundPlayer fon = new System.Media.SoundPlayer("som/lucky.wav");
                fon.Play();
            }
        }
    }
}
