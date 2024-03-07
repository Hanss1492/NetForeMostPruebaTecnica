using System;
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
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Compras (ProductoID, CantidadComprada, PrecioUnitario, FechaCompra) " +
                               "VALUES (@ProductoID, @CantidadComprada, @PrecioUnitario, @FechaCompra)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductoID", productoID);
                command.Parameters.AddWithValue("@CantidadComprada", cantidadComprada);
                command.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                command.Parameters.AddWithValue("@FechaCompra", DateTime.Now);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
