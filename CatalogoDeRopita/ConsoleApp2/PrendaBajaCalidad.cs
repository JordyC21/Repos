using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PrendaBajaCalidad : Prenda
    {
        public string Estilo { get; set; }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"Prenda de baja calidad, {Estilo}, {Material}, {Color}, {Talla}, {Precio:C}");
        }
    }
}
