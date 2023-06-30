using LearningApi.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace LearningApi.Data
{
    public class LearningApiDbContext : DbContext
    {
        public LearningApiDbContext(DbContextOptions<LearningApiDbContext> options): base(options)
        {

        }

        //Entity Framework
        //Mean please create Regions table for use ig does not exit
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficultys { get; set; }
    }
}
