using FaturasCartao.Models;
using Microsoft.EntityFrameworkCore;

namespace FaturasCartao.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }


    }
}
