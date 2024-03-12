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
    public partial class frmDelegados : Form
    {
        public frmDelegados()
        {
            InitializeComponent();
            pictureBox1.Location = new Point(0, 0);
        }

        //Paso 1. Declarar delegado
        //NOTA: declarar parámetros necesarios
        //según el proceso
        private delegate void delegado_aumentar(int x);
        private delegate void delegado_mover(int x, int y);

        //Paso 2. Crear método que invoque delegado
        //Agrega un método para instanciar delegado
        //NOTA: El método siguiente debe tener
        //los mismos parámetros que el delegado
        private void llamar_delegado_aumentar(int i)
        {
            if (InvokeRequired)
            {
                //Paso 2.1 Instanciar delegado
                delegado_aumentar da =
                    new delegado_aumentar(llamar_delegado_aumentar);
                //object[] p = new object[1];
                //p[0] = i;
                object[] p = new object[] { i };
                Invoke(da, p);
            }
            else
            {
                barra.Value = i;
            }
        }

        private void llamar_delegado_mover(int x, int y)
        {
            if (InvokeRequired)
            {
                //Paso 2.1 Instanciar delegado
                delegado_mover da =
                    new delegado_mover(llamar_delegado_mover);
                //object[] p = new object[1];
                //p[0] = i;
                object[] p = new object[] { x, y };
                Invoke(da, p);
            }
            else
            {
                pictureBox1.Location = new Point(x, y);
            }
        }

        //Paso 3. Utilizar el método agregado anteriormente
        //para cumplir el objetivo (llenar el progress bar)
        //NOTA: el Subproceso (hilo) no accede de manera directa
        //Solo a través del delegado
        private void llenar_barra()
        {
            for (int i = 1; i <= 100; i++)
            {
                llamar_delegado_aumentar(i);
                Thread.Sleep(100);
            }
        }

        private void moverCuadro()
        {
            int alto = Height; // Height = alto
            int ancho = Width; // Width = ancho

            int xc = pictureBox1.Location.X;
            int yc = pictureBox1.Location.Y;

            while (xc + pictureBox1.Width <= ancho)
            {
                llamar_delegado_mover(xc, yc);
                xc += 15;
                Thread.Sleep(200);
            }
            while (yc + pictureBox1.Height <= alto)
            {
                llamar_delegado_mover(xc, yc);
                yc += 15;
                Thread.Sleep(200);
            }
            while (xc > 0)
            {
                llamar_delegado_mover(xc, yc);
                xc -= 15;
                Thread.Sleep(200);
            }
            while (yc > 0)
            {
                llamar_delegado_mover(xc, yc);
                yc -= 15;
                Thread.Sleep(200);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloBarra = new Thread(llenar_barra);
            hiloBarra.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloCuadro = new Thread(moverCuadro);
            hiloCuadro.Start();
        }
    }
}
