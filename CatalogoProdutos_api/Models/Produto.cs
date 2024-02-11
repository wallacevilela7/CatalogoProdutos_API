using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoProdutos_api.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int QuantidadeEstoque { get; set; }
        public decimal Preco { get; set; }

        [Column("dataCricao")]
        public DateOnly DataCriacao { get; set; }
    }
}
