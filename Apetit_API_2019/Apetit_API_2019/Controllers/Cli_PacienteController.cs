using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apetit_API_2019.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Apetit_API_2019.Controllers
{
    [Route("api/[controllerPaciente]")]
    [ApiController]
    public class Cli_PacienteController : ControllerBase
    {
        private static List<Cli_Paciente> listapaciente = new List<Cli_Paciente>();


        [AcceptVerbs("POST")]
        [Route("CadastrarPaciente")]

        public void CadastrarPaciente(Cli_Paciente paciente)
        {
            listapaciente.Add(paciente);


            
        }

        [AcceptVerbs("PUT")]
        [Route("EditarPaciente")]
        public void EditarPaciente(Cli_Paciente paciente)
        {

            listapaciente.Where(n => n.IdPaciente == paciente.IdPaciente).Select(s =>
            {
                s.Login = paciente.Login;
                s.Senha = paciente.Senha;
                s.Nome = paciente.Nome;
                s.Dtnascimento = paciente.Dtnascimento;
                s.Endereco = paciente.Endereco;
                s.Email = paciente.Email;

                return s;
            }).ToList();

            
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluiPaciente")]
        public void  ExcluirPaciente(int idpaciente)
        {
            Cli_Paciente paciente = listapaciente.Where(n => n.IdPaciente == idpaciente)
                .Select(n => n).FirstOrDefault();
            listapaciente.Remove(paciente);

            
        }

        [AcceptVerbs("GET")]
        [Route("BucarPacientePorID/{idpaciente}")]
        public Cli_Paciente BuscarPacienteporId(int idpaciente)
        {
            Cli_Paciente paciente = listapaciente.Where(n => n.IdPaciente == idpaciente)
                .Select(n => n).FirstOrDefault();



            return paciente;
        }

        [AcceptVerbs("GET")]
        [Route("BuscarPaciente")]
        public  List<Cli_Paciente> BuscarPaciente()
        {
            return listapaciente; 
        }
    }
}