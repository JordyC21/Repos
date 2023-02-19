using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public class Empleado : Persona
    {

        public Empleado(string nombre,string Apellido, int edad): base(nombre, Apellido, edad) { }


        public string SaludarCliente()
        {
            string saludo = $"Hola querido cliente Bienvenido a nuestro Bar El pancracio";
            Console.WriteLine(saludo);
            TomarOrden();
            return saludo;

        }

        public void TomarOrden()
        {
            Dictionary<string, List<string>> bebidasPorCategoria = new Dictionary<string, List<string>>
            {
                  {"Refrescos", new List<string> { "Coca-Cola", "Fanta", "Sprite" }},
                  {"Bebidas alcohólicas", new List<string> { "Cerveza", "Vino", "Whisky" }},
                  {"Bebidas energéticas", new List<string> { "Red Bull", "Monster", "Rockstar" }},
                  {"Bebidas de frutas", new List<string> { "Jugo de naranja", "Jugo de piña", "Jugo de manzana" }}
            };

            Console.WriteLine("Estas son las categorías de bebidas que tenemos para ti:\n");

            for (int i = 0; i < bebidasPorCategoria.Count; i++)
            {
                string categoria = bebidasPorCategoria.Keys.ElementAt(i);
                Console.WriteLine($"{i + 1}. {categoria}");
            }

            Console.WriteLine("\nPor favor, seleccione la categoría que desea (ingrese el número correspondiente):");

            int opcionCategoria;
            while (!int.TryParse(Console.ReadLine(), out opcionCategoria) || opcionCategoria < 1 || opcionCategoria > bebidasPorCategoria.Count)
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            }

            string categoriaSeleccionada = bebidasPorCategoria.Keys.ElementAt(opcionCategoria - 1);
            List<string> bebidasCategoria = bebidasPorCategoria[categoriaSeleccionada];

            Console.WriteLine($"\nEstas son las bebidas de la categoría {categoriaSeleccionada}:\n");

            for (int i = 0; i < bebidasCategoria.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bebidasCategoria[i]}");
            }

            Console.WriteLine("\nCual desea ordenar?):");
            int opcionOrden;
            while (!int.TryParse(Console.ReadLine(), out opcionOrden) || opcionOrden < 1 || opcionOrden > bebidasCategoria.Count)
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
            }

            string ordenSeleccionada = bebidasCategoria[opcionOrden - 1];

            Console.WriteLine($"\nHa seleccionado {ordenSeleccionada}. ¿Cuántas unidades desea ordenar?");
            int cantidad;
            while (!int.TryParse(Console.ReadLine(), out cantidad) || cantidad < 1)
            {
                Console.WriteLine("Cantidad inválida. Por favor, seleccione una cantidad válida.");
            }
            double precio = cantidad * 3.50;

            Console.WriteLine($"INFORMACION DEL PEDIDO: \n Categoria elegida: {categoriaSeleccionada}\n Bebida elegida: {ordenSeleccionada}\n Cantidad: {cantidad} \n SubTotal: {precio}");
            Console.ReadKey();

        }

    }

}
