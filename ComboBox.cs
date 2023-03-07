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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Navio");
            cb_transportes.Items.Add("Avião");
            cb_transportes.Items.Add("Ônibus");
            cb_transportes.Items.Add("Trem");
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_transporte.Text != "")
            {
                if (cb_transportes.FindString(tb_transporte.Text) < 0) ;
                cb_transportes.Items.Add(tb_transporte.Text);
                tb_transporte.Clear();
                tb_transporte.Focus();
            }
        }
    }
}
