using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apetit_API_2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apetit_API_2019.Controllers
{
    [Route("api/[controllerAgconsulta]")]
    [ApiController]
    public class Cli_AgconsultaController : ControllerBase
    {
        private static List<Cli_AgConsultas> listaconsulta = new List<Cli_AgConsultas>();

        [AcceptVerbs("GET")]
        [Route("VisualizarConsulta")]
        public List<Cli_AgConsultas> Visualizarconsulta()
        {
            return listaconsulta;

         
        }


        [AcceptVerbs("POST")]
        [Route("MarcarConsulta")]
        public string MarcarConsulta(Cli_AgConsultas consulta) 
        {
                listaconsulta.Add(consulta);

                return "Paciente Cadastrado com sucesso"; 
        }


    }
}
