using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CatalogoPrendas
    {
        public List<Prenda> Prendas { get; set; }

        public CatalogoPrendas()
        {
            Prendas = new List<Prenda>();
        }

        public void AgregarPrenda(Prenda prenda)
        {
            Prendas.Add(prenda);
        }

        public void EliminarPrenda(Prenda prenda)
        {
            Prendas.Remove(prenda);
        }

        public void ActualizarPrecio(Prenda prenda, decimal nuevoPrecio)
        {
            prenda.Precio = nuevoPrecio;
        }

        public void MostrarCatalogo(string categoria)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Catálogo de prendas de la categoría {categoria}");
            Console.WriteLine("-----------------------------------------------");
            Console.ResetColor();

            foreach (Prenda prenda in Prendas)
            {
                if (prenda.GetType().Name == $"Prenda{categoria}")
                {
                    prenda.MostrarDetalles();
                }
            }

            Console.WriteLine();
        }
    }
}
