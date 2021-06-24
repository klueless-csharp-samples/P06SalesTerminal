namespace P06SalesTerminal.Context
{
  using Microsoft.EntityFrameworkCore;

  public class DbPgContext : DomainContext
  {
    // Pasword: ProgAtPete2040

    public DbPgContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql("Host=127.0.0.1;Port=5432;Database=P06;Username=postgres;Password=hamword");
  }
}
