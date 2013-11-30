using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidade;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Dao
{
    class ItemDao
    {
        public static readonly string TABELA = "item";


        public static void salvarItem(Item item)
        {
            MySqlCommand cmd;
            string sql;

            if (item.GetId() == 0)
            {
                sql = "INSERT INTO " + TABELA
                    + " VALUES (default, @descricao);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    item.Descricao);

            }
            else
            {
                
                sql = "UPDATE " + TABELA
                    + " SET descricao = @descricao"
                    + " WHERE id=@id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    item.Descricao);
                cmd.Parameters.AddWithValue("@id",
                    item.GetId());
            }

            // Preparação da consulta.
            cmd.Prepare();

            // Execução da sentença SQL sem dados de retorno.
            cmd.ExecuteNonQuery();

        }


        public static ArrayList buscarItem(Item item)
        {
            // Reposta padrão.
            ArrayList items = null;

            // Só é possível localizar uma item cuja descrição
            // esteja especificada.
            if (item.Descricao != null)
            {
                // Cria uma coleção vazia.
                items = new ArrayList();

                MySqlCommand cmd;


                string sql = "SELECT * FROM " + TABELA
                    + " WHERE descricao LIKE @descricao;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    "%" + item.Descricao + "%");

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                // Enquanto houver items correspondentes...
                while (leitor.Read())
                {
                    // adiciona o respectivo objeto item, construído
                    // com os dados de retorno, à coleção de items.
                    items.Add(
                        new Item(
                            int.Parse(leitor["id"].ToString()),
                            leitor["descricao"].ToString()
                        )
                    );
                }

                // Libera recursos de memória.
                leitor.Close();
            }

            return items;
        }


        
        public static Item buscarPorDescricao(Item item)
        {
            Item resposta = null;

            if (item.Descricao != null)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE descricao = @descricao;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@descricao",
                    item.Descricao);

                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    resposta = new Item(
                    int.Parse(leitor["id"].ToString()),
                    leitor["descricao"].ToString());

                    
                }
                leitor.Close();
            }


            return resposta;

        }


        public static Item buscarPorId(Item item)
        {
            Item resposta = null;

            if (item.GetId() != 0)
            {
                MySqlCommand cmd;

                string sql = "SELECT * FROM " + TABELA
                    + " WHERE id = @id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    item.GetId());

                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();

                if (leitor.Read())
                {
                    resposta = new Item(
                    int.Parse(leitor["id"].ToString()),
                    leitor["descricao"].ToString());

                    
                }
                leitor.Close();
            }


            return resposta;

        }

        public static void excluirItem(Item item)
        {
            // Só é possível excluir uma tarefa cujo id
            // esteja especificado.
            if (item.GetId() != 0)
            {
                MySqlCommand cmd;

                // MUITA ATENÇÃO nos espaçamentos entre comandos.
                string sql = "DELETE FROM " + TABELA
                    + " WHERE id = @id;";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@id",
                    item.GetId());

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL sem dados de retorno.
                cmd.ExecuteNonQuery();
            }
        }


    }
}
