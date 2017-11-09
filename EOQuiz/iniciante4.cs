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
    public partial class iniciante4 : Form
    {
        public iniciante4()
        {
            InitializeComponent();
        }

        public iniciante4(string core)
        {
            
            InitializeComponent();
            label1.Text = core;
            if (label1.Text == "1")
            { core1.Visible = false; }
            if (label1.Text == "2")
            { core2.Visible = false; core1.Visible = false; }
            if (label1.Text == "3")
            { core2.Visible = false; core1.Visible = false; }
            if (label1.Text == "5")
            {  core1.Visible = false; }
        }
        private void corrida_Click(object sender, EventArgs e)
        {
            this.Hide();
                iniciante5 fon = new iniciante5(label1.Text);
            fon.ShowDialog();
            this.Close();
        }

        private void basq_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            basq.Image = Properties.Resources.basquetef;
            basq.Enabled = false;
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

        private void fut_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            fut.Image = Properties.Resources.futebolf;
            fut.Enabled = false;
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

        private void golf_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            golf.Image = Properties.Resources.golff;
            golf.Enabled = false;
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
    }
}
