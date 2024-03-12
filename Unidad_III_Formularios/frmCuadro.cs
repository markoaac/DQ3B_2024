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
    public partial class frmCuadro : Form
    {
        public frmCuadro()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            pictureBox1.Location = new Point(0, 0);
            Thread hiloMoverCuadro = 
                new Thread(moverCuadro);
            hiloMoverCuadro.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void moverCuadro()
        {
            int alto = Height; // Height = alto
            int ancho = Width; // Width = ancho

            int xc = pictureBox1.Location.X;
            int yc = pictureBox1.Location.Y;

            while(xc + pictureBox1.Width <= ancho)
            {
                pictureBox1.Location = new Point(xc, yc);
                xc += 15;
                Thread.Sleep(200);
            }
            while(yc + pictureBox1.Height <= alto) {
                pictureBox1.Location = new Point(xc, yc);
                yc += 15;
                Thread.Sleep(200);
            }
            while (xc > 0)
            {
                pictureBox1.Location = new Point(xc, yc);
                xc -= 15;
                Thread.Sleep(200);
            }
            while (yc > 0)
            {
                pictureBox1.Location = new Point(xc, yc);
                yc -= 15;
                Thread.Sleep(200);
            }
        }
    }
}
