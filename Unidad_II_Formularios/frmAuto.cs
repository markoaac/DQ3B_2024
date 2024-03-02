using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_II_Clases.Practica_2;
using Unidad_II_Clases;
using Unidad_II_Controles;

namespace Unidad_II_Formularios
{
    public partial class frmAuto : Form
    {
        const string archivo = "C:/Pruebas/autos.txt";
        public frmAuto()
        {
            InitializeComponent();
            Leer();
        }

        private void Leer()
        {
            Lectura lex = new Lectura(archivo);
            string[] lineas = lex.Leer();
            for(int i = 0; i < lineas.Length - 1; i++)
            {
                string[] info = lineas[i].Split(",");
                Auto auto = new Auto();
                auto.Marca = info[0];
                auto.Modelo = info[1];
                auto.CapacidadMaxima = int.Parse(info[2]);
                auto.Litros = int.Parse(info[3]);
                auto.Estatus = info[4];
                auto.Foto = info[5];
                auto.Segundos = 
                    int.Parse(info[6].Replace("\r",""));
                ucAuto ucauto = new ucAuto();
                ucauto.Auto = auto;
                ucauto.LeerAuto();
                contenedor.Controls.Add(ucauto);
            }
            lex.Cerrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdBuscar.ShowDialog() == DialogResult.OK)
            {
                Auto auto = new Auto();
                auto.CapacidadMaxima = int.Parse(txtCapacidad.Text);
                auto.Estatus = "apagado";
                auto.Modelo = txtModelo.Text;
                auto.Marca = txtMarca.Text;
                auto.Litros = int.Parse(txtCapacidad.Text);
                auto.Foto = ofdBuscar.FileName;
                auto.Segundos = 0;
                ucAuto ucauto = new ucAuto();
                ucauto.Auto = auto;
                ucauto.setInfoCarro();
                contenedor.Controls.Add(ucauto);
            }
        }

        private void EscribirAutos()
        {
            Escritura esc = new Escritura(archivo, false);
            foreach (Control item in contenedor.Controls)
            {
                ucAuto ucauto = (ucAuto)item;
                esc.Escribir(ucauto.Auto.ToString());
            }
            esc.Cerrar();
        }

        private void frmAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            EscribirAutos();
        }
    }
}
