using BlueBank.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace BlueBank.WebApp.Controllers
{
    public class DBHelper
    {
        private bluebankdbEntities db = new bluebankdbEntities();

        public Conta ObterConta(Conta conta)
        {
            try
            { 

            var query = from p in db.Conta where p.Numero == conta.Numero && p.Agencia == conta.Agencia select p;
            if (query.Count() == 0) { throw new Exception("Conta não existe"); }
            conta = (Conta)query.First();
            }

            catch (Exception ex)
            {
                throw ex;

            }

            return conta;
        }

        public bool ValidarTransferenciaSaldo(Conta conta, decimal valorTransferencia)
        {
            return (conta.Saldo >= valorTransferencia);
        }

        public void RealizarDebito(Conta conta, decimal valor)
        {
            try
            {
                conta.Saldo = conta.Saldo - valor;
                db.Entry(conta).State = EntityState.Modified;
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;

            }

        }

        public void RealizarCredito(Conta conta, decimal valor)
        {
            try
            {
                conta.Saldo = conta.Saldo + valor;
                db.Entry(conta).State = EntityState.Modified;
                db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;

            }
        }

   }
}

