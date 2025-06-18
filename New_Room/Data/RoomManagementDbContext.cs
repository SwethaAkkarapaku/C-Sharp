using Microsoft.EntityFrameworkCore;

namespace RoomManagementMVCApp.Data
{
    public class RoomManagementDbContext:DbContext
    {
        public DbSet<MeetingRoom> meetingRooms { get; set; }
        public RoomManagementDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MeetingRoom>().Property(p => p.Capacity).HasDefaultValue(10);
            modelBuilder.Entity<MeetingRoom>().HasIndex(p => p.RoomName).IsUnique(true);
            //modelBuilder.Entity<MeetingRoom>().Property(p=>p.Location).IsUnique(true);
            //base.OnModelCreating(modelBuilder);
        }
    }
}
