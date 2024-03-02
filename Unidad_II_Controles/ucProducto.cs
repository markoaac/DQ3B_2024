using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_II_Clases.Practica_Productos;
namespace Unidad_II_Controles
{
    public partial class ucProducto : UserControl
    {
        //Paso 1: declarar propiedad
        public Producto MiProducto { get; set; }

        //Paso 3: declaración de eventos
        public event EventHandler event_btnActualizar_click;
        public event EventHandler event_btnSeleccionar_click;

        public ucProducto()
        {
            InitializeComponent();
        }

        public void Actualizar_Interfaz_Agregar()
        {

            //Paso 2 vincular interfaz
            lblId.Text = MiProducto.Id.ToString();
            lblNombreProducto.Text = MiProducto.Nombre;
            lblPrecio.Text = MiProducto.Precio.ToString();
            lblStock.Text = MiProducto.Stock.ToString();
            pbProducto.Image = Image.FromFile(MiProducto.Imagen);

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (event_btnSeleccionar_click != null)
            {
                //no hacer referencia al sender
                //si no al control con la palabra this
                event_btnSeleccionar_click(this, e);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(event_btnActualizar_click  != null)
            {
                //no hacer referencia al sender
                //si no al control con la palabra this
                event_btnActualizar_click(this, e);
            }
        }
    }
}
