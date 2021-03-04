using Microsoft.EntityFrameworkCore;
using mvc_crud.Models;


namespace mvc_crud.Data
{
    public class mvc_crudContext : DbContext
    {
       public mvc_crudContext (DbContextOptions<mvc_crudContext> options)
            : base(options)

    {
    } 
    public DbSet<Cadastro> Cadastro { get; set; }

    }
}