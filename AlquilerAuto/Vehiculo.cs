using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlquilerAuto
{
    public class Vehiculo
    {
        protected int id;
        protected string modelo;
        protected string marca;
        protected string kilometraje;
        protected string matricula;
        public Vehiculo() { }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }
        public string Marca
        {
            set {  marca = value;}
            get { return marca; }
        }
        public string Kilometraje
        {
            set { kilometraje=value; }
            get { return kilometraje; }
        }
        public string Matricula
        {
            set { matricula = value;}
            get {return marca; }
        }
        
    }
    
}