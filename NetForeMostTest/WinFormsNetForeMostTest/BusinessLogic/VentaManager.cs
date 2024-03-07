using Microsoft.EntityFrameworkCore;
using WinFormsNetForeMostTest.DataAccess.Repository;
using WinFormsNetForeMostTest.DataAcess.Utils;

namespace WinFormsNetForeMostTest.BusinessLogic;

public class VentaManager
{
    private readonly ProductoRepository _productoRepository;
    private readonly VentaRepository _ventaRepository;

    public VentaManager()
    {
        _productoRepository = new ProductoRepository();
        _ventaRepository = new VentaRepository();
    }
    public void RegistrarVenta(int productoID, int cantidadVendida)
    {
        try
        {
            // Verificar si el producto existe en el inventario
            var producto = _productoRepository.ObtenerProductoPorId(productoID);

            if (producto == null)
            {
                throw new Exception("El producto no existe en el inventario.");
            }

            // Verificar si hay suficiente cantidad disponible del producto
            if (producto.CantidadDisponible < cantidadVendida)
            {
                throw new Exception("No hay suficiente cantidad disponible del producto.");
            }

            // Registrar la venta
            _ventaRepository.RegistrarVenta(producto.ProductoID, cantidadVendida);

            // Actualizar la cantidad disponible del producto en el inventario
            _productoRepository.ActualizarCantidadDisponible(producto.ProductoID, -cantidadVendida);
        }
        catch (Exception ex)
        {
            // Manejar cualquier error y mostrar un mensaje al usuario
            Console.WriteLine($"Error al registrar la venta: {ex.Message}");
            throw;
        }
    }
}
