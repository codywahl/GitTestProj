using System;
using System.Windows.Forms;

namespace GitTestProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I've made my first change set!");
        }
    }
}
