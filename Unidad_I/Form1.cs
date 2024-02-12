namespace Unidad_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnPrueba.Click += evento_creado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string nombre = txtNombre.Text;
            //int nombre = 10;
            //object numero = 10;
            ////int n1 = Convert.ToInt32(numero);
            //int n1 = (int)numero;

            //string numero = "10";
            //int n1 = int.Parse(numero);
            //MessageBox.Show(nombre.ToString());
        }

        private void evento_creado(object s, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
