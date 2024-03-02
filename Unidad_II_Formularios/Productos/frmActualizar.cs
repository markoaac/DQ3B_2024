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

namespace Unidad_II_Formularios.Productos
{
    public partial class frmActualizar : Form
    {
        ucProducto ucp;
        public frmActualizar(ucProducto ucp)
        {
            InitializeComponent();
            this.ucp = ucp;
            this.txtNombreProducto.Text =
                ucp.MiProducto.Nombre;
            this.txtPrecio.Text =
                ucp.MiProducto.Precio.ToString();
            this.txtStock.Text =
                ucp.MiProducto.Stock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucp.MiProducto.Nombre = txtNombreProducto.Text;
            ucp.MiProducto.Precio = decimal.Parse(txtPrecio.Text);
            ucp.MiProducto.Stock = int.Parse(txtStock.Text);
            ucp.MiProducto.CantidadVendida = 0;
            if (chkCambio.Checked)
            {
                if (openFileDialog1.ShowDialog() ==
                    DialogResult.OK)
                {
                    ucp.MiProducto.Imagen = openFileDialog1.FileName;
                }
            }
            ucp.Actualizar_Interfaz_Agregar();
            this.Close();

        }

        
    }
}
