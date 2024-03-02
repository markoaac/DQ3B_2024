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
    public partial class frmSeleccionar : Form
    {
        ucProducto ucp;
        public frmSeleccionar(ucProducto ucp)
        {
            InitializeComponent();
            this.ucp = ucp;
            lblNombreProducto.Text = ucp.MiProducto.Nombre;
            lblStock.Text = ucp.MiProducto.Stock.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                if (cantidad > ucp.MiProducto.Stock)
                {
                    MessageBox.Show("Cantidad insuficiente");
                }
                else
                {
                    int index = getIndexProducto(ucp.MiProducto.Id.ToString());
                    if (index != -1)
                    {
                        Globales.carrito[index].MiProducto.CantidadVendida 
                            += cantidad;
                        if (Globales.carrito[index].MiProducto.CantidadVendida >
                            Globales.carrito[index].MiProducto.Stock)
                        {
                            Globales.carrito[index].MiProducto.CantidadVendida =
                                Globales.carrito[index].MiProducto.Stock;
                        }
                    }
                    else
                    {
                        ucp.MiProducto.CantidadVendida = cantidad;
                        Globales.carrito.Add(ucp);
                        MessageBox.Show("Agregado");
                    }
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private int getIndexProducto(string id)
        {
            for(int i = 0; i < Globales.carrito.Count; i++)
            {
                if (Globales.carrito[i].MiProducto.Id.ToString() == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
