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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            label2.Visible = true;
            pictureBox9.Visible = true;
            pictureBox13.Visible = true;


        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            pictureBox9.Visible = false;
            pictureBox13.Visible = false;
            label3.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            label4.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible =false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 fon = new Form4();
            fon.ShowDialog();
            this.Close();
        }
    }
}
