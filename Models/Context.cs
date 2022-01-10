using Microsoft.EntityFrameworkCore;

namespace AgenciaExplorer.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<CadastrarCidade> cadastrarCidades { get; set; }
        public DbSet<CadastrarOferta> cadastrarOfertas { get; set; }
        public DbSet<Comprar> compras { get; set; }
        public DbSet<Contato> contatos { get; set; }
    }
}
