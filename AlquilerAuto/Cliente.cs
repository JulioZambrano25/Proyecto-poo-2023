using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilerAuto
{
    public class Cliente : Persona
    {
        public Cliente(int id,string nombre, string apellido, string correo, int telefono) {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correo = correo;
            this.telefono = telefono;   
            
        }
        public Cliente()
        {

        }

        public Usuario Usuario
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
    }

   
}