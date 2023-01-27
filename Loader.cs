using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Loader : Form
    {
        public Loader()
        {


            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Loader_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Form1 main = new Form1();
            main.Show();
            this.Hide();
            timer1.Stop();
        }
    }
}
