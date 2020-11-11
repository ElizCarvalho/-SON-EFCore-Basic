using Microsoft.EntityFrameworkCore;
using EFCore.Models;

namespace EFCore.Database
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios {get; set;}
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}
    }
}