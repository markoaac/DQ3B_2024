using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unidad_I
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter esc =
                    new StreamWriter("C:/Pruebas/dq3b.txt", true);
                Pais p = new Pais();
                p.Nombre = txtNombre.Text;
                p.Continente = txtContinente.Text;
                p.Idioma = txtIdioma.Text;
                p.Poblacion = long.Parse(txtPoblacion.Text);
                p.Clima = bool.Parse(txtCalor.Text);
                esc.WriteLine(p.Nombre + "," + p.Continente+","+p.Poblacion+
                    ","+p.Idioma+","+p.Clima);
                esc.Close();
                txtNombre.Clear();
                txtNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Escribir");
            }
        }

        private void LecturaArchivo()
        {
            try
            {
                contenedor.Controls.Clear();
                StreamReader lec = new StreamReader("C:/Pruebas/dq3b.txt");
                string contenido = lec.ReadToEnd();
                lec.Close();
                string[] paises = contenido.Split("\n");
                for (int i = 0; i < paises.Length - 1; i++)
                {
                    string pais = paises[i];
                    string[]fila = pais.Split(",");
                    Label lbl = new Label();
                    Pais p = new Pais();
                    p.Nombre = fila[0];
                    p.Continente = fila[1];
                    p.Poblacion = long.Parse(fila[2]);
                    p.Idioma = fila[3];
                    p.Clima = bool.Parse(fila[4]);
                    lbl.Text = fila[0];
                    lbl.Tag = p;
                    lbl.Click += lbl_click;
                    if(p.Clima == true) {
                        lbl.BackColor = Color.Orange;
                        lbl.ForeColor = Color.White;
                    }
                    else
                    {
                        lbl.BackColor = Color.Blue;
                    }
                    contenedor.Controls.Add(lbl);
                }
                txtPaises.Text = contenido;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LecturaArchivo();
        }

        private void lbl_click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            Pais p = (Pais)lbl.Tag;
            //string info = "Nombre: " + p.Nombre +
            //    "\nContinente: " + p.Continente;
            string info = $"Nombre: {p.Nombre}\nContinente: {p.Continente}";
            MessageBox.Show(info);
        }
    }
}
