using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDGVLibreTema
{
    class Ciudadano
    {
        private string nombre;
        private string apellido;
        private int edad;
        private string pais;
        private string ciudad;
        private string barrio;
        private string direccion;
        private int telefono;
        public Ciudadano(string nom, string ap, int ed, string pa, string cd, string bar, string dir, int tel)
        {
            nombre = nom;
            apellido = ap;
            edad = ed;
            pais = pa;
            ciudad = cd;
            barrio = bar;
            direccion = dir;
            telefono = tel;
        }
        public Ciudadano()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            edad = 0;
            pais = string.Empty;
            ciudad = string.Empty;
            barrio = string.Empty;
            direccion = string.Empty;
            telefono = 0;
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }
        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }
        public String Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }
        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
