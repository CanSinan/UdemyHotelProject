using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-LTMI9TN\\SQLEXPRESS;initial catalog=ApiDb;" +
				"Persist Security Info=False;User ID=sa;Password=Password1;MultipleActiveResultSets=True;" +
				"TrustServerCertificate=True;Connection Timeout=30;"); 
		}
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Service> Services{ get; set; }
		public DbSet<Staff> Staffs{ get; set; }
		public DbSet<Subscribe> Subscribes{ get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
