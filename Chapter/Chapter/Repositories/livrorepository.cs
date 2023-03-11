using Chapter.Contexts;
using Chapter.Models;
using Microsoft.Identity.Client;

namespace Chapter.Repositories
{
    public class livrorepository
    {
        private readonly chaptercontext _context;

        public livrorepository(chaptercontext context)
        {
            _context = context;
        }

        public List<livro> Listar()
        {
            return _context.livros.ToList();
        }
    }
}
