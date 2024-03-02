using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_II_Clases.Practica_Productos
{
    //se cambia de internal a public
    //para que se reconozca en todos
    //los namespace del proyecto
    public class Producto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public string? Imagen { get; set; }
        public int CantidadVendida { get; set; }
        public override string ToString()
        {
            return $"{Id},{Nombre},{Stock},{Precio}," +
                $"{Imagen},{CantidadVendida}";
        }
    }
}
