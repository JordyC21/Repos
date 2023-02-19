using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*******BAR EL PANCRACIO*********\n\n\n HECHO POR: JORDY & WENDY");

            ForegroundColor= ConsoleColor.Green;
            WriteLine("\nELIGE LA OPCION:\n 1- Pedir una bebida " + "\n 2 - Menu de bebidas" +
                "\n 3- Salir del programa");
            ResetColor();
            int opcion = int.Parse(Console.ReadLine());


            while (opcion <= 0 || opcion >= 4)
            {
                Clear();
                Console.WriteLine("********BAR EL PANCRACIO*********\n\n\n HECHO POR: JORDY & WENDY\n");
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡¡Por favor asegurate que la opción se encuentre en el menu!!");
                ResetColor();
                Console.WriteLine("\nELIGE LA OPCIÓN:" +
                    "\n 1 - Pedir una bebida " +
                    "\n 2 - Menu de bebidas" +
                    "\n 3 - Salir del programa");
                opcion = int.Parse(Console.ReadLine());
            }


            switch (opcion)
            {
                case 1:


                    Clear();
                    WriteLine($"Elegiste la opcion {opcion}\n");

                    Cliente cliente = new Cliente("","",0);
                    Empleado empleado = new Empleado("Manuel","Humberto",0);
                    empleado.Presentarse();
           
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("**********MENÚ DE BEBIDAS**********\n");
                    ResetColor();

                   

                    Console.WriteLine("\nQueremos estar seguros de que eres mayor de edad, por favor dame tus datos" +
                        "\n \n Presiona una tecla para continuar...");
                    ReadKey();
                    cliente.SolicitarDatos();


                    break;


                case 2:



                    Clear();
                    WriteLine($"Elegiste la opcion {opcion}\n");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("**********MENÚ DE BEBIDAS**********\n");
                    ResetColor();

                    string[] Munu = new string[] { "Cerveza", "Vino", "Ron", "Whiskey", "Tequila", "Agua", "Refresco" };
                    WriteLine("Estas son las bebidas que ofrecemos: \n");

                    for (int i = 0; i < Munu.Length; i++)
                    {
                        WriteLine($"- {Munu[i]}");
                    }
                    ReadKey();




                    break;

                case 3:



                    Console.WriteLine("\n¿Está seguro de que desea salir del programa? (s/n)");
                    string confirmacion = Console.ReadLine().ToLower();
                    if (confirmacion == "s" || confirmacion == "si")
                    {
                        Console.WriteLine("¡Gracias por visitar el Bar El Pancracio!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Volviendo al menú principal...");
                        Console.ReadLine();
                        return;

                    }



                    break;
            }
        }
    }
}
