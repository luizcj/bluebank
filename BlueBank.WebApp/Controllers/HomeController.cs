using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlueBank.WebApp.Models;
using System.Web.Mvc.Async;
using System.Web.Profile;
using System.Web.Routing;
using System.Text;
using BlueBank.WebApp.Controllers;

namespace BlueBank.Controllers
{
    public class HomeController : Controller
    {

        private bluebankdbEntities db = new bluebankdbEntities();
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Transferencia(Transferencia model)
        {

          

            try
            {
                Conta contaDebito = new Conta()
                {
                    Agencia = model.AgenciaDebito,
                    Numero = model.NumeroDebito
                };

                Conta contaCredito = new Conta()
                {
                    Agencia = model.AgenciaCredito,
                    Numero = model.NumeroCredito
                };

                DBHelper Helper = new DBHelper();
                contaDebito = Helper.ObterConta(contaDebito);
                contaCredito = Helper.ObterConta(contaCredito);

                if (Helper.ValidarTransferenciaSaldo(contaDebito, model.ValorTransferencia))
                {
                    Helper.RealizarDebito(contaDebito, model.ValorTransferencia);
                    Helper.RealizarCredito(contaCredito, model.ValorTransferencia);
                }

            }

            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View();
            
            }

            return View();
        }
     
        public ActionResult Transferencia()
        {
            
            return View();
        }


    }
}
