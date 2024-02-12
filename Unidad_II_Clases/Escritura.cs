using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_II_Clases
{
    public class Escritura
    {
        StreamWriter esc;
        public Escritura(string ruta, bool append)
        {
            try
            {
                esc = new StreamWriter(ruta, append);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Escribir(string texto)
        {
            try
            {
                esc.WriteLine(texto);
            }
            catch (Exception)
            {
            }
        }

        public void Cerrar()
        {
            if (esc != null)
            {
                esc.Close();
            }
        }
    }
}
