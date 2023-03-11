using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class chaptercontext : DbContext
    {
        public chaptercontext() { }
        public chaptercontext(DbContextOptions<chaptercontext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {  optionsBuilder.UseSqlServer("Data Source = DESKTOP-F2ABGDE\\SQLEXPRESS ; initial catalog = Chapter; integrated security = true"); }
        }

        public DbSet<livro> livros { get; set; }
    }
}
