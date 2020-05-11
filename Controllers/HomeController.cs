using ClienteIbank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClienteIbank.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
      

        [HttpGet]
        public ActionResult Index()
        {
 

            //var extratoCliente = new ExtratoCliente() { ContaCliente = 987654, SaldoConta = 10500, Descricao = "Transferência de Rs 500 feita por Simone Santos, N° Conta 123456" }.Salvar();
            //var extratoCliente2 = new ExtratoCliente() { ContaCliente = 987655, SaldoConta = 500, Descricao = "Transferência de Rs 500 feita por Manu Maia, N° Conta 456789" }.Salvar();
            //var extratoCliente3 = new ExtratoCliente() {ContaCliente = 987656, SaldoConta = 2000, Descricao = "Transferência de Rs 800 feita por Regina Pitanga, N° Conta 567342" }.Salvar();

            //var extratoClientes = ExtratoCliente.Lista();

            return Json(ExtratoCliente.Lista(), JsonRequestBehavior.AllowGet);

            //ViewBag.Title = "Home Page";
            //ViewBag.ExtratoClientes = extratoClientes;

            //return View();
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            return Json(ExtratoCliente.Busca().Where(e => e.Id == id).First(), JsonRequestBehavior.AllowGet);
        }
    }
}

