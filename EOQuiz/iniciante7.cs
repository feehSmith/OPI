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
    public partial class iniciante7 : Form
    {
        public iniciante7()
        {
            InitializeComponent();
        }
        public iniciante7(string core)
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
        private void iniciante7_Load(object sender, EventArgs e)
        {

        }

        private void uva_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            uva.Image = Properties.Resources.uvaf;
            uva.Enabled = false;
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
                Form6 fon = new Form6();
                fon.ShowDialog();
                this.Close();
            }
            if (core1.Visible == false)
            { label1.Text = "1"; }
            if (core2.Visible == false)
            { label1.Text = "2"; }
        }

        private void banana_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
           banana.Image = Properties.Resources.bananaf;
            banana.Enabled = false;
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
                Form6 fon = new Form6();
                fon.ShowDialog();
                this.Close();
            }
            if (core1.Visible == false)
            { label1.Text = "1"; }
            if (core2.Visible == false)
            { label1.Text = "2"; }
        }

        private void abacaxi_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            abacaxi.Image = Properties.Resources.abacaxif;
            abacaxi.Enabled = false;
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
                Form6 fon = new Form6();
                fon.ShowDialog();
                this.Close();
            }
            if (core1.Visible == false)
            { label1.Text = "1"; }
            if (core2.Visible == false)
            { label1.Text = "2"; }
        }

        private void hol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form14 fon = new Form14(label1.Text);
            fon.ShowDialog();
            this.Close();
        }
    }
}
