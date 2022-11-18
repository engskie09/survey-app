using Microsoft.EntityFrameworkCore;

namespace survey_app.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){

    }
}
