using CatalogoProdutos_api.Models;
using CatalogoProdutos_api.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace CatalogoProdutos_api.Services.Implementations
{
    public class ProdutoServiceImplementation : IProdutoService
    {
        private SqlServerContext _context;
        public ProdutoServiceImplementation(SqlServerContext context)
        {
            _context = context;
        }

        public Produto Create(Produto produto)
        {
            if (produto == null) return new Produto();

            try
            {
                _context.Produto.Add(produto);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return produto;
        }

        public void Delete(int id)
        {
            var result = _context.Produto.SingleOrDefault(p => p.Id == id);
            if(result != null)
            {
                _context.Produto.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.ToList();
        }

        public Produto FindById(int id)
        {
            return _context.Produto.SingleOrDefault(prod => prod.Id == id);
        }

        public Produto Update(Produto produto)
        {
            try
            {
                var result = _context.Produto.SingleOrDefault(p => p.Id == produto.Id);
                if (result != null) {
                    _context.Entry(result).CurrentValues.SetValues(produto);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return produto;
        }
    }
}