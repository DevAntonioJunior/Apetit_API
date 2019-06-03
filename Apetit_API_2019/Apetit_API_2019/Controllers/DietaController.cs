using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apetit_API_2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apetit_API_2019.Controllers
{
    [Route("api/[controllerDieta]")]
    [ApiController]
    public class DietaController : ControllerBase
    {
        private Dieta dieta = new Dieta();
        
        public void cadastrarDieta(Dieta dieta)
        {



        }

    }
}