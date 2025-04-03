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
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            configurarDataGrid();//configuro a estrutura da coluna e linha
            nomeColunas(); //nomeando as colunas
            adicionarDados(); //adicionando os dados
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fim do voltar

        public void nomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Endereço";
        }//fim do nomeColunas

        public void configurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false; //Não pode add linhas
            dataGridView1.AllowUserToDeleteRows = false; //Não pode apagar linhas
            dataGridView1.AllowUserToResizeColumns = false; //Não pode redimensionar colunas
            dataGridView1.AllowUserToResizeRows = false; //Não pode redimensionar linhas

            dataGridView1.ColumnCount = 4;
        }//fim do método configurar

        public void adicionarDados()
        {
            consul.PreencherVetor(); //Preencher os vetores c/ dados do bd
            for(int i=0; i < consul.quantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.codigo[i], consul.nome[i], consul.telefone[i], consul.endereco[i]);
            }//fim do for
        }//fim do adicionar dados


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do dataGridView
    }//fim da classe
}//fim do projeto
