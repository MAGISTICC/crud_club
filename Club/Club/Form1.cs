namespace Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // Crea una instancia del nuevo formulario
            Registro formulario2 = new Registro();

            // Muestra el nuevo formulario
            formulario2.Show();

        }

        private void btnInicioS_Click(object sender, EventArgs e)
        {
            IniSesion iniciosesion = new IniSesion();
            iniciosesion.Show();
        }
    }
}