using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteIbank.Models
{
    public class ExtratoCliente
    {
        public int Id { get; set; }

        public int ContaCliente { get; set; }

        public double SaldoConta { get; set; }

        public string Descricao { get; set; }

    }
}