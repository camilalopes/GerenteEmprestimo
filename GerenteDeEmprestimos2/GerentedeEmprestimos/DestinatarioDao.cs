using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entidade;
using MySql.Data.MySqlClient;

namespace Dao
{
    class DestinatarioDao
    {
        public static readonly string TABELA = "destinatario";

        public static void salvarDestinatario(Destinatario destinatario)
        {
            MySqlCommand cmd;
            string sql;


            if (destinatario.GetId() == 0)
            {
                // MUITA ATENÇÃO nos espaçamentos entre comandos.
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @cpf, @nome, @telefone, @email);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@cpf",
                    destinatario.Rg);
                cmd.Parameters.AddWithValue("@nome",
                    destinatario.Nome);
                cmd.Parameters.AddWithValue("@telefone",
                    destinatario.Telefone);
                cmd.Parameters.AddWithValue("@email",
                    destinatario.Email);


            }
            else 
            {
                 sql = "UPDATE " + TABELA
                    + " SET rg = @rg, nome = @nome, telefone = @telefone, email = @email "
                    + " WHERE id=@id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@rg",
                    destinatario.Rg);
                cmd.Parameters.AddWithValue("@nome",
                    destinatario.Nome);
                cmd.Parameters.AddWithValue("@telefone",
                    destinatario.Telefone);
                cmd.Parameters.AddWithValue("@email",
                    destinatario.Email);
                cmd.Parameters.AddWithValue("@id",
                    destinatario.GetId());
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();
        }

        public static ArrayList buscarDestinatario(Destinatario destinatario)
        {
            // Reposta padrão.
            ArrayList destinatarios = null;

       
            if (destinatario.Nome != null)
            {
                // Cria uma coleção vazia.
                destinatarios = new ArrayList();

                MySqlCommand cmd;

               
                string sql = "SELECT * FROM " + TABELA
                    + " WHERE nome LIKE @nome;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    "%" + destinatario.Nome + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

               
                while (leitor.Read())
                {
                    // adiciona o respectivo objeto destinatario, construído
                    // com os dados de retorno, à coleção de destinatario.
                    destinatarios.Add(
                        new Destinatario(int.Parse(leitor["id"].ToString()), leitor["rg"].ToString(),
                            leitor["nome"].ToString(), leitor["telefone"].ToString(), leitor["email"].ToString()));
                }

                // Libera recursos de memória.
                leitor.Close();
            }

            return destinatarios;
        }

        public static Destinatario buscarPorDescricao(Destinatario destinatario)
        {
            Destinatario resposta = null;

            if (destinatario.Nome != null)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE nome = @nome;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@nome",
                    destinatario.Nome);

                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    resposta = new Destinatario(
                 (int.Parse(leitor["id"].ToString())),leitor["rg"].ToString(),
                        leitor["nome"].ToString(), leitor["telefone"].ToString(), leitor["email"].ToString());

                    leitor.Close();
                }

            }


            return resposta;

        }

        public static Destinatario buscarPorId(Destinatario destinatario)
        {
            Destinatario resposta = null;

            if (destinatario.GetId() != 0)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE id = @id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    destinatario.GetId());

                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {

                    resposta = new Destinatario(int.Parse(leitor["id"].ToString()),leitor["rg"].ToString(),
                        leitor["nome"].ToString(),leitor["telefone"].ToString(), leitor["email"].ToString());

                    leitor.Close();
                }
 
            }


            return resposta;
 
        }



    }
}
