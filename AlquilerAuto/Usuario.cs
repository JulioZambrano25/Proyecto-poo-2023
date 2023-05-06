using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilerAuto
{
    public class Usuario : Persona
    {
        public Usuario(int id, string nombre, string apellido, string correo, int telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.telefono = telefono;

        }
        public Usuario()
        {

        }

        public Cliente Cliente
        {
            get => default;
            set
            {
            }
        }

        public Factura Factura
        {
            get => default;
            set
            {
            }
        }

        public Vehiculo Vehiculo
        {
            get => default;
            set
            {
            }
        }

        public Alquiler Alquiler
        {
            get => default;
            set
            {
            }
        }
        /*
            Se crea el metodo para poder agregar un cliente con la clausula de que genere un ingreso 
            para poder alquilar un auto
         */
        public void AgregarCliente()
        {
            Console.WriteLine("Ingrese el nombre del nuevo cliente:");
            Cliente cliente = new Cliente();
            cliente.Nombre= this.nombre;
            Console.WriteLine("Ingrese el apellido del cliente:");
            cliente.Apellido=this.apellido;
            Console.WriteLine("Ingrese el nùmero de telefono del nuevo cliente");
            cliente.Telefono=this.telefono; 

        }

        /*
            Se crea el metodo para poder modificar datos del cliente si el caso lo amerita
               
        */

        public void ModificarCliente()
        {
            Console.WriteLine("Ingrese el ID del cliente al que va a modificar los datos");
            Cliente cliente = new Cliente();
            cliente.Id=this.id;

        }
    }
}