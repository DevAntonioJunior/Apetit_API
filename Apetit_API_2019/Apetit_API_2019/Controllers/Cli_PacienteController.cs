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
    public class Cli_PacienteController : ControllerBase
    {
        private static List<Cli_Paciente> listapaciente = new List<Cli_Paciente>();


        [AcceptVerbs("POST")]
        [Route("CadastrarPaciente")]

        public string CadastrarPaciente(Cli_Paciente paciente)
        {
            listapaciente.Add(paciente);


            return "Paciente cadastrado com sucesso";
        }

        [AcceptVerbs("PUT")]
        [Route("EditarPaciente")]
        public string EditarPaciente(Cli_Paciente paciente)
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

            return "Paciente alterado com sucesso!!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluiPaciente")]
        public string ExcluirPaciente(int idpaciente)
        {
            Cli_Paciente paciente = listapaciente.Where(n => n.IdPaciente == idpaciente)
                .Select(n => n).FirstOrDefault();
            listapaciente.Remove(paciente);

            return "Paciente excluido com sucesso";
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