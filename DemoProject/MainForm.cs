using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        public int counter = 0;
        public MainForm()
        {
            InitializeComponent();
            lblCounter.Text = counter.ToString();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void btnCounter_Click(object sender, EventArgs e)
        {
            counter++;
            lblCounter.Text = counter.ToString();
        }
        
        private void ColorChangeBtn_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            ColorChangeBtn.BackColor = randomColor;
        }
        
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
