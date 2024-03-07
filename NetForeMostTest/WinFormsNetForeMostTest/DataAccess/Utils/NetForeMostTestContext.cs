using Microsoft.EntityFrameworkCore;
using WinFormsNetForeMostTest.DataAccess.Models;

namespace WinFormsNetForeMostTest.DataAcess.Utils;

public class NetForeMostTestContext : DbContext
{
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<Venta> Ventas { get; set; }

    public NetForeMostTestContext(DbContextOptions<NetForeMostTestContext> options)
        : base(options)
    {

    }
}
