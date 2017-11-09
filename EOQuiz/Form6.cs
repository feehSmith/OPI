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
    public partial class Form6 : Form
    {
        public Form6()
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/qua.wav");
            Player.Play();
            InitializeComponent();
        }
        public Form6(string fon)
        {
            InitializeComponent();
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/qua.wav");
            Player.Play();
            label1.Text = fon;
            if (label1.Text == "5")
            { 
                pictureBox4.Visible = true;
                pictureBox2.Visible = false;
             
            }
            if (label1.Text == "7")
            { pictureBox5.Visible = true;
            pictureBox2.Visible = false;
            }
        }
       
        
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form4 fon = new Form4();
                fon.ShowDialog();
                this.Close();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form1 fon = new Form1();
                fon.ShowDialog();
                this.Close();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fon = new Form4(label1.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fon = new Form4(label2.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
