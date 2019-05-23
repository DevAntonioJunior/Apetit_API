using Apetit_API_2019.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
 



namespace Apetit_API_2019.DAL
{
    public class NutricionistaDAL {

        Bd_conexao _Conexao = new Bd_conexao();
        SqlCommand cmd1 = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();


        public void Salvar(Cli_Nutricionista nutricionista)
        {

            cmd1.CommandText = "insert into TB_Nutricionista(nome_nutricionista,sobrenome_nutricionista,cpf,dt_nascimento,sexo,login,senha,email,num_celular) values (?,?,?,?,?,?,?,?,?,?,?)";
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

            
                SqlTransaction tran = _Conexao.BeginTransaction();
            try
            {
                _Conexao.Conectar(); 
                cmd1.Transaction = tran;
                cmd1.ExecuteNonQuery();


                cmd2.Transaction = tran;
                cmd2.ExecuteNonQuery();
                tran.Commit();


            }
            catch (SqlException ex)
            {
                tran.Rollback();

            }
            finally
            {
                _Conexao.Desconectar(); 
            }






                
             
            
            
            
            

         }
    
        
        
    
}
