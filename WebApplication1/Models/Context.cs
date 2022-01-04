using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {

        }
        public DbSet<CadastrarCidade> cadastrarCidades { get; set; }
        public DbSet<CadastrarViagem> cadastrarViagens { get; set; }
        public DbSet<Comprar> compras { get; set; }
        public DbSet<Contato> contatos { get; set; }
        public DbSet<CadastrarCliente> cadastrarClientes { get; set; }
    }
}
