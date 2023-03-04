using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrendaAltaCalidad : Prenda
    {
        public string Disenio { get; set; }
        public string Marca { get; set; }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Prenda de alta calidad, {Marca}, {Disenio}, {Material}, {Color}, {Talla}, {Precio:C}");
        }
    }
}
