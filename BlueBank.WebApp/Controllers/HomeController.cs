using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlueBank.WebApp.Models;
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
        public ActionResult Transferencia(Transferencia transferencia)
        {
            try
            {
                Conta contaDebito = new Conta()
                {
                    Agencia = transferencia.AgenciaDebito,
                    Numero = transferencia.NumeroDebito
                };

                Conta contaCredito = new Conta()
                {
                    Agencia = transferencia.AgenciaCredito,
                    Numero = transferencia.NumeroCredito
                };

                DBHelper Helper = new DBHelper();
                contaDebito = Helper.ObterConta(contaDebito);
                contaCredito = Helper.ObterConta(contaCredito);

                if (Helper.ValidarTransferenciaSaldo(contaDebito, transferencia.ValorTransferencia))
                {
                    Helper.RealizarDebito(contaDebito, transferencia.ValorTransferencia);
                    Helper.RealizarCredito(contaCredito, transferencia.ValorTransferencia);
                }

            }

            catch (Exception ex)
            {
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
