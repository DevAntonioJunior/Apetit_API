using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.Models
{

    public class Cli_Paciente
    {
        public int IdPaciente { get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set;}

        public DateTime Dtnascimento { get; set; }

        public String Sexo { get; set; }

        public String Cpf { get; set; }

        public String Email { get; set; }

        public String Telefone { get; set; }

        public String Endereco { get; set; }

        public String Cep { get; set; }

        public String Complemento { get; set; }

        public String Bairro { get; set; }

        public String Login { get; set; }

        public String Senha { get; set; }

        public String Dieta { get; set; }

        public String Cidade { get; set; }

        public DateTime Agconsulta { get; set; }

        public double Peso { get; set; }

        public float Altura { get; set; }


    }


    
}
