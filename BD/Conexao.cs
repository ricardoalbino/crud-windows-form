using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.BD
{
    public static class Conexao
    {
        public static SqlConnection conectar()
        {
            string stc = @"Data Source =.\SQLEXPRESS; Initial Catalog = Estudo; User ID = cadu; password=cadu";

           
                SqlConnection sqlConnection = new SqlConnection(stc);
                sqlConnection.Open();

                return sqlConnection;
            
           
        }
    }
}
