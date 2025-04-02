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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DAO conexao = new DAO();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }//fim do form load

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();
            cad.ShowDialog();
        }//fim do cadastrar

        private void button3_Click(object sender, EventArgs e)
        {
            Atualizar att = new Atualizar();
            att.ShowDialog();
        }//fim do atualizar

        private void button4_Click(object sender, EventArgs e)
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
        }//fim do excluir

        private void button2_Click(object sender, EventArgs e)
        {
            Consultar cons =  new Consultar();
            cons.ShowDialog();
        }//fim do consultar
    }//fom da classe
}//fim do projeto
