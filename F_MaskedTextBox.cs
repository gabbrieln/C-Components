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
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
            mtb_senha.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_somenteTexto.Checked)
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                maskedTextBox1.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = maskedTextBox1.Text;
            MessageBox.Show(msg);
        }

        private void cb_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarSenha.Checked)
            {
                mtb_senha.UseSystemPasswordChar = false;
            }
            else
            {
                mtb_senha.UseSystemPasswordChar = true;
            }
        }

        private void F_MaskedTextBox_Load(object sender, EventArgs e)
        {

        }

        private void mtb_senha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
