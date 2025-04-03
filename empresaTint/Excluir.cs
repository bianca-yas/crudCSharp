using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empresaTint
{
    public partial class Excluir : Form
    {

        DAO exc;
        public Excluir()
        {
            exc = new DAO();
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de código

        private void exclu_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();
        }//fim do botao excluir
    }
}
