using System;
using System.Data;
using System.Data.SqlClient;
using WinFormsNetForeMostTest.DataAcess.Utils;

namespace WinFormsNetForeMostTest.DataAccess.Repository
{
    public class VentaRepository
    {
        private readonly string _connectionString;

        public VentaRepository()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public void RegistrarVenta(int productoID, int cantidadVendida)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("RegistrarVenta", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductoID", productoID);
                        command.Parameters.AddWithValue("@CantidadVendida", cantidadVendida);
                        command.Parameters.AddWithValue("@FechaVenta", DateTime.Now);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error y mostrar un mensaje al usuario
                Console.WriteLine($"Error al registrar la venta: {ex.Message}");
                throw;
            }
        }

    }
}
