using GranTiete_Devs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GranTiete_Devs.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<AreaAtuacao> AreaAtuacoes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        #region Popular Areas de Atuação
        List<AreaAtuacao> areas= new()
        {
            new(){
                Id = 1,
                Nome = "Desenvolvedor Full-Stack"
            },
              new(){
                Id = 1,
                Nome = "Desenvolvedor Back-End"
            },
            new(){
                Id = 1,
                Nome = "Desenvolvedor Front-End"
            },
        };
        builder.Entity<AreaAtuacao>().HasData(areas);
        #endregion    

        #region Popular Usuario
        
        #endregion
    }
}
