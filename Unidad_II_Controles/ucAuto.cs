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

namespace Unidad_II_Controles
{
    public partial class ucAuto : UserControl
    {
        public Auto Auto { get; set; }
        
        public ucAuto()
        {
            InitializeComponent();
        }

        public void setInfoCarro()
        {
            txtMarca.Text = Auto.Marca;
            txtModelo.Text = Auto.Modelo;
            txtCapacidadMaxima.Text = Auto.CapacidadMaxima.ToString();
            txtLitros.Text = Auto.Litros.ToString();
            pbAuto.Image = Image.FromFile(Auto.Foto);
            btnApagar.Enabled = false;
            btnCargar.Enabled = false;
            pbarGasolina.Maximum = Auto.CapacidadMaxima;
            pbarGasolina.Value = Auto.CapacidadMaxima;
            tmrGasolina.Tick += TmrGasolina_Tick;
            
            //tmrGasolina.Enabled = true;
        }

        private void TmrGasolina_Tick(object sender, EventArgs e)
        {
            if (Auto.Segundos == 10)
            {
                Auto.Litros -= 10;
                pbarGasolina.Value -= 10;
                txtLitros.Text = Auto.Litros.ToString();
                Auto.Segundos = 0;
                if (Auto.Litros == 0 || pbarGasolina.Value == 0)
                {
                    tmrGasolina.Stop();
                    btnApagar.Enabled = false;
                    btnPrender.Enabled = true;
                    btnCargar.Enabled = true;
                }
            }
            else
            {
                Auto.Segundos++;
            }
        }

        private void btnPrender_Click(object sender, EventArgs e)
        {
            if (Auto.Litros == 0 || pbarGasolina.Value == 0)
            {
                MessageBox.Show("No se puede encender porque no hay gasolina");
            }
            else
            {
                if (tmrGasolina.Enabled == false)
                {
                    tmrGasolina.Enabled = true;
                }
                else
                {
                    tmrGasolina.Start();
                }
                btnPrender.Enabled = false;
                btnCargar.Enabled = false;
                btnApagar.Enabled = true;
                Auto.Estatus = "prendido";
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            tmrGasolina.Stop();
            btnApagar.Enabled = false;
            btnPrender.Enabled = true;
            btnCargar.Enabled = true;
            Auto.Estatus = "apagado";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(Auto.Litros == Auto.CapacidadMaxima)
            {
                MessageBox.Show("Tanque lleno");
            }
            else
            {
                Auto.Segundos = 0;
                Auto.Litros = Auto.CapacidadMaxima;
                pbarGasolina.Value = Auto.CapacidadMaxima;
                txtLitros.Text = Auto.CapacidadMaxima.ToString();
            }
        }

        public void LeerAuto()
        {
            tmrGasolina.Tick += TmrGasolina_Tick;
            txtCapacidadMaxima.Text = 
                Auto.CapacidadMaxima.ToString();
            pbAuto.Image = Image.FromFile(Auto.Foto);
            txtMarca.Text = Auto.Marca;
            txtModelo.Text = Auto.Modelo;
            pbarGasolina.Maximum = Auto.CapacidadMaxima;
            pbarGasolina.Value = Auto.Litros;
            txtLitros.Text = Auto.Litros.ToString();
            if(Auto.Estatus == "apagado")
            {
                btnApagar.Enabled = false;
                btnPrender.Enabled = true;
                btnCargar.Enabled = true;
            }
            else
            {
                btnApagar.Enabled = true;
                btnPrender.Enabled = false;
                btnCargar.Enabled = false;
                if (tmrGasolina.Enabled == false)
                {
                    tmrGasolina.Enabled = true;
                }
                else
                {
                    tmrGasolina.Start();
                }
            }

        }
    }
}
