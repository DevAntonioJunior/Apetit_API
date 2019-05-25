using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.Models
{
    public class Dieta
    {
        int id_dieta { get; set;}
        int id_paciente { get; set;}
        int crn { get; set; }
        String descricao { get;set;}
    }
}
