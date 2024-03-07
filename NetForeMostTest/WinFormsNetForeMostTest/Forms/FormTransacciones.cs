using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsNetForeMostTest.BusinessLogic;
using WinFormsNetForeMostTest.DataAccess.Models;
using WinFormsNetForeMostTest.Entities;

namespace WinFormsNetForeMostTest.Forms
{
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
        }

        private void Transacciones_Load(object sender, EventArgs e)
        {
            ProductoManager productoManager = new ProductoManager();
            List<InformeTransaccionDTO> informeTransaccionDTOs = productoManager.InformeTransacciones();
            // Configuración del DataGridView
            dgInformeTransaccion.AutoGenerateColumns = false;
            dgInformeTransaccion.Columns.Clear();

            // Creación de columnas
            DataGridViewTextBoxColumn colTipoTransaccion = new DataGridViewTextBoxColumn();
            colTipoTransaccion.HeaderText = "Tipo Transaccion";
            colTipoTransaccion.DataPropertyName = "TipoTransaccion";
            colTipoTransaccion.Width = 200;
            dgInformeTransaccion.Columns.Add(colTipoTransaccion);

            DataGridViewTextBoxColumn colNombreProducto = new DataGridViewTextBoxColumn();
            colNombreProducto.HeaderText = "Nombre Producto";
            colNombreProducto.DataPropertyName = "NombreProducto";
            colNombreProducto.Width = 250;
            dgInformeTransaccion.Columns.Add(colNombreProducto);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.HeaderText = "Cantidad";
            colCantidad.DataPropertyName = "Cantidad";
            colCantidad.Width = 250;
            dgInformeTransaccion.Columns.Add(colCantidad);


            DataGridViewTextBoxColumn colPrecioUnitario = new DataGridViewTextBoxColumn();
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.DataPropertyName = "PrecioUnitario"; // Nombre de la propiedad en Producto
            colPrecioUnitario.Width = 100;
            dgInformeTransaccion.Columns.Add(colPrecioUnitario);

            DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
            colFecha.HeaderText = "Fecha";
            colFecha.DataPropertyName = "Fecha"; // Nombre de la propiedad en Producto
            colFecha.Width = 100;
            dgInformeTransaccion.Columns.Add(colFecha);


            // Establecer la lista de productos como origen de datos del DataGridView
            dgInformeTransaccion.DataSource = informeTransaccionDTOs;
        }
    }
}
