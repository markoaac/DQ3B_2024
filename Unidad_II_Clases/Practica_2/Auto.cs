using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_II_Clases.Practica_2
{
    public class Auto
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int CapacidadMaxima { get; set; }
        public int Litros { get; set; }
        public string? Estatus { get; set; }
        public string? Foto { get; set; }
        public int Segundos { get; set; }

        public override string ToString()
        {
            return $"{Marca},{Modelo},{CapacidadMaxima}," +
                $"{Litros},{Estatus},{Foto},{Segundos}";
        }
       
    }
}
