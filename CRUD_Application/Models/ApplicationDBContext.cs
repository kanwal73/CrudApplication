using Microsoft.EntityFrameworkCore;

namespace CRUD_Application.Models
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
