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
    public partial class Bradley : Form
    {
        public Bradley()
        {
            InitializeComponent();
            textBox1.Text = "Hello world";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Bradley_Load(object sender, EventArgs e)
        {

        }
    }
}
