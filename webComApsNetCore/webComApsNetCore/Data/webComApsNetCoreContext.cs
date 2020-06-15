using Microsoft.EntityFrameworkCore;

namespace webComApsNetCore.Data
{
    public class webComApsNetCoreContext : DbContext
    {
        public webComApsNetCoreContext (DbContextOptions<webComApsNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<webComApsNetCore.Models.Department> Department { get; set; }

        public DbSet<webComApsNetCore.Models.Empresa> Empresa { get; set; }

        public DbSet<webComApsNetCore.Models.Livros> Livros { get; set; }

        public DbSet<webComApsNetCore.Models.Carro> Carro { get; set; }

        public DbSet<webComApsNetCore.Models.CategoriaLivro> Categoria { get; set; }

        public DbSet<webComApsNetCore.Models.Generico> Generico { get; set; }
    }
}
