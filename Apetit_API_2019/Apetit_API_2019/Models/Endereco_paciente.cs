using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.Models
{
    public class Endereco_paciente
    {
       int Id_endereco_paciente { get; set; }
       int Id_paciente { get; set;}
       String nome_rua { get; set;}
       String num_rua { get; set;} 
       String Cidade { get; set;}
       String Bairro { get; set;}
       
    }
}
