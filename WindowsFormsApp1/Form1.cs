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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roland classs = new Roland();
            classs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bradley class = new Bradley();
            class.show
        }
    }
}
