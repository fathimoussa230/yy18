using Microsoft.EntityFrameworkCore;
using yyapp.api.Models;

namespace yyapp.api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<Value> Values { get; set; }
    }
}