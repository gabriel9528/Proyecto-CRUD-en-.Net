using Microsoft.EntityFrameworkCore;
using CrudNet7MVC.Models;

namespace CrudNet7MVC.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        // Agregar los modelos aqui
        public DbSet<Contacto> Contacto { get; set; }
    }
}
