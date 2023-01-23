using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Linq.Expressions;

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
                throw  ex;
            }
        } // metodo generico para consultas no BD

        public static DataTable ConsultaSql (string sql)
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

    }

//fim das funções genéricas

   

}


