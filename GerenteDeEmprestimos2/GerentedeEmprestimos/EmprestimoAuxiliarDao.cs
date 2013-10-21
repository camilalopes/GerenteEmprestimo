using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using MySql.Data.MySqlClient;
using Dao;
using System.Collections;

namespace GerentedeEmprestimos
{
    class EmprestimoAuxiliarDao
    {
        public static readonly string TABELA = "emprestimoAuxiliar";

        public static void salvar(EmprestimoAuxiliar eAux)
        {
            MySqlCommand cmd;
            string sql;

            if (eAux.Id == 0)
            {
                sql = "INSERT INTO " + TABELA + " VALUES(default, @dataemprestimo, @entregue, @destinatario, @item);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql, BancoDados.recuperarConexao());


                // Inserção de valores nos parâmetros.            
                cmd.Parameters.AddWithValue("@dataemprestimo", eAux.DataEmprestimo);
                cmd.Parameters.AddWithValue("@entregue", eAux.Entregue);
                cmd.Parameters.AddWithValue("@destinatario", eAux.Destinatario);
                cmd.Parameters.AddWithValue("@item", eAux.Item);

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
                    eAux.Entregue);
                cmd.Parameters.AddWithValue("@id",
                    eAux.Id);
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();
        }

        public static ArrayList buscarEmprestimoAux(EmprestimoAuxiliar eAux)
        {
            ArrayList emprestimosAux = new ArrayList();

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
                emprestimosAux.Add(
                    new EmprestimoAuxiliar(int.Parse(leitor["id"].ToString()), DateTime.Parse(leitor["dataemprestimo"].ToString()),
                        bool.Parse(leitor["entregue"].ToString()),leitor["destinatario"].ToString(),leitor["item"].ToString()));
            }
            // Libera recursos de memória.
            leitor.Close();


            return emprestimosAux;

        }

        public static EmprestimoAuxiliar buscarPorId(EmprestimoAuxiliar eAux)
        {
            EmprestimoAuxiliar resposta = null;

            if (eAux.Id != 0)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE id = @id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    eAux.Id);

                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {

                    resposta = new EmprestimoAuxiliar(int.Parse(leitor["id"].ToString()), DateTime.Parse(leitor["dataemprestimo"].ToString()),
                        bool.Parse(leitor["entregue"].ToString()), leitor["destinatario"].ToString(), leitor["item"].ToString());

                    leitor.Close();
                }

            }

            return resposta;

        }
    }
}
