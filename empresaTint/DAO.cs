using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace empresaTint
{
    class DAO
    {
        public MySqlConnection conexao;
        public int[] codigo;
        public string[] nome;
        public string[] telefone;
        public string[] endereco;
        public int i;
        public int contador;

        public DAO() 
        { 
            conexao = new MySqlConnection("server=localhost;Database=tintCSharp;Uid=root;password=");
            try
            {
                conexao.Open();
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n\n"+erro);
            }
        }//fim do construtor

        public string Inserir(int codigo,string nome,string telefone,string endereco)
        {
            string inserir = $"Insert into pessoa(codigo,nome,telefone,endereco) values('{codigo}','{nome}','{telefone}','{endereco}')";
            MySqlCommand sql = new MySqlCommand(inserir,conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";

            return resultado;
        }//fim do método inserir

        public void PreencherVetor()
        {
            string query = "select * from pessoa";

            //Instanciar os vetores
            this.codigo   = new int[100];
            this.nome     = new string[100];
            this.telefone = new string[100];
            this.endereco = new string[100];

            //Prepara o comando para o banco
            MySqlCommand sql = new MySqlCommand(query,conexao);

            //Chamar o leitor do banco de dados
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0; //instanciando o contador
            contador = 0;
            while(leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nome[i] = leitura["nome"] + "";
                telefone[i] = leitura["telefone"] + "";
                endereco[i] = leitura["endereco"] + "";
                i++; //faz o contador girar
                contador++; //quantidade de dados que preenchem o vetor

            }//fim do while

            //Encerrar o processo de leitura
            leitura.Close();

        }//fim do método vetor

        public int ConsultarIndividual(int cod)
        {
            
            PreencherVetor(); //Preenchendo o vetor com os dados do banco

            i = 0; //instanciando o contador
            while (i < quantidadeDeDados())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++; //faz o contador girar
            }//fim do while

            //Encerrar o processo de leitura
            return -1;

        }//fim do método vetor

        public string retornarNome(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if(posicao > -1)
            {
                return nome[posicao];
            }
            return "Código digitado não é válido.";
        }//fim do método retornar nome

        public string retornarTelefone(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if (posicao > -1)
            {
                return telefone[posicao];
            }
            return "Código digitado não é válido.";
        }//fim do método retornar telefone

        public string retornarEndereco(int cod)
        {
            int posicao = ConsultarIndividual(cod);
            if (posicao > -1)
            {
                return endereco[posicao];
            }
            return "Código digitado não é válido.";
        }//fim do método retornar endereço

        public int quantidadeDeDados()
        {
            return contador;
        }//fim do método

        public string Atualizar(int codigo, string campo, string dado)
        {
            string query = $"update pessoa set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query,conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";

            return resultado;
        }//fim do atualizar

        public string Excluir(int codigo)
        {
            string query = $"delete from pessoa where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query,conexao);
            string resultado = sql.ExecuteNonQuery() + "Deletado!";

            return resultado;
        }//fim do excluir

    }//fim da classe
}//fim do projeto
