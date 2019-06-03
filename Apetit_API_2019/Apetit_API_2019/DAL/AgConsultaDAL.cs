using Apetit_API_2019.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.DAL
{
    public class AgConsultaDAL
    {
        Bd_conexao _Conexao = new Bd_conexao();
        SqlCommand cmd1 = new SqlCommand();

        public void SalvarConsulta(Cli_AgConsultas consulta)
        {
            try
            {

                cmd1.CommandText = "Insert into Consulta(data_consulta,descricao)values(?,?)";
                cmd1.Parameters.Add(consulta.Dtmarcada);
                cmd1.Parameters.Add(consulta.Descricao);
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


        public void Deletarconsulta(int Idconsulta)
        {
            try
            {
                cmd1.CommandText = "DELETE from Consulta Where = Idconsulta";
                cmd1.Parameters.Remove(Idconsulta);
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

        public void EditarConsulta(Cli_AgConsultas consulta)
        {



            try
            {

                cmd1.CommandText = "Upadate  Consulta SET(data_consulta,descricao)values(?,?)";
                cmd1.Parameters.Add(consulta.Dtmarcada);
                cmd1.Parameters.Add(consulta.Descricao);
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


    }
}
