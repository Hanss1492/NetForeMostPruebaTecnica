using System.Security.Principal;
using WinFormsNetForeMostTest.BusinessLogic;
using WinFormsNetForeMostTest.DataAccess.Models;
using WinFormsNetForeMostTest.DataAcess.Utils;

namespace WinFormsNetForeMostTest;

public partial class RegCompras : Form
{
    public event EventHandler FormClosedEvent;
    public RegCompras()
    {
        InitializeComponent(); 

    }

    private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }

        // only allow one decimal point
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

    private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
        {
            e.Handled = true;
        }

        // only allow one decimal point
        if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
        {
            e.Handled = true;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        try
        {

            // Obtener el ID del producto seleccionado
            int productoId = Convert.ToInt32(cbproducto.SelectedValue);

            int cantidadComprada = Convert.ToInt32(txtcantidad.Text);
            decimal precioUnitario = Convert.ToDecimal(txtprecio.Text);

            // Verificar si los campos están vacíos
            if (string.IsNullOrEmpty(cbproducto.SelectedValue.ToString()) || cantidadComprada <= 0 || precioUnitario <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Registrar la compra utilizando el CompraManager
            CompraManager compraManager = new CompraManager();
            compraManager.RegistrarCompra(productoId, cantidadComprada, precioUnitario);

            // Mostrar mensaje de éxito
            MessageBox.Show("La compra se ha registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos del formulario después de registrar la compra
            LimpiarCampos();
        }
        catch (Exception ex)
        {
            // Mostrar mensaje de error en caso de excepción
            MessageBox.Show($"Error al registrar la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }


    // Método para limpiar los campos del formulario
    private void LimpiarCampos()
    {
        cbproducto.SelectedIndex = -1;
        txtcantidad.Text = "";
        txtprecio.Text = "";
    }

    private void RegCompras_Load(object sender, EventArgs e)
    {
        // Registrar la compra utilizando el CompraManager
        ProductoManager productoManager = new ProductoManager();
        // Obtener la lista de productos
        List<Producto> productos = productoManager.ObtenerProductos();
        // Limpiar ComboBox antes de agregar elementos
        cbproducto.Items.Clear();
        // Agregar productos al ComboBox


        cbproducto.DataSource = productos;
        cbproducto.DisplayMember = "ProductoNombre";
        cbproducto.ValueMember = "ProductoID";
        cbproducto.SelectedIndex = -1;
    }

    private void RegCompras_FormClosed(object sender, FormClosedEventArgs e)
    {
        FormClosedEvent?.Invoke(this, EventArgs.Empty);
    }
}
