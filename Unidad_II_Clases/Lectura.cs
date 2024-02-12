using System.IO;
namespace Unidad_II_Clases
{
    public class Lectura
    {
        StreamReader lec;
        public Lectura(string ruta)
        {
            try
            {
                lec = new StreamReader(ruta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string[] Leer()
        {
            string[] lineas;
            try
            {
                string contenido = lec.ReadToEnd();
                lineas = contenido.Split("\n");
            }
            catch (Exception)
            {
                lineas = null;
            }
            return lineas;
        }

        public void Cerrar()
        {
            if(lec != null )
            {
                lec.Close();
            }
        }
    }
}
