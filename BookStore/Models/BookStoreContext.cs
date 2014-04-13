using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookStoreContext : DbContext
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Libro> Libros { get; set; }
        public List<Compra> Compras { get; set; }
    }
}