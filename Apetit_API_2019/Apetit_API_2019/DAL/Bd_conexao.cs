using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.DAL
{
    public class Bd_conexao
    {
        SqlConnection con = new SqlConnection();

        public Bd_conexao()
        {
            con.ConnectionString = ""; 

        }

        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open(); 
            }
            return con; 
        }

        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close(); 
            }
        }

    }
}
