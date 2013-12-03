using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Entidade;
using System.Collections;
using System.Windows.Forms;

namespace Dao
{
    class EmprestimoDao
    {
        public static readonly string TABELA = "emprestimo";

        public static void salvarEmprestimo(Emprestimo emprestimo)
        {
            MySqlCommand cmd;
            string sql;

            if (emprestimo.Id == 0)
            {
                sql = "INSERT INTO " + TABELA + " VALUES (default, @dataemprestimo, @entregue, @fk_destinatario, @fk_item);";


                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql, BancoDados.recuperarConexao());


                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@dataemprestimo", emprestimo.DataEmprestimo);
                cmd.Parameters.AddWithValue("@entregue", emprestimo.Entregue);
                cmd.Parameters.AddWithValue("@fk_destinatario", emprestimo.FkDestinatario);
                cmd.Parameters.AddWithValue("@fk_item", emprestimo.FkItem);

    
            }
           else
            {
                sql = "UPDATE " + TABELA
                   + " SET entregue = @entregue"
                   + " WHERE id=@id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@entregue",
                    emprestimo.Entregue);
                cmd.Parameters.AddWithValue("@id",
                    emprestimo.Id);
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();


        }
        public static ArrayList buscarEmprestimo(Emprestimo emprestimo)
        {
            ArrayList emprestimos = new ArrayList();

            MySqlCommand cmd;
            string sql = "SELECT * FROM " + TABELA + ";";


            // Associação do comando à conexão.
            cmd = new MySqlCommand(sql, BancoDados.recuperarConexao());

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL, com dados de retorno
            // associados a um objeto para posterior leitura.
            MySqlDataReader leitor = cmd.ExecuteReader();


            while (leitor.Read())
            {
                emprestimos.Add(
                    new Emprestimo(int.Parse(leitor["id"].ToString()), DateTime.Parse(leitor["dataemprestimo"].ToString()),
                        bool.Parse(leitor["entregue"].ToString()),int.Parse(leitor["fk_destinatario"].ToString()), int.Parse(leitor["fk_item"].ToString())));
            }
            // Libera recursos de memória.
            leitor.Close();


            return emprestimos;

        }

        public static Emprestimo buscarPorId(Emprestimo emprestimo)
        {
            Emprestimo resposta = null;

            if (emprestimo.Id != 0)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE id = @id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    emprestimo.Id);

                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    
                    resposta = new Emprestimo(int.Parse(leitor["id"].ToString()), DateTime.Parse(leitor["dataemprestimo"].ToString()),
                        bool.Parse(leitor["entregue"].ToString()),int.Parse(leitor["fk_destinatario"].ToString()), int.Parse(leitor["fk_item"].ToString()));

                    
                }
                leitor.Close();
            }

            return resposta;

        }

        public static ArrayList buscarPendentes(EmprestimoAuxiliar eAux)
        {
            ArrayList emprestimosAux = new ArrayList();

            MySqlCommand cmd;

            string sql = "SELECT e.id, d.nome AS nome, e.dataemprestimo as dataemprestimo,"
                    + "e.entregue as entregue, i.descricao as descricao"
                    + " FROM destinatario d inner join emprestimo e on d.id = e.fk_destinatario"
                    + " inner join item i on i.id = e.fk_item"
                    + " WHERE entregue = false;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                cmd.Prepare();

            // Execução da sentença SQL, com dados de retorno
           // associados a um objeto para posterior leitura.
           MySqlDataReader leitor = cmd.ExecuteReader();

            while (leitor.Read())
            {

                emprestimosAux.Add(new EmprestimoAuxiliar(int.Parse(leitor["id"].ToString()),
                leitor["nome"].ToString(), DateTime.Parse(leitor["dataemprestimo"].ToString()),
                bool.Parse(leitor["entregue"].ToString()), leitor["descricao"].ToString()));
            }


            leitor.Close();

            return emprestimosAux;
            
        }


        public static ArrayList buscarEmprestimoAux(EmprestimoAuxiliar eAux)
        {
            ArrayList emprestimosAux = null;

            if (eAux.Destinatario != null)
            {
                emprestimosAux = new ArrayList();

                MySqlCommand cmd;
                string sql = "select e.id, d.nome as nome, e.dataemprestimo as dataemprestimo, e.entregue as entregue, i.descricao as descricao "
                + "from destinatario d inner join emprestimo e on d.id = e.fk_destinatario inner join item i on i.id =e.fk_item;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql, BancoDados.recuperarConexao());

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    emprestimosAux.Add(
                        new EmprestimoAuxiliar(int.Parse(leitor["id"].ToString()),
                            leitor["nome"].ToString(),
                            DateTime.Parse(leitor["dataemprestimo"].ToString()),
                            bool.Parse(leitor["entregue"].ToString()),
                            leitor["descricao"].ToString()));
                }

                // Libera recursos de memória.
                leitor.Close();
            }


            return emprestimosAux;

        }

    }
}
