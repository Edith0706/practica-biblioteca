using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormPrincipal : Form
    {
        private Usuario usuario;
        private ServicioBiblioteca servicioBiblioteca; // Agrega una variable para almacenar una instancia de ServicioBiblioteca

        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            // Inicializa la instancia de ServicioBiblioteca
            servicioBiblioteca = new ServicioBiblioteca();

            CargarLibros();
        }

        private void CargarLibros()
        {
            // Obtén la lista de libros usando la instancia de ServicioBiblioteca
            List<Libro> libros = servicioBiblioteca.ObtenerLibros();

            // Asigna la lista de libros al origen de datos del DataGridView
            dataGridViewLibros.DataSource = libros;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibros.SelectedRows.Count > 0)
            {
                Libro libroSeleccionado = (Libro)dataGridViewLibros.SelectedRows[0].DataBoundItem;

                // Pasa la instancia de ServicioBiblioteca al constructor de FormPrestamo
                FormPrestamo formPrestamo = new FormPrestamo(usuario, libroSeleccionado, servicioBiblioteca);
                formPrestamo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un libro para realizar el préstamo.");
            }
        }
    }
}
