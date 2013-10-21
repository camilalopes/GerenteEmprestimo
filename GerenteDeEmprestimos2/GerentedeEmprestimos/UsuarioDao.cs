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
    class UsuarioDao
    {
        public static readonly string TABELA = "usuario";

        public static void salvarUsuario(Usuario usuario)
        {
            MySqlCommand cmd;
            string sql;


            if (usuario.Login != null)
            {
                // MUITA ATENÇÃO nos espaçamentos entre comandos.
                sql = "INSERT INTO " + TABELA
                    + " VALUES (@login, @senha, @nome, @telefone, @email, @adm);";

                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql,
                    BancoDados.recuperarConexao());

                // Inserção de valores nos parâmetros.
                cmd.Parameters.AddWithValue("@login",
                    usuario.Login);
                cmd.Parameters.AddWithValue("@senha",
                    usuario.Senha);
                cmd.Parameters.AddWithValue("@nome",
                    usuario.Nome);
                cmd.Parameters.AddWithValue("@telefone",
                    usuario.Telefone);
                cmd.Parameters.AddWithValue("@email",
                    usuario.Email);
                cmd.Parameters.AddWithValue("@adm",
                    usuario.Adm);

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL sem dados de retorno.
                cmd.ExecuteNonQuery();
            }
        }

        public static Usuario buscarUsuario(Usuario usuario)
        {
            Usuario resposta = null;

            if (usuario.Login != "")
            {
                MySqlCommand cmd;
                string sql = "SELECT * FROM " + TABELA + " WHERE login = @login;";


                // Associação do comando à conexão.
                cmd = new MySqlCommand(sql, BancoDados.recuperarConexao());

                cmd.Parameters.AddWithValue("@login", usuario.Login);

                // Preparação da consulta.
                cmd.Prepare();

                // Execução da sentença SQL, com dados de retorno
                // associados a um objeto para posterior leitura.
                MySqlDataReader leitor = cmd.ExecuteReader();


                if (leitor.Read())
                {
                    // adiciona o respectivo objeto Destinatario, construído
                    // com os dados de retorno, à coleção de destinatarios.
                    resposta=( new Usuario(leitor["login"].ToString(), leitor["senha"].ToString(), bool.Parse(leitor["adm"].ToString())));

                    // Libera recursos de memória.
                    leitor.Close();
                }
 
            }





            return resposta;

        }
    }
}
