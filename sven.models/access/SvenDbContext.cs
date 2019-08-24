using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using sven.models.data;

namespace sven.models.access
{
    public class SvenDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Set> Sets { get; set; }

        public SvenDbContext(DbContextOptions<SvenDbContext> options) : base(options)
        {

        }
    }
}