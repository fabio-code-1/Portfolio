using Microsoft.EntityFrameworkCore;

namespace Portfolio.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Skills> Skills { get; set; }


    }
}
