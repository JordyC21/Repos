using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar
{
    public abstract class Persona
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad; 
        }

        public void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es  {Nombre} {Apellido}");
        }

    }

    interface IAccionDelEmpleado
    {
        string TomarOrdenCliente();
        string ServirBebida();
        string SaludarCliente();
        decimal HacerLaCuenta();
    }

}
