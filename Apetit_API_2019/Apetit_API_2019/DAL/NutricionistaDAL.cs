using Apetit_API_2019.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data;





namespace Apetit_API_2019.DAL
{
    public class NutricionistaDAL
    {

        Bd_conexao _Conexao = new Bd_conexao();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();


        public void Salvar(Cli_Nutricionista nutricionista)
        {

            cmd1.CommandText = "insert into Nutricionista(nome_nutricionista,sobrenome_nutricionista,cpf,dt_nascimento,sexo,login,senha,email,num_celular) values (?,?,?,?,?,?,?,?,?,?,?)";
            cmd1.Parameters.Add(nutricionista.Nome);
            cmd1.Parameters.Add(nutricionista.Sobrenome);
            cmd1.Parameters.Add(nutricionista.Cpf);
            cmd1.Parameters.Add(nutricionista.Dtnascimento);
            cmd1.Parameters.Add(nutricionista.Sexo);
            cmd1.Parameters.Add(nutricionista.Login);
            cmd1.Parameters.Add(nutricionista.Senha);
            cmd1.Parameters.Add(nutricionista.Email);
            cmd1.Parameters.Add(nutricionista.Telefone);


            cmd2.CommandText = "insert into Endereco_Nutricionista(crn,nome_rua,num_rua,cidade,bairro) values(?,?,?,?,?)";
            cmd2.Parameters.Add(nutricionista.Crn);
            cmd2.Parameters.Add(nutricionista.Endereco);
            cmd2.Parameters.Add(nutricionista.Complemento);
            cmd2.Parameters.Add(nutricionista.Cidade);
            cmd2.Parameters.Add(nutricionista.Bairro);

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

        public void EditarNutricionista(Cli_Nutricionista nutricionista)
        {

            cmd1.CommandText = ("UPDATE TB_Nutricionista SET('nome_nutricionista=?','sobrenome_nutricionista=?','cpf=?','dt_nascimento=?','sexo=?','login=?','senha=?','email=?','num_celular=?'");
            cmd1.Parameters.Add(nutricionista.Nome);
            cmd1.Parameters.Add(nutricionista.Sobrenome);
            cmd1.Parameters.Add(nutricionista.Cpf);
            cmd1.Parameters.Add(nutricionista.Dtnascimento);
            cmd1.Parameters.Add(nutricionista.Sexo);
            cmd1.Parameters.Add(nutricionista.Login);
            cmd1.Parameters.Add(nutricionista.Senha);
            cmd1.Parameters.Add(nutricionista.Email);
            cmd1.Parameters.Add(nutricionista.Telefone);


            cmd2.CommandText = "UPDATE Endereco_Nutricionista SET('@crn=?','nome_rua=?',num_rua,cidade,bairro) values(?,?,?,?,?)";
            cmd2.Parameters.Add(nutricionista.Crn);
            cmd2.Parameters.Add(nutricionista.Endereco);
            cmd2.Parameters.Add(nutricionista.Complemento);
            cmd2.Parameters.Add(nutricionista.Cidade);
            cmd2.Parameters.Add(nutricionista.Bairro);

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


        public void DeletarNutricionista(int Idnutricionista)
        {
            cmd1.CommandText = "Delete from TB_Nutricionista where Idnutricionista=? ";
            cmd1.Parameters.Remove(Idnutricionista);



            cmd2.CommandText = "Delete from Endereco_Nutricionista where Id_nutricionista";
            cmd2.Parameters.Remove(Idnutricionista);


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
        public DataTable BuscarNutricionistaporId(int idnutricionista)
        {
            try
            {
                _Conexao.Conectar();
                cmd1.CommandText = "Select nome,sobrenome,datanascimento,sexo,login WHERE = IdNutricionista =?";
                DataTable nutri = new DataTable();
                SqlDataAdapter Ad = new SqlDataAdapter();
                Ad.Fill(nutri);
                return nutri;

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

        public List<Cli_Nutricionista> ListarNutricionistas(int Idnutricionista)
        {

            List<Cli_Nutricionista> Obterlistanutricionista = new List<Cli_Nutricionista>();
            cmd1.CommandText = "Select from TB_nutricionista";
            _Conexao.Conectar();

            SqlDataReader lernutri = cmd1.ExecuteReader();

            if (lernutri.HasRows)
            {
                while (lernutri.Read())
                {
                    Cli_Nutricionista N = new Cli_Nutricionista();

                    N.IdNutricionista = Convert.ToInt32(lernutri[Idnutricionista]);
                    N.Nome = lernutri["Nome"].ToString();
                    N.Sobrenome = lernutri["Sobrenome"].ToString();
                    N.Email = lernutri["Email"].ToString();
                    Obterlistanutricionista.Add(N);

                }
            }
            _Conexao.Desconectar();
            return Obterlistanutricionista;


        }


        public void vericicaLogin()
        {

        }
    }
}

    














