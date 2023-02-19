using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bar
{
    public class Cliente : Persona
    {
        public Cliente(string nombreCliente, string apellidoCliente, int EdadCliente) : base(nombreCliente, apellidoCliente, EdadCliente)
        {

        }

        public void SolicitarDatos()
        {
            Console.WriteLine("\nSu nombre por favor: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Su apellido por favor: ");
            Apellido = Console.ReadLine();
            VerificarEdad();
        }

        Empleado empleado = new Empleado("", " ", 0);
        public bool VerificarEdad()
        {
            Console.WriteLine("Ingrese su edad:");
            string edadInput = Console.ReadLine();

            int edad;
            edad = Edad;
            if (int.TryParse(edadInput, out edad))
            {
                if (edad >= 18)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Felicidades {Nombre} {Apellido}, tienes {edad} años, cumples con la edad adecuada para pasar al bar.");
                    Console.ResetColor();
                    empleado.SaludarCliente();

                    return true;


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Lo siento {Nombre} {Apellido}, tienes {edad} años, no cumples con la edad adecuada para entrar a este bar.");
                    Console.ResetColor();
                    ReadLine();
                    return false;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("La edad ingresada no es válida. Inténtelo de nuevo.");
                ReadLine();
                Console.ResetColor();
                return false;
            }


        }

        public String GetDatosCliente()
        {
        
           string DatosCliente= "Datos del cliente: " + Nombre + Apellido + Edad;
            return DatosCliente; 
        }

    }
}
