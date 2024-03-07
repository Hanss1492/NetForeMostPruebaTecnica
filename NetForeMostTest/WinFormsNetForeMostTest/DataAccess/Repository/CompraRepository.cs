using System;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsNetForeMostTest.DataAccess.Repository
{
    public class CompraRepository
    {
        private readonly string _connectionString;

        public CompraRepository()
        {
            _connectionString = AppConfig.ConnectionString;
        }

        public void RegistrarCompra(int productoID, int cantidadComprada, decimal precioUnitario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("RegistrarCompra", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ProductoID", productoID);
                        command.Parameters.AddWithValue("@CantidadComprada", cantidadComprada);
                        command.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                        command.Parameters.AddWithValue("@FechaCompra", DateTime.Now);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error y mostrar un mensaje al usuario
                Console.WriteLine($"Error al registrar la compra: {ex.Message}");
                throw;
            }

        }
    }
}