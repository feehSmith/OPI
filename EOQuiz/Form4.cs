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
    public partial class Form4 : Form
    {
        public Form4()
        {
            System.Media.SoundPlayer grr = new System.Media.SoundPlayer();
            grr.PlayLooping();
            InitializeComponent();
        }
        public Form4(string chave)
        {

            InitializeComponent();
            label2.Text = chave;
            label3.Text = chave;
            if (label2.Text == "1")
            { pictureBox9.Visible = true; pictureBox7.Enabled = true; }
            if (label2.Text == "2")
            {
                pictureBox7.Enabled = true;
                pictureBox7.Image = Properties.Resources.cadeadoa;
            }
            if (label3.Text == "5")
            { pictureBox7.Image = Properties.Resources.cadeadoa; }
            if (label2.Text == "8")
            { pictureBox12.Visible = true; pictureBox8.Enabled = true; pictureBox7.Image = Properties.Resources.cadeadoa; }
            if (label2.Text == "00")
            {
                pictureBox8.Image = Properties.Resources.cadeadoa; pictureBox12.Visible = false; label2.Text = "0";
                pictureBox7.Image = Properties.Resources.cadeadoa;
            }
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fon = new Form1();
            fon.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://fon-entertainment.000webhostapp.com/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            iniciante1 fon = new iniciante1();
            fon.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "2" || label3.Text == "5" || label2.Text == "0")
            {
                this.Hide();
                amador1 ata = new amador1();
                ata.ShowDialog();
                this.Close();
            }

            else
            {
                System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/pa.wav");
                Player.Play();
                MessageBox.Show("Sinto muito, mas essa dificuldade ainda não esta disponível.", label1.Text, MessageBoxButtons.OK);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                this.Hide();
                profissional1 ata = new profissional1();
                ata.ShowDialog();
                this.Close();
            }
            else
            {
                System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/pa.wav");
                Player.Play();
                MessageBox.Show("Sinto muito, mas essa dificuldade ainda não esta disponível.", label1.Text, MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.cadeadoa;
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/som.wav");
            Player.Play();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Visible == true)
            {
                pictureBox7.Enabled = false;
                pictureBox7.Image = Properties.Resources.cadeadoa; pictureBox9.Visible = false; label2.Text = "2";
                System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/som.wav");
                Player.Play();
                pictureBox7.Enabled = false;
                label2.Text = "2";
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            pictureBox11.Visible = true;
            System.Media.SoundPlayer fon = new System.Media.SoundPlayer();
            fon.Stop();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            pictureBox10.Visible = true;
            System.Media.SoundPlayer fon = new System.Media.SoundPlayer("som/lucky.wav");
            fon.PlayLooping();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Visible == true)
            {
                pictureBox8.Enabled = false;
                pictureBox8.Image = Properties.Resources.cadeadoa; pictureBox12.Visible = false; label2.Text = "0";
                System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/som.wav");
                Player.Play();
                pictureBox8.Enabled = false;
                label2.Text = "0";
            }
        }
    }
}
