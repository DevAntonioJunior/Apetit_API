using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.Models
{
    public class Dieta
    {
        public int id_dieta { get; set; }
        public int id_paciente { get; set; }
        public int crn { get; set; }
        public String titulo {get ; set;}
        public String descricao { get;set;}
    }
}
