using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public List<Libro> Libros { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
    }
}