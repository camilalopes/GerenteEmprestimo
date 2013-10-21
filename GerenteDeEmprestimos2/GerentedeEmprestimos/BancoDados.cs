using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Dao
{
    class BancoDados
    {
        private static MySqlConnection conexao;
        public static readonly string BANCO = "gerente";

        public static MySqlConnection recuperarConexao()
        {
            if (conexao == null)
            {
                // Parâmetros de conexão.
                string servidor = "127.0.0.1";
                string banco = BANCO;
                string usuario = "root";
                string senha = "cabanbina";

                // String de conexão.
                string strConexao = "SERVER=" + servidor
                    + ";DATABASE=" + banco
                    + ";UID=" + usuario
                    + ";PASSWORD=" + senha
                    + ";";

                // Objeto responvável pela conexão efetiva.
                conexao = new MySqlConnection(strConexao);

                // Tentativa (try) de estabelecimento de conexão.
                try
                {
                    conexao.Open();
                }

                // Captura (catch) de exceções (falhas).
                catch (MySqlException ex)
                {
                    // Informa a razão do erro na conexão, caso exista.
                    Console.WriteLine("Falha ao estabelecer uma conexão com o servidor.\n" + ex);
                }

            }


            return conexao;

        }

    }
}
