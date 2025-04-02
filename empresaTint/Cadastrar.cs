using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace empresaTint
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

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

        private void cadas_Click(object sender, EventArgs e)
        {
            //instaciando a classe dao
            DAO inserir = new DAO();
            //coletando os dados nos campos
            int codigo = Convert.ToInt32(textBox1.Text);
            string nome = textBox2.Text;
            string telefone = textBox3.Text;
            string endereco = textBox4.Text;

            //chamando o método inserir
            MessageBox.Show(inserir.Inserir(codigo,nome,telefone,endereco));
            this.Close();//fechar a janela cadastrar
        }//fim do botao cadastrar
    }//fim da classe
}//fim do projeto
