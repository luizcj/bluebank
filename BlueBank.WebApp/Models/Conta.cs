using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;


namespace BlueBank.WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conta
    {
        public int Id { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }
    }



    public partial class Transferencia
    {
        public string AgenciaDebito { get; set; }
        public string NumeroDebito { get; set; }
        public decimal SaldoDebito { get; set; }

        public string AgenciaCredito { get; set; }
        public string NumeroCredito{ get; set; }
        public decimal SaldoCredito { get; set; }

        public decimal ValorTransferencia { get; set;  }
 
    }



}
