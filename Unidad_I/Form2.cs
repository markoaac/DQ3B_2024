using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_I
{
    public partial class Form2 : Form
    {
        int cont = 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PictureBox pb = new PictureBox();
            pb.Name = "pb" + cont;
            pb.Tag = 0;
            pb.Size = new Size(100,100);
            pb.Image = 
                Image.FromFile("C:/Pruebas/apagado.png");
            pb.SizeMode = 
                PictureBoxSizeMode.StretchImage;
            pb.Click += pb_click;
            contenedor.Controls.Add(pb);
            cont++;
        }
        private void pb_click(object control, EventArgs e)
        {
            //PictureBox pb = (PictureBox)control;
            PictureBox pb = control as PictureBox;
            string nombre = pb.Name;
            int nc = Convert.ToInt32(pb.Tag);
            nc++;
            pb.Tag = nc;
            if(nc > 10)
            {
                MessageBox.Show("Fundido");
            }
            else
            {
                if (nc % 2 != 0)
                {
                    pb.Image =
                    Image.FromFile("C:/Pruebas/encendido.png");
                }
                else
                {
                    pb.Image =
                    Image.FromFile("C:/Pruebas/apagado.png");
                }
            }
            

            //MessageBox.Show("Nombre: " + pb.Name
            //    + " Número:  " + num);
            //MessageBox.Show("Número de clicks: " + nc);
        }
    }
}
