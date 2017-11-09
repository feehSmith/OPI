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
    public partial class profissional1 : Form
    {
        public profissional1()
        {
            InitializeComponent();
        }
         public profissional1(string core)
        {
            
            InitializeComponent();
            label1.Text = core;
            if (label1.Text == "1")
            { core1.Visible = false; }
            if (label1.Text == "2")
            { core2.Visible = false; core1.Visible = false; }
        }

        private void cry_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            cry.Image = Properties.Resources.cryr;
            cry.Enabled = false;
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
       


        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
            

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            profissional2 fon = new profissional2(label1.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void amador10_Load(object sender, EventArgs e)
        {

        }

        private void und_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            und.Image = Properties.Resources.undr;
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
                if (core1.Visible == false)
                { label1.Text = "1"; }
                if (core2.Visible == false)
                { label1.Text = "2"; }
            }
        }

        private void play_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            play.Image = Properties.Resources.playr;
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

        private void get_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            get.Image = Properties.Resources.getr;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            
            
        }

        
    }
}
    

