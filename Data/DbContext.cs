using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class DbContext : IdentityDbContext<ApplicationUser>
{
	public DbContext(DbContextOptions<DbContext> options)
		: base(options)
	{
	}

	// Define DbSets for your entities
}
