using lapirana_pc02.Models;
using Microsoft.EntityFrameworkCore;


namespace lapirana_pc02.Data
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios {get;set;}

        public UsuarioContext(DbContextOptions dco) base(dco) {

        }
    }
}