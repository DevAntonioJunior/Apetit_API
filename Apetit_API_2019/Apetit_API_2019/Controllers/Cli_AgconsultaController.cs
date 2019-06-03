using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apetit_API_2019.DAL;
using Apetit_API_2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apetit_API_2019.Controllers
{
    [Route("api/[controllerAgconsulta]")]
    [ApiController]
    public class Cli_AgconsultaController : ControllerBase
    {
        private AgConsultaDAL consultadal = new AgConsultaDAL();
        [AcceptVerbs("POST")]
        [Route("MarcarConsulta")]
        public void MarcarConsulta(Cli_AgConsultas consulta)
        {
            consultadal.SalvarConsulta(consulta);
        }

        [AcceptVerbs("POST")]
        [Route("EditarConsulta")]
        public void EditarConsulta(Cli_AgConsultas consulta)
        {
            consultadal.EditarConsulta(consulta); 
        }

        [AcceptVerbs("POST")]
        [Route("DeletarConsulta")]
        public void DeletarConsulta(int consulta)
        {
            consultadal.Deletarconsulta(consulta); 
        }



    }
}
