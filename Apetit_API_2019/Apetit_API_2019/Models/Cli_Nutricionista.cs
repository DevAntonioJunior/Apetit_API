using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Apetit_API_2019.Models
{
    public class Cli_Nutricionista
    {
      
            public int IdNutricionista { get; set; }
            [Key]
            public String Nome { get; set; }
            [Required]
            public String Sobrenome { get; set; }
            public DateTime Dtnascimento { get; set; }
            [Required]
            public String Sexo { get; set; }
            [Required]
            public String Cpf { get; set; }
            [Required]
            public String Email { get; set; }
            [Required]
            public String Telefone { get; set; }
            [Required]
            public String Endereco { get; set; }
            [Required]
            public String Cep { get; set; }
            [Required]
            public String Complemento { get; set; }
            [Required]
            public String Bairro { get; set; }
            [Required]
            public String Login { get; set; }
            [Required]
            public String Senha { get; set; }
            [Required]
            public String Dieta { get; set; }
            [Required]
            public String Cidade { get; set; }
            [Required]
            public String Crn { get; set; }
            

        public Cli_Nutricionista(int idnutricionista, string nome, string sobrenome, DateTime dtnascimento, string sexo, string cpf, string email, string telefone, string endereco, string cep, string complemento, string bairro, string login, string senha, string dieta, string cidade, DateTime agconsulta, string crn)
            {
                this.IdNutricionista = idnutricionista;
                this.Nome = nome;
                this.Sobrenome = sobrenome;  
                this.Dtnascimento = dtnascimento;
                this.Sexo = sexo;
                this.Cpf = cpf;
                this.Email = email;
                this.Telefone = telefone;
                this.Endereco = endereco;
                this.Cep = cep;
                this.Complemento = complemento;
                this.Bairro = bairro;
                this.Login = login;
                this.Senha = senha;
                this.Crn = crn;
                
                
                
        }


    }
}
