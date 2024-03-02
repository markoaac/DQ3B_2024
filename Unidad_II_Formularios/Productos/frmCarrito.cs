using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_II_Controles;
using Unidad_II_Clases.Practica_Productos;

namespace Unidad_II_Formularios.Productos
{
    public partial class frmCarrito : Form
    {
        Control.ControlCollection controles;
        List<Producto> productos;
        public frmCarrito(Control.ControlCollection controles)
        {
            InitializeComponent();
            this.controles = controles;
            productos = new List<Producto>();
            foreach (var item in Globales.carrito)
            {
                productos.Add(item.MiProducto);
            }
            dataGridView1.DataSource = productos;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Producto item in productos)
            {
                foreach (ucProducto uc in controles)
                {
                    if (uc.MiProducto.Id.ToString() == item.Id.ToString())
                    {
                        uc.MiProducto.Stock -= item.CantidadVendida;
                        uc.Actualizar_Interfaz_Agregar();
                    }
                }
            }
            Globales.carrito.Clear();
            Close();
        }

      
    }
}
