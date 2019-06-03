using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apetit_API_2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Apetit_API_2019.DAL;


namespace Apetit_API_2019.Controllers
{
    [Route("api/[controllerNutricionista]")]
    [ApiController]
    public class Cli_NutricionistaController : ControllerBase
    {
        private NutricionistaDAL nutricionistadal = new NutricionistaDAL();
        private Cli_Nutricionista nutricionista = new Cli_Nutricionista();

        [AcceptVerbs("POST")]
        [Route("CadastrarNutricionista")]
        public void CadastrarNutricionista(Cli_Nutricionista nutricionista)
        {
            this.nutricionistadal.Salvar(nutricionista);

        }

           

        [AcceptVerbs("PUT")]
        [Route("AlterarNutricionista")]
        public void AlterarNutricionista(Cli_Nutricionista nutricionista)
        {
            this.nutricionistadal.EditarNutricionista(nutricionista); 
            
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirrNutricionista")]
        public void ExcluirNutricionista(int nutricionista)
        {

            this.nutricionistadal.DeletarNutricionista(nutricionista);
          

          
        }

        [AcceptVerbs("GET")]
        [Route("BuscarNutricionistaPorID/{idnutricionista}")]
        public  Cli_Nutricionista BuscarId (int idnutricionista)
        {
            this.nutricionistadal.BuscarNutricionistaporId(idnutricionista);


            return nutricionista; 


             
        }


        [AcceptVerbs("GET")]
        [Route("ListarNutricionistas")]
        public List<Cli_Nutricionista> listarnutricionista(int idnutricionista)  
        {
            return nutricionistadal.ListarNutricionistas(idnutricionista); 
            
        }



    }
}