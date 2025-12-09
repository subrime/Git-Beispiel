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
    }
}
