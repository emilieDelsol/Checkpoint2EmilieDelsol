using Microsoft.EntityFrameworkCore;

namespace DALCheckPoint2EmilieD
{
     class DatabaseCheckPoint2Context :DbContext
    {
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Student> Students{ get; set; }
        public DbSet<Controle> Controles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LOCALHOST\SQLEXPRESS;Database=DatabaseCheckpoint2;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}