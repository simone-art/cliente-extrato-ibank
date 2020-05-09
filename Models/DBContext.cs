using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ClienteIbank.Models
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = "";

            try
            {
                config = ConfigurationManager.ConnectionStrings["web"].ConnectionString;
            }
            catch
            {
                config = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Ibank_Extrato;Data Source=USER-VAIO";
            }
            optionsBuilder.UseSqlServer(config);
        }

        public DbSet<ExtratoCliente> ExtratoClientes { get; set; }

    }
}