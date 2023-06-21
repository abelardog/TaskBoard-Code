using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskBoard.Core.Entities;

namespace TaskBoard.Infrastructure.Data
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {
        }

        
        public DbSet<Board> Board { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<List> List { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<State> State { get; set; }

        

    }
}
