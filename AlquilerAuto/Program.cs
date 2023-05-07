using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar los datos a consola
            Usuario usuario = new Usuario();
            Console.WriteLine("Bienvenidos al sistema de alquiler de vehiculos");
            Console.WriteLine("A continuacion ingrese sus credeciales para continuar con el ingreso de clientes");
            usuario.Nombre= Console.ReadLine();
            Console.WriteLine("Bienvenido"+ usuario.Nombre);
            Console.WriteLine("Ingrese los datos para el nuevo cliente");
            usuario.AgregarCliente();
            
        }
    }
}
