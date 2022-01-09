using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
        
        public IActionResult ContatoAcao()
        {

            try
            {
                Contato contato = new Contato();

                contato.name = HttpContext.Request.Form["name"];
                contato.email = HttpContext.Request.Form["email"];
                contato.description = HttpContext.Request.Form["text"];

                //TODO - Validar campos antes de enviar e-mail

                //chamar ContatoEmail.SendContactEmail

                ViewData["MSG_S"] = "Mensagem de contato enviada com sucesso!";
            }
            catch(Exception ex)
            {
                ViewData["MSG_E"] = "Ops! Ocorreu um erro ao enviar o e-mail. Tente novamente em alguns instantes.";
                //TODO - Implementar Log
            }
            

            return View("Contato");
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroDeClientes()
        {
            return View();
        }

        public IActionResult CarrinhoDeCompras()
        {
            return View();
        }
    }
}
