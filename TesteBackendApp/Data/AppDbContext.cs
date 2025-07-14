using Microsoft.EntityFrameworkCore;

namespace TesteBackendApp.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        // Exemplo de tabela
        public required DbSet<Usuario> Usuarios { get; set; }
    }

    public class Usuario
    {
        public required string Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }

    }
}
