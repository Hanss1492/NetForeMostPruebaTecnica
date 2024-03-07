
namespace WinFormsNetForeMostTest.DataAccess.Models;

public class Compra
{
    public int CompraID { get; set; }
    public int ProductoID { get; set; }

    public int CantidadComprada { get; set; }

    public decimal PrecioUnitario { get; set; }

    public DateTime FechaCompra{ get; set; }

}
