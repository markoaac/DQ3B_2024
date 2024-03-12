namespace Unidad_III_Formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread hiloProgressBar =
                new Thread(IncrementaProgressBar);
            hiloProgressBar.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(CicloFor);
            hilo.Start();
        }

        private void CicloFor()
        {
            for (long i = 1; i < 3000000000; i++)
            {

            }
            //MessageBox.Show("Fin");
            txtMensaje.Text = "fin";
        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i < progressBar1.Maximum)
            {
                i++;
                progressBar1.Value = i;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void IncrementaProgressBar()
        {
            int x = 0;
            while (x < progressBar1.Maximum)
            {
                x++;
                progressBar1.Value = x;
                Thread.Sleep(100);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread hiloMover = new
                Thread(moverCuadro);
            hiloMover.Start();
        }

        private void moverCuadro()
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int final = x + 200;
            while(x <= final)
            {
                pictureBox1.Location = new Point(x, y);
                x += 5;
                Thread.Sleep(200);
            }
        }
    }
}
