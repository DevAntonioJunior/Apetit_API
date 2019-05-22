using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Apetit_API_2019.Models;

namespace Apetit_API_2019.Models
{
    public class Cli_AgConsultas
    {
        public int IdAgconsultas { get; set; }
        [Key]
        public int IdNutricionista { get; set;  }
        public int IdPaciente { get; set; }
        public DateTime Dtmarcada { get; set;}
        public DateTime Dtrealizada { get; set; }
        public String Descricao { get; set; }



    }
}
