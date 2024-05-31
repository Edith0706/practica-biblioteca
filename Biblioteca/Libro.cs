using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public DateTime AnioPublicacion { get; set; } // Cambiar a DateTime
        public string Genero { get; set; }
    }
}
