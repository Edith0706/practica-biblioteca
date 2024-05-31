using System;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        private ServicioBiblioteca servicioBiblioteca; // Declaración de la instancia de ServicioBiblioteca

        public Form1()
        {
            InitializeComponent();
            servicioBiblioteca = new ServicioBiblioteca(); // Inicialización de la instancia de ServicioBiblioteca
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var email = textBox1.Text;
            var usuario = servicioBiblioteca.AutenticarUsuario(email); // Llama al método de la instancia
            if (usuario != null)
            {
                var formPrincipal = new FormPrincipal(usuario);
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }
    }
}
