using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data.Context
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}