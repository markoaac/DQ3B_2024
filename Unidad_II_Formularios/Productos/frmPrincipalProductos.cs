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
using Unidad_II_Controles;
namespace Unidad_II_Formularios.Productos
{
    public partial class frmPrincipalProductos : Form
    {

        public frmPrincipalProductos()
        {
            InitializeComponent();
            Globales.carrito = new List<ucProducto>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                #region Paso 1 crear objeto articulo (Producto)
                Producto articulo = new Producto();
                articulo.Nombre = txtNombreProducto.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Stock = int.Parse(txtStock.Text);
                articulo.Imagen = openFileDialog1.FileName;
                articulo.Id = Guid.NewGuid();
                articulo.CantidadVendida = 0;
                #endregion

                #region Paso 2 crear ucProducto
                ucProducto ucp = new ucProducto();
                ucp.MiProducto = articulo;
                ucp.event_btnActualizar_click += Ucp_event_btnActualizar_click;
                ucp.event_btnSeleccionar_click += Ucp_event_btnSeleccionar_click;
                #endregion

                #region Paso 3 Actualizar IG y agregar a contenedor
                ucp.Actualizar_Interfaz_Agregar();
                contenedor.Controls.Add(ucp);
                #endregion

            }
        }

        private void Ucp_event_btnSeleccionar_click(object? sender, EventArgs e)
        {
            ucProducto uc = (ucProducto)sender;
            frmSeleccionar f = new frmSeleccionar(uc);
            f.ShowDialog();

        }

        private void Ucp_event_btnActualizar_click(object? sender, EventArgs e)
        {
            ucProducto articulo = (ucProducto)sender;
            frmActualizar f = new frmActualizar(articulo);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCarrito f = new frmCarrito(contenedor.Controls);
            f.ShowDialog();
            
        }
    }
}
