using System.Data.Entity;

namespace ClubModel
{

    public class ClubContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public ClubContext()
            : base("DefaultConnection")
        {
        }

        public static ClubContext Create()
        {
            return new ClubContext();
        }
    }
}