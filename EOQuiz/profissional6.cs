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
    public partial class profissional6 : Form
    {
        public profissional6()
        {
            InitializeComponent();
        }
         public profissional6(string core)
        {
            
            InitializeComponent();
            label1.Text = core;
            if (label1.Text == "1")
            { core1.Visible = false; }
                if (label1.Text == "2")
                { core2.Visible = false; core1.Visible = false; pictureBox2.Visible = true; }
                if (label1.Text == "3")
                { core2.Visible = false; core1.Visible = false;  }

        }

        private void profissional6_Load(object sender, EventArgs e)
        {

        }

        private void certa_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            certa.Image = Properties.Resources.goghr;
            certa.Enabled = false;
            if (core2.Visible == true)
            {
                if (core1.Visible == true)
                { core1.Visible = false; }
                else
                { core2.Visible = false; }
            }
            else if (core1.Visible == false && core2.Visible == false)
            { core3.Visible = false; }
            if (core3.Visible == false)
            {
                this.Hide();
                Form6 fon = new Form6(label2.Text);
                fon.ShowDialog();
                this.Close();
            }
            if (core1.Visible == false)
            { label1.Text = "1"; }
            if (core2.Visible == false)
            { label1.Text = "2"; }
        }

        private void erro5_Click(object sender, EventArgs e)
        {
            this.Hide();
            profissional7 fon = new profissional7(label1.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void erro9_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            erro9.Image = Properties.Resources.monetr;
           erro9.Enabled = false;
            if (core2.Visible == true)
            {
                if (core1.Visible == true)
                { core1.Visible = false; }
                else
                { core2.Visible = false; }
            }
            else if (core1.Visible == false && core2.Visible == false)
            { core3.Visible = false; }
            if (core3.Visible == false)
            {
                this.Hide();
                Form6 fon = new Form6(label2.Text);
                fon.ShowDialog();
                this.Close();
            }
            if (core1.Visible == false)
            { label1.Text = "1"; }
            if (core2.Visible == false)
            { label1.Text = "2"; }
        }

        private void erroq_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            erroq.Image = Properties.Resources.picar;
            erroq.Enabled = false;
            if (core2.Visible == true)
            {
                if (core1.Visible == true)
                { core1.Visible = false; }
                else
                { core2.Visible = false; }
            }
            else if (core1.Visible == false && core2.Visible == false)
            { core3.Visible = false; }
            if (core3.Visible == false)
            {
                this.Hide();
                Form6 fon = new Form6(label2.Text);
                fon.ShowDialog();
                this.Close();
            }
            if (core1.Visible == false)
            { label1.Text = "1"; }
            if (core2.Visible == false)
            { label1.Text = "2"; }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 fon = new Form11();
            fon.ShowDialog();
            this.Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 80)
            { pictureBox2.Visible = false; }
        }
    }
}
