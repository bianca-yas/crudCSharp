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
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            atu = new DAO();
            InitializeComponent();
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa código

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa nome

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa telefone

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa endereço

        private void atua_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            atu.Atualizar(codigo, "nome", nome);
            atu.Atualizar(codigo, "telefone", telefone);
            atu.Atualizar(codigo, "endereco", endereco);
            MessageBox.Show("Dados atualizados com sucesso!");

            this.Close();
        }//fim da botao atualizar

        private void buscar_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                textBox2.Text = "Informe o código";
                textBox3.Text = "Informe o código";
                textBox4.Text = "Informe o código";
            }
            else
            {
                int codigo = Convert.ToInt32(textBox1.Text);

                textBox2.Text = atu.retornarNome(codigo); //Preenchendo o campo nome
                textBox3.Text = atu.retornarTelefone(codigo); //Preenchendo o campo telefone
                textBox4.Text = atu.retornarEndereco(codigo); //Preenchendo o campo endereço

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
            }
            
        }//fim do botao buscar
    }//fim da classe
}//fim do projeto
