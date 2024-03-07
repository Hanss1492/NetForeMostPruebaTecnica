
namespace WinFormsNetForeMostTest.Entities;

public record InformeTransaccionDTO
{

    public string TipoTransaccion { get; set; }
    public string NombreProducto { get; set; }

    public int Cantidad { get; set; }
    public decimal PrecioUnitario { get; set; }

    public DateTime Fecha { get; set; }
}
