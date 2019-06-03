using Apetit_API_2019.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.DAL
{
    public class Dietadal
    {



        Bd_conexao _Conexao = new Bd_conexao();
        SqlCommand cmd1 = new SqlCommand();

        public void SalvarDieta(Dieta dieta)
        {
            try
            {

                cmd1.CommandText = "Insert Into Dieta(descricao)values(?)";
                cmd1.Parameters.Add(dieta.descricao); 
                _Conexao.Conectar();
                cmd1.ExecuteNonQuery();


            }
            catch (SqlException ex)
            {
                throw ex;

            }
            finally
            {
                _Conexao.Desconectar();
            }

        }
        public void DeletarDieta(int Iddieta)
        {
            try
            {
                cmd1.CommandText = "DELETE from Dieta Where = Id_dieta";
                cmd1.Parameters.Remove(Iddieta);
                cmd1.ExecuteNonQuery();
                _Conexao.Conectar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _Conexao.Desconectar();
            }
        }




    }
}
