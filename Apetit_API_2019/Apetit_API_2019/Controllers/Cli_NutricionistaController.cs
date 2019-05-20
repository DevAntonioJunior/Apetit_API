using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apetit_API_2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apetit_API_2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cli_NutricionistaController : ControllerBase
    {
        private List<Cli_Nutricionista> listanutricionista = new List<Cli_Nutricionista>();


        [AcceptVerbs("POST")]
        [Route("CadastrarNutricionista")]
        public string CadastrarNutricionista(Cli_Nutricionista nutricionista)
        {
            listanutricionista.Add(nutricionista);


            return "Nutricionista adastrado com sucesso";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarNutricionista")]
        public string AlterarNutricionista(Cli_Nutricionista nutricionista)
        {
            listanutricionista.Where(n => n.IdNutricionista == nutricionista.IdNutricionista)
                .Select(s =>
                {
                    s.Login = nutricionista.Login;
                    s.Senha = nutricionista.Senha;
                    s.Nome = nutricionista.Nome;
                    s.Dtnascimento = nutricionista.Dtnascimento;
                    s.Endereco = nutricionista.Endereco;
                    s.Email = nutricionista.Email;

                    return s;

                }).ToList();




            return "Usuario alterado com sucesso";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirrNutricionista")]
        public string ExcluirUsuario(int idnutricionista)
        {

            Cli_Nutricionista nutricionista = listanutricionista.Where(n => n.IdNutricionista == idnutricionista)
                .Select(n => n).FirstOrDefault();

            listanutricionista.Remove(nutricionista);

            return "Nutricionista excluido com sucesso";
        }

        [AcceptVerbs("GET")]
        [Route("BuscarNutricionistaPorID/{idnutricionista}")]
        public Cli_Nutricionista BuscarNutricionistaPorID(int idnutricionista)
        {
            Cli_Nutricionista nutricionista = listanutricionista.Where(n => n.IdNutricionista == idnutricionista)
                .Select(n => n).FirstOrDefault();



            return nutricionista; 
        }

        [AcceptVerbs("GET")]
        [Route("BuscarNutricionistas")]
        public List<Cli_Nutricionista> BuscarNutricionista()
        {
            return listanutricionista;
        }



    }
}