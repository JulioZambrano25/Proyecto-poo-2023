using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilerAuto
{
    public class Persona
    {
        protected int id;
        protected int codigoUsuario;
        protected string nombre;
        protected string apellido;
        protected string correo;
        protected int telefono;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public int CodigoUsuario
        {
            set { codigoUsuario = value;}
            get { return codigoUsuario;}
        }
        public string Nombre
        {
            set { nombre = value; } 
            get { return nombre; }  
        }
        public string Apellido
        {
            set { apellido = value; }   
            get { return apellido; }    
        }
        public string Correo
        {
            set { correo = value; } 
            get { return correo; }  
        }
        public int Telefono
        {
            set { telefono = value; }  
            get { return telefono; }
        }

    }
    
}