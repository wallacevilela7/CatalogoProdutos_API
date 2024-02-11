using CatalogoProdutos_api.Models;

namespace CatalogoProdutos_api.Services.Implementations
{
    public interface IProdutoService
    {
        public Produto Create(Produto produto);
        public List<Produto> FindAll();
        public Produto FindById(int id);
        public Produto Update(Produto produto);
        void Delete(int id);
    }
}
