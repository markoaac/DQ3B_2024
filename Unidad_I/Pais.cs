using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_I
{
    public class Pais
    {
        //private string nombre;
        //public string getNombre()
        //{
        //    return nombre; 
        //}
        //public void setNombre(string nombre)
        //{
        //    this.nombre = nombre;
        //}
        public string? Nombre { get; set; }
        public string Continente { get; set; }
        public long Poblacion { get; set; }
        public string Idioma { get; set; }
        public bool Clima { get; set; }
    }
}
