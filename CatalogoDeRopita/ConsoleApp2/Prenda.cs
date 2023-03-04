using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Prenda
    {
        public string Material { get; set; }
        public string Talla { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }

        public abstract void MostrarDetalles();
    }
}
