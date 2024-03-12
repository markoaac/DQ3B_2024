using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_III_Formularios
{
    public partial class frmPingPong : Form
    {
        bool movimiento;
        Thread hiloPelota;
        int vidas;
        public frmPingPong()
        {
            InitializeComponent();
            movimiento = true;
            vidas = 3;
            lblPuntos.Text = $"Vidas: {vidas}";
            hiloPelota = new Thread(mover_bolita);
            hiloPelota.Start();

        }

        //Paso 1. Definir delegado
        private delegate void delegado_mover_bolita(int x, int y);
        private delegate void delegado_puntos(string texto);

        //Paso 2. Invocar delegado
        private void metodo_mover(int x, int y)
        {
            if (InvokeRequired)
            {
                //Paso 2.1 Instanciar delegado
                delegado_mover_bolita da =
                    new delegado_mover_bolita(metodo_mover);
                //object[] p = new object[1];
                //p[0] = i;
                object[] p = new object[] { x, y };
                Invoke(da, p);
            }
            else
            {
                bolita.Location = new Point(x, y);
            }
        }

        private void metodo_puntos(string texto)
        {
            if (InvokeRequired)
            {
                delegado_puntos dp = new delegado_puntos(metodo_puntos);
                object[] p = new object[] { texto };
                Invoke(dp, p);
            }
            else
            {
                lblPuntos.Text = texto;
            }
        }
        //Método para movimiento del picturebox(bolita)
        private void mover_bolita()
        {
            bool izq = false;
            bool bajar = false;
            int x = bolita.Location.X;
            int y = bolita.Location.Y;
            Random rand = new Random();
            int rx = rand.Next(40, 50);
            int ry = rand.Next(40, 50);
            while (movimiento)
            {
                if (izq)
                {
                    x -= rx;
                }
                else
                {
                    x += rx;
                }

                if (bajar)
                {
                    y += ry;
                }
                else
                {
                    y -= ry;
                }
                metodo_mover(x, y);
                Thread.Sleep(200);

                if (x + bolita.Width > Width)
                {
                    izq = true;
                    rx = rand.Next(30, 50);
                }

                if (x < 0)
                {
                    izq = false;
                    rx = rand.Next(30, 50);
                }

                if (y + bolita.Height > Height)
                {
                    bajar = false;
                    ry = rand.Next(30, 50);
                    vidas -= 1;
                    metodo_puntos($"Vidas: {vidas}");
                    if (vidas == 0)
                    {
                        movimiento = false;
                        //MessageBox.Show("El juego ha concluido");
                        metodo_puntos("Juego finalizado");
                    }
                }

                if (y < 0)
                {
                    bajar = true;
                    ry = rand.Next(30, 50);
                }
            }
        }

        private void frmPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (barra.Location.X + barra.Width < Width)
                {
                    barra.Location = new Point(
                        barra.Location.X + 35,
                        barra.Location.Y
                        );
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                if (barra.Location.X > 0)
                {
                    barra.Location = new Point(
                        barra.Location.X - 35,
                        barra.Location.Y
                        );
                }
            }


        }

        private void frmPingPong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
