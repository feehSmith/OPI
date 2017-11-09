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
    public partial class final : Form
    {
        public final()
        {
            InitializeComponent();
            System.Media.SoundPlayer Player = new System.Media.SoundPlayer("som/final.wav");
            Player.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fon = new Form1();
            fon.ShowDialog();
            this.Close();
        }
    }
}
