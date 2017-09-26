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

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int a1, a2, result;
            a1 = int.Parse(txtFirst.Text);
            a2 = int.Parse(txtSecond.Text);

            BradClass answer = new BradClass();
            txtResult.Text = answer.add(a1,a2)+"";

        }
    }
}
