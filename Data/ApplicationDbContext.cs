using Microsoft.EntityFrameworkCore;
using survey_app.Models;

namespace survey_app.Data;

public class ApplicationDbContext: DbContext
{
    public virtual DbSet<Question> Questions {get; set;}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){ }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
