using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WinFormsNetForeMostTest.DataAccess.Models;
using WinFormsNetForeMostTest.DataAcess.Utils;
using WinFormsNetForeMostTest.Entities;

namespace WinFormsNetForeMostTest.DataAccess.Repository
{
    public class ProductoRepository
    {
        private readonly string _connectionString;

        public ProductoRepository()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Productos";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Producto producto = new Producto
                    {
                        ProductoID = Convert.ToInt32(reader["ProductoID"]),
                        ProductoNombre = reader["ProductoNombre"].ToString(),
                        ProductoDescripcion = reader["ProductoDescripcion"].ToString(),
                        CantidadDisponible = Convert.ToInt32(reader["CantidadDisponible"]),
                    };
                    productos.Add(producto);
                }
            }
            return productos;
        }

        public Producto ObtenerProductoPorId(int productoID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Productos WHERE ProductoID = @ProductoID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductoID", productoID);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Producto producto = new Producto
                    {
                        ProductoID = Convert.ToInt32(reader["ProductoID"]),
                        ProductoNombre = reader["ProductoNombre"].ToString(),
                        ProductoDescripcion = reader["ProductoDescripcion"].ToString(),
                        CantidadDisponible = Convert.ToInt32(reader["CantidadDisponible"])
                    };
                    return producto;
                }
                return null;
            }
        }

        public void ActualizarCantidadDisponible(int productoID, int cantidadComprada)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Productos SET CantidadDisponible = CantidadDisponible + @CantidadComprada WHERE ProductoID = @ProductoID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CantidadComprada", cantidadComprada);
                command.Parameters.AddWithValue("@ProductoID", productoID);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<InformeTransaccionDTO> InformeTransacciones()
        {
            List<InformeTransaccionDTO> transacciones = new List<InformeTransaccionDTO>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "EXEC GenerarInformeTransacciones";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    InformeTransaccionDTO transaccion = new InformeTransaccionDTO
                    {
                        TipoTransaccion = reader["TipoTransaccion"].ToString(),
                        NombreProducto = reader["NombreProducto"].ToString(),
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        PrecioUnitario = reader["PrecioUnitario"] != DBNull.Value ? Convert.ToDecimal(reader["PrecioUnitario"]) : 0,
                        Fecha = Convert.ToDateTime(reader["Fecha"])
                    };
                    transacciones.Add(transaccion);
                }
            }
            return transacciones;
        }


    }
}
