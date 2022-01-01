
using Microsoft.EntityFrameworkCore;
using TomatoNotesWeb.Models;

namespace TomatoNotesWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}

