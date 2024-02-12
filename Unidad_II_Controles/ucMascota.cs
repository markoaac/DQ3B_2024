using Unidad_II_Clases;
namespace Unidad_II_Controles
{
    public partial class ucMascota : UserControl
    {
        public Mascota mascota { get; set; }

        public ucMascota()
        {
            InitializeComponent();
            
        }
        public void setDatosMascota()
        {
            txtEdad.Text = mascota.Edad.ToString();
            txtTipo.Text = mascota.Tipo;
            lblNombre.Text = mascota.Nombre;
            pbMascota.Image = Image.FromFile(mascota.Foto);        
        }
    }
}
