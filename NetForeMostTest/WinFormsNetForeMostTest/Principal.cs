
using System.Windows.Forms;
using WinFormsNetForeMostTest.BusinessLogic;
using WinFormsNetForeMostTest.DataAccess.Models;
using WinFormsNetForeMostTest.Forms;

namespace WinFormsNetForeMostTest
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void registrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegCompras formularioCompras = new RegCompras();
            formularioCompras.FormClosedEvent += UpdateGrid;

            formularioCompras.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegVentas formularioVentas = new RegVentas();
            formularioVentas.FormClosedEvent += UpdateGrid;
            formularioVentas.ShowDialog();
        }

        private void consultarInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

            ProductoManager productoManager = new ProductoManager();
            List<Producto> productos = productoManager.ObtenerProductos();
            // Configuración del DataGridView
            dgInventario.AutoGenerateColumns = false;
            dgInventario.Columns.Clear();

            // Creación de columnas
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Producto Nombre";
            colNombre.DataPropertyName = "ProductoNombre"; // Nombre de la propiedad en Producto
            colNombre.Width = 300;
            dgInventario.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad Disponible";
            colCantidad.DataPropertyName = "CantidadDisponible"; // Nombre de la propiedad en Producto
            colCantidad.Width = 300;
            dgInventario.Columns.Add(colCantidad);

            // Establecer la lista de productos como origen de datos del DataGridView
            dgInventario.DataSource = productos;
        }

        private void UpdateGrid(object sender, EventArgs e)
        {
            ProductoManager productoManager = new ProductoManager();
            List<Producto> productos = productoManager.ObtenerProductos();
            // Configuración del DataGridView
            dgInventario.AutoGenerateColumns = false;
            dgInventario.Columns.Clear();

            // Creación de columnas
            DataGridViewTextBoxColumn colNombre = new DataGridViewTextBoxColumn();
            colNombre.HeaderText = "Producto Nombre";
            colNombre.DataPropertyName = "ProductoNombre"; // Nombre de la propiedad en Producto
            colNombre.Width = 300;
            dgInventario.Columns.Add(colNombre);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad Disponible";
            colCantidad.DataPropertyName = "CantidadDisponible"; // Nombre de la propiedad en Producto
            colCantidad.Width = 300;
            dgInventario.Columns.Add(colCantidad);
            dgInventario.DataSource = null;
            dgInventario.DataSource = productos;
        }

        private void informeTransacciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transacciones formTransacciones = new Transacciones();
            formTransacciones.ShowDialog();
        }
    }
}