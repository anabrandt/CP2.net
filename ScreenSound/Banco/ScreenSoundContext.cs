using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client; 

namespace ScreenSound.Banco
{
    internal class ScreenSoundContext : DbContext
    {
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        private string connectionString = "User Id=rm552283;Password=170204;Data Source=MyOracleConnection";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseOracle(connectionString) 
                .UseLazyLoadingProxies();
        }
    }
}
