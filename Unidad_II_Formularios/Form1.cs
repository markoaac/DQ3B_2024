using Unidad_II_Clases;

namespace Unidad_II_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ofdBuscar.ShowDialog() == DialogResult.OK)
            {
                Mascota m = new Mascota();
                m.Nombre = "Rocket";
                m.Tipo = "Mapache";
                m.Edad = 10;
                m.Foto = ofdBuscar.FileName;
                ucMascota2.mascota = m;
                ucMascota2.setDatosMascota();
            }
        }
    }
}
