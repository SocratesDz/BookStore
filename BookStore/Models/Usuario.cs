using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public UserProfile Perfil { get; set; }
        public string Nombre { get; set; }
        public List<Compra> Historial { get; set; }
    }
}