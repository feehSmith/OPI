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
    public partial class amador1 : Form
    {
        public amador1()
        {
            InitializeComponent();
        }

        private void arg_Click(object sender, EventArgs e)
        {   
            System.Media.SoundPlayer Player2 = new System.Media.SoundPlayer("som/errou.wav");
            Player2.Play();
            arg.Image = Properties.Resources.argentinaf;
            arg.Enabled = false;
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

        private void certa_Click(object sender, EventArgs e)
        {
   

            if (core1.Visible == false)
            {
                this.Hide();
                amador2 fon = new amador2(label1.Text);
                fon.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                amador2 fon = new amador2(label2.Text);
                fon.ShowDialog();
                this.Close();
            }
        }

        private void br_Click(object sender, EventArgs e)
        {

            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play(); 
            br.Image = Properties.Resources.brasilf;
            br.Enabled = false;
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

        private void hol_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/errou.wav");
            Player.Play();
            hol.Image = Properties.Resources.holandaf;
            hol.Enabled = false;
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void amador1_Load(object sender, EventArgs e)
        {

        }
    }
}
