using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparkleRNG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected Random prng = new Random();
        protected int secs = 3;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (secs > 0)
                secs--;
            else
                secs = 3;

            lblTimer.Text = $"Next Number In {secs} seconds";
        }

        private void timerRNG_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            lblEkran.Text = prng.Next().ToString();
            timer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
