using Microsoft.EntityFrameworkCore;

namespace CatalogoProdutos_api.Models.Context
{
    public class SqlServerContext : DbContext
    {

        public SqlServerContext() { }

        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options){ }

        public DbSet<Produto> Produto { get; set; }
    }
}
