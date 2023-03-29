using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes1
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((int.Parse(textBox1.Text) >= progressBar1.Minimum) & (int.Parse(textBox1.Text) <= progressBar1.Maximum)) ;

                progressBar1.Value = int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = int.Parse(textBox2.Text);
            for (int i = 0; i <= progressBar1.Maximum; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i;

            }
            //Thread.Sleep(200);
        }
    }
}
