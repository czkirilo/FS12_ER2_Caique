using Chapter.Contexts;
using Chapter.Models;
using Microsoft.AspNetCore.Mvc;
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

        public List<Livro> Listar()
        {
            return _context.livros.ToList();
        }

        public Livro BuscarPorId(int id) {
            return _context.livros.Find(id);
        }

        public void Cadastrar(Livro livro)
        {
            _context.livros.Add(livro);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Livro livro)
        {
            Livro livrobuscado = _context.livros.Find(id);

            if (livrobuscado != null)
            {
                livrobuscado.Titulo = livro.Titulo;
                livrobuscado.QuantidadePaginas = livro.QuantidadePaginas;
                livrobuscado.Disponivel = livro.Disponivel;
            }
            _context.livros.Update(livrobuscado);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Livro livro = _context.livros.Find(id);
            _context.livros.Remove(livro);
            _context.SaveChanges();
        }
        




    }
}
