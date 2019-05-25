using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.Models
{
    public class Endereco_nutricionista
    {
        int id_endereco_paciente { get; set; }
        int id_nutricionista { get; set; }
        int crn { get; set; }
        String nome_rua { get;set;}
        String num_rua { get;set;}
        String Cidade { get; set;}
        String Bairro { get; set;}

    }
}
