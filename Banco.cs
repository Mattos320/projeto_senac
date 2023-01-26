using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace ProjetoEscola2
{
    internal class Banco
    {
        private static SQLiteConnection conex;
        private static SQLiteConnection ConectarBanco()
        {
            conex = new SQLiteConnection("Data Source=" + Globais.caminhoBanco);

            conex.Open();
            return conex;
            //Fim do metodo ConectarBanco
        }
        public static DataTable RelacaoUser()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuario";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    return dt;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        } // metodo generico para consultas no BD

        public static DataTable ConsultaSql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Dml(string sql, string msgOk = null, string msgErro = null) // Data Manipulation Language (INSERT - UPDADE - DELETE)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                //o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOk != null) { MessageBox.Show(msgOk); }




            }
            catch (Exception ex)
            {
                if (msgErro != null) { MessageBox.Show(msgErro + " " + ex.Message); }
                throw ex;
            }



        }
        public static void NovoUser(Usuario user)
        {
            if (UsernameExiste(user) == true)
            {
                MessageBox.Show("Usuario já existe no sistema");
                return;
            }

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuario (nome_usuario,username_usuario,senha_usuario,status_usuario,nivel_usuario) VALUES (@nome,@username,@senha,@status,@nivel)";


                cmd.Parameters.AddWithValue("@nome", user.nome_usuario);
                cmd.Parameters.AddWithValue("@username", user.username_usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha_usuario);
                cmd.Parameters.AddWithValue("@status", user.status_usuario);
                cmd.Parameters.AddWithValue("@nivel", user.nivel_usuario);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo usuário adicionado com sucesso");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo usuario .: " + ex.Message);
                //throw ex;
            }


        }
        public static bool UsernameExiste(Usuario user)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username_usuario FROM tb_usuario WHERE username_usuario='" + user.username_usuario + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                resposta = true;
            }
            else
            {
                resposta = false;
            }

            vcon.Close();
            return resposta;
        }
        public static void NovoCurso(Curso curso)
        {


            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_curso (nome_curso,area_curso,status_curso) VALUES (@nome,@area,@status)";


                cmd.Parameters.AddWithValue("@nome", curso.nome_curso);
                cmd.Parameters.AddWithValue("@area", curso.area_curso);
                cmd.Parameters.AddWithValue("@status", curso.status_curso);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo curso adicionado com sucesso");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo curso .: " + ex.Message);
                //throw ex;
            }
        }
        public static void NovoProfessor(Professor professor)
        {


            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_professor (nome_professor,telefone_professor,turno_professor) VALUES (@nome,@telefone,@turno)";


                cmd.Parameters.AddWithValue("@nome", professor.nome_professor);
                cmd.Parameters.AddWithValue("@telefone", professor.telefone_professor);
                cmd.Parameters.AddWithValue("@turno", professor.turno_professor);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo professor adicionado com sucesso");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo professor .: " + ex.Message);
                //throw ex;
            }
        }

        //fim das funções genéricas




    }
}


