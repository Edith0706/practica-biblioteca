using System;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormPrestamo : Form
    {
        private Usuario usuario;
        private Libro libroSeleccionado;
        private ServicioBiblioteca servicioBiblioteca; // Agregamos un campo para almacenar la instancia de ServicioBiblioteca

        public FormPrestamo(Usuario usuario, Libro libroSeleccionado, ServicioBiblioteca servicioBiblioteca)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.libroSeleccionado = libroSeleccionado;
            this.servicioBiblioteca = servicioBiblioteca; // Asignar la instancia recibida como parámetro
            MostrarDetallesPrestamo();
        }

        private void MostrarDetallesPrestamo()
        {
            labelUsuarioId.Text = usuario.UsuarioId.ToString();
            labelPrestamoId.Text = "0"; // No se mostrará el ID del préstamo, ya que aún no se ha generado
            labelLibroId.Text = libroSeleccionado.LibroId.ToString();
            labelFechaPrestamo.Text = DateTime.Now.ToShortDateString(); // Fecha de hoy
            labelFechaDevolucion.Text = DateTime.Now.AddDays(7).ToShortDateString(); // Fecha de devolución en una semana

            // Deshabilitar los labels para que no puedan editarse
            labelPrestamoId.Enabled = false;
            labelUsuarioId.Enabled = false;
            labelLibroId.Enabled = false;
            labelFechaPrestamo.Enabled = false;
            labelFechaDevolucion.Enabled = false;
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaPrestamo = DateTime.Now;
            DateTime fechaDevolucion = DateTime.Now.AddDays(7);

            bool prestamoGuardado = servicioBiblioteca.GuardarPrestamo(usuario.UsuarioId, libroSeleccionado.LibroId, fechaPrestamo, fechaDevolucion);
            if (prestamoGuardado)
            {
                MessageBox.Show("Préstamo guardado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al guardar el préstamo. Inténtalo de nuevo.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Préstamo guardado correctamente.");
            this.Close();
        }
    }
}
