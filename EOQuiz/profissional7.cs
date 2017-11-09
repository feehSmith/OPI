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
    public partial class profissional7 : Form
    {
        public profissional7()
        {
            InitializeComponent();
        }
         public profissional7(string core)
        {
            
            InitializeComponent();
            label1.Text = core;
            if (label1.Text == "1")
            { core1.Visible = false; }
            if (label1.Text == "2")
            { core2.Visible = false; core1.Visible = false; }
            if (label1.Text == "3")
            { core2.Visible = false; core1.Visible = false; }
        }
        private void profissional7_Load(object sender, EventArgs e)
        {

        }

        private void und_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            und.Image = Properties.Resources.mair;
            und.Enabled = false;
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

        private void cry_Click(object sender, EventArgs e)
        {
            this.Hide();
            profissional8 fon = new profissional8(label1.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void play_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            play.Image = Properties.Resources.folr;
            play.Enabled = false;
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

        private void get_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            get.Image = Properties.Resources.quacr;
            get.Enabled = false;
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
    }
}
