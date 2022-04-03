
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Pagina
    {
        private string sqlConn()
        {
            return ConfigurationManager.AppSettings["sqlConn"];
        }

        public DataTable Lista()
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))

            {
                string queryString = "select * from tbpaginas";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void Salvar(int id, string nome, DateTime data, string conteudo)
        {
            using (SqlConnection connection = new SqlConnection(sqlConn()))

            {
                string queryString = "insert into tbpaginas(nome, data, conteudo) values('" + nome + "','" + data.ToString("yyyy-MM-dd HH:mm:sss") + "','" + conteudo + "')";
                if (id != 0)
                {
                    queryString = "update tbpaginas set nome = '" + nome + "', data = '" + data.ToString("yyyy-MM-dd HH:mm:sss") + "', conteudo = '" + conteudo + "' where id = '" + id + "'";
                }

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

            }
        }
    }
}
