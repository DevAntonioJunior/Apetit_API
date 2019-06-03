using Apetit_API_2019.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;



namespace Apetit_API_2019.DAL
{
    public class PacienteDAL
    {
        Bd_conexao _Conexao = new Bd_conexao();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();


        public void Salvar(Cli_Paciente paciente)
        {

            cmd1.CommandText = "insert into Paciente(nome_paciente,sobrenome_paciente,cpf,dt_nascimento,sexo,login,senha,email,num_celular) values (?,?,?,?,?,?,?,?,?,?,?)";
            cmd1.Parameters.Add(paciente.Nome);
            cmd1.Parameters.Add(paciente.Sobrenome);
            cmd1.Parameters.Add(paciente.Cpf);
            cmd1.Parameters.Add(paciente.Dtnascimento);
            cmd1.Parameters.Add(paciente.Sexo);
            cmd1.Parameters.Add(paciente.Login);
            cmd1.Parameters.Add(paciente.Senha);
            cmd1.Parameters.Add(paciente.Email);
            cmd1.Parameters.Add(paciente.Telefone);


            cmd2.CommandText = "insert into Endereco_paciente(crn,nome_rua,num_rua,cidade,bairro) values(?,?,?,?,?)";
            cmd2.Parameters.Add(paciente.Altura);
            cmd2.Parameters.Add(paciente.Endereco);
            cmd2.Parameters.Add(paciente.Complemento);
            cmd2.Parameters.Add(paciente.Cidade);
            cmd2.Parameters.Add(paciente.Bairro);

            _Conexao.Conectar();

            SqlTransaction tran = _Conexao.BeginTransaction();
            try
            {

                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();


                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                tran.Commit();


            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw ex;

            }
            finally
            {
                _Conexao.Desconectar();
            }
        }

        public void EditarPaciente(Cli_Paciente paciente)
        {
            cmd1.CommandText = ("UPDATE Paciente SET('nome_paciente=?','sobrenome_paciente=?','cpf=?','dt_nascimento=?','sexo=?','login=?','senha=?','email=?','num_celular=?'");
            cmd1.Parameters.Add(paciente.Nome);
            cmd1.Parameters.Add(paciente.Sobrenome);
            cmd1.Parameters.Add(paciente.Cpf);
            cmd1.Parameters.Add(paciente.Dtnascimento);
            cmd1.Parameters.Add(paciente.Sexo);
            cmd1.Parameters.Add(paciente.Login);
            cmd1.Parameters.Add(paciente.Senha);
            cmd1.Parameters.Add(paciente.Email);
            cmd1.Parameters.Add(paciente.Telefone);


            cmd2.CommandText = "UPDATE Endereco_Paciente SET('nome_rua=?',num_rua,cidade,bairro) values(?,?,?,?,?)";
            cmd2.Parameters.Add(paciente.Endereco);
            cmd2.Parameters.Add(paciente.Complemento);
            cmd2.Parameters.Add(paciente.Cidade);
            cmd2.Parameters.Add(paciente.Bairro);
            

            _Conexao.Conectar();

            SqlTransaction tran = _Conexao.BeginTransaction();
            try
            {

                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();

                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                tran.Commit();



            }
            catch (SqlException ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                _Conexao.Desconectar();
            }

        }


        public void DeletarPaciente(int IdPaciente)
        {
            cmd1.CommandText = "Delete from Paciente where Idpaciente=? ";
            cmd1.Parameters.Remove(IdPaciente);

            cmd2.CommandText = "Delete from Endereco_Paciente where Id_Paciente=?";
            cmd2.Parameters.Remove(IdPaciente);
            _Conexao.Conectar();
            SqlTransaction tran = _Conexao.BeginTransaction();
            try
            {
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();
                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                tran.Commit();
            }

            catch (SqlException ex)
            {
                tran.Rollback();
                throw ex;
            }
            finally
            {
                _Conexao.Desconectar();
            }
        }


        /*
         * metodo ultlizando Data Table 
         public DataTable BuscarPacienteporId(int idpaciente)
         {
             try
             {
                 _Conexao.Conectar();
                 cmd1.CommandText = "Select nome,sobrenome,datanascimento,sexo,login WHERE = IdPaciente =?";
                 DataTable paci = new DataTable();
                 SqlDataAdapter Ad = new SqlDataAdapter();
                 Ad.Fill(paci);
                 return paci;

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
         */


        public List<Cli_Paciente> ListarPacientes(int IdPaciente)
        {
            List<Cli_Paciente> obterlistapaciente = new List<Cli_Paciente>(); 
            cmd1.CommandText = "Select from Paciente";
            _Conexao.Conectar();

            SqlDataReader lerpaci = cmd1.ExecuteReader();

            if (lerpaci.HasRows)
            {
                while (lerpaci.Read())
                {
                    Cli_Paciente P = new Cli_Paciente();

                    P.IdPaciente = Convert.ToInt32(lerpaci[IdPaciente]);
                    P.Nome = lerpaci["Nome"].ToString();
                    P.Sobrenome = lerpaci["Sobrenome"].ToString();
                    P.Email = lerpaci["Email"].ToString();
                    obterlistapaciente.Add(P);

                }
            }
            _Conexao.Desconectar();
            return obterlistapaciente;

        }

    }
}
















