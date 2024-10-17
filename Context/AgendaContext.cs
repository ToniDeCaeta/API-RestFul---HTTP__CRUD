using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities; //namespace da entidade Contato. 

namespace ModuloAPI.Context
{

    public class AgendaContext : DbContext
    {

        public AgendaContext(DbContextOptions<AgendaContext>options) : base (options)
        {
        } 
        public DbSet<Contato> Contatos{get; set;}
    
    }
}
