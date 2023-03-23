using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes1
{
    public partial class F_ListBox : Form
    {
        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }
        private void atualizaLB(ListBox lb, List<string>l)
        {
            lb_carros.DataSource = null;
            lb.DataSource = l;
        }

        private void F_ListBox_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro!");
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                tb_carro.Focus();
                atualizaLB(lb_carros, carros);
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            carros.RemoveAt(lb_carros.SelectedIndex);
            atualizaLB(lb_carros, carros);
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_carro.Text = carros[lb_carros.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carros.Clear();
            atualizaLB(lb_carros, carros);
        }
    }
}
