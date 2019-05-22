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
         
            public void Salvar(Cli_Nutricionista nutricionista)
        {
            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand();

            cmd1.CommandText = "insert into  TB_Nutricionista";
            cmd2.CommandText = "insert innt Tb_endereco";
            _Conexao.Conectar();

            SqlTransaction tran = _Conexao.Conectar.BeginTransaction(); 
            try
            {


            }finally
                
             
            
            
            
            

         }
    
        
        
    
}
