using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTask
{
    public partial class Form1 : Form
    {
        Timer Timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            Timer.Tick += Timer_Tick;
            Timer.Interval = 500;
            Timer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._49e9a026fa1aceaf5988c572a8f3f7fd;
            Timer.Tick += Timer_Tick;
            Timer.Interval = 500;
            Timer.Start();
 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Label.Text = DateTime.Now.ToLongTimeString();
        }
        private void Timer_TickForLondon(object sender, EventArgs e)
        {
            Label.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }

        private void LondonBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.london;
            var datetimeforLondon = DateTime.Now.AddHours(4).ToLongTimeString();
            Timer.Tick += Timer_TickForLondon;
            Timer.Interval = 500;
            Timer.Start();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
