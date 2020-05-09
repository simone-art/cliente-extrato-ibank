using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ClienteIbank.Models
{
    public class ExtratoCliente
    {

        private static DBContext _db = new DBContext();

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ContaCliente { get; set; }

        public double SaldoConta { get; set; }

        public string Descricao { get; set; }

        public static List<ExtratoCliente> Lista()
        {
            return _db.ExtratoClientes.ToList();
        }

        public static DbSet<ExtratoCliente> Busca()
        {
            return _db.ExtratoClientes;
        }

        public bool Salvar()
        {
            try
            {
                _db.ExtratoClientes.Add(this);
                _db.SaveChanges();
                return true;
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        
    }

}