using Microsoft.EntityFrameworkCore;
using WinFormsNetForeMostTest.DataAccess.Models;
using WinFormsNetForeMostTest.DataAccess.Repository;
using WinFormsNetForeMostTest.DataAcess.Utils;
using WinFormsNetForeMostTest.Entities;

namespace WinFormsNetForeMostTest.BusinessLogic;

public class ProductoManager
{
    private readonly ProductoRepository _productoRepository;


    public ProductoManager()
    {
        _productoRepository = new ProductoRepository();   
    }

    public List<Producto> ObtenerProductos()
    {
        try
        {
            // Verificar si el producto existe en el inventario
            var productos = _productoRepository.ObtenerProductos();

            if (productos == null)
            {
                throw new Exception("No hay productos en el inventario.");
            }

            return productos;

        }
        catch (Exception ex)
        {
            // Manejar cualquier error y mostrar un mensaje al usuario
            Console.WriteLine($"Error al obtener los productos: {ex.Message}");
            throw;
        }
    }


    public List<InformeTransaccionDTO> InformeTransacciones()
    {
        try
        {
            // Verificar si el producto existe en el inventario
            var informes = _productoRepository.InformeTransacciones();

            if (informes == null)
            {
                throw new Exception("Sin Datos.");
            }

            return informes;

        }
        catch (Exception ex)
        {
            // Manejar cualquier error y mostrar un mensaje al usuario
            Console.WriteLine($"Error al obtener los informes: {ex.Message}");
            throw;
        }
    }
}
