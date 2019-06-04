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
    [Route("api/[controllerDieta]")]
    [ApiController]
    public class DietaController : ControllerBase
    {
        private Dieta dieta = new Dieta();
        private Dietadal dietadal = new Dietadal();

        public void cadastrarDieta(Dieta dieta)
        {

            dietadal.SalvarDieta(dieta);

        }

        public void deletarDieta(int dieta)
        {
            dietadal.DeletarDieta(dieta);
        }

        public void editarDieta(Dieta dieta)
        {


        }
           





    }
}