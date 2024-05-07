using Microsoft.EntityFrameworkCore;
using sistemaDeCadastro.Models;

namespace sistemaDeCadastro.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
