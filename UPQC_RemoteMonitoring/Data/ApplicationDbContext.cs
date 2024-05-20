using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UPQC_RemoteMonitoring.Models;

namespace UPQC_RemoteMonitoring.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
	    public DbSet<UPQC_RemoteMonitoring.Models.Alarms> Alarms { get; set; } = default!;
	    public DbSet<UPQC_RemoteMonitoring.Models.EnergyExport> EnergyExport { get; set; } = default!;
	}
}
