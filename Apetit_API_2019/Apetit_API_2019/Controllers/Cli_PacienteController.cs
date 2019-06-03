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
    [Route("api/[controllerPaciente]")]
    [ApiController]
    public class Cli_PacienteController : ControllerBase
    {
        private PacienteDAL pacientedal = new PacienteDAL();
        private Cli_Paciente paciente = new Cli_Paciente(); 


        [AcceptVerbs("POST")]
        [Route("CadastrarPaciente")]

        public void CadastrarPaciente(Cli_Paciente paciente)
        {
            this.pacientedal.Salvar(paciente); 


            
        }

        [AcceptVerbs("PUT")]
        [Route("EditarPaciente")]
        public void EditarPaciente(Cli_Paciente paciente)
        {
            this.pacientedal.EditarPaciente(paciente);  
            
            
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluiPaciente")]
        public void ExcluirPaciente(int paciente)
        {
            this.pacientedal.DeletarPaciente(paciente); 
            
        }

        [AcceptVerbs("GET")]
        [Route("BucarPacientePorID/{idpaciente}")]
        public Cli_Paciente BuscarPacienteporId(int idpaciente)
        {

            pacientedal.ListarPacientes(idpaciente);

            return paciente; 
        }

        
    }
}