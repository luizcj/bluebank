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
        [Required]
        [StringLength(6, ErrorMessage = "Agência deve ter no mínimo 4 digitos", MinimumLength = 4)]
        
        public string AgenciaDebito { get; set; }
        [Required]
        [StringLength(6, ErrorMessage = "A conta corrente deve ter no mínimo 6 digitos", MinimumLength = 6)]
        public string NumeroDebito { get; set; }
        public decimal SaldoDebito { get; set; }
        [Required]
        [StringLength(4, ErrorMessage = "Agência deve ter no mínimo 4 digitos", MinimumLength = 4)]
        public string AgenciaCredito { get; set; }
        [Required]
        [StringLength(6, ErrorMessage = "A conta corrente deve ter no mínimo 6 digitos", MinimumLength = 6)]
        public string NumeroCredito { get; set; }
        public decimal SaldoCredito { get; set; }
        [Required] 
        public decimal ValorTransferencia { get; set;  }
 
    }



}
