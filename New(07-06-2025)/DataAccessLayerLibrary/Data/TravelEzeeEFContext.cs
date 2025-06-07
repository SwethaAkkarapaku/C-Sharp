using Microsoft.EntityFrameworkCore;
public class TravelEzeeEFContext:DbContext
{
    string ConString="Data Source=WKSCHE03TRNG087\\SQLEXPRESS;Initial Catalog=TravelEF;Integrated Security=True;Trust Server Certificate=True";
    public DbSet<Location> Locations{get;set;}
    public DbSet<ServiceType> ServiceTypes{get;set;}
    public DbSet<Service> Services{get;set;}
    public DbSet<Booking> Bookings{get;set;}
    public TravelEzeeEFContext()
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Ignore<Location>();
        modelBuilder.Entity<Service>().HasOne(srv=>srv.SourceLocationsId).
        WithMany(loc=>loc.ServiceSourceList).HasForeignKey(srv=>srv.SourceLocId).
        OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Service>().HasOne(srv=>srv.DestLocationsId).
        WithMany(loc=>loc.ServiceDestList).HasForeignKey(srv=>srv.DestLocId).
        OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<ServiceType>().HasIndex(p=>p.ServiceTypeName).IsUnique();
        modelBuilder.Entity<Location>().HasData(
            new Location(){LocationId=101,LocationName="Chennai"},
            new Location(){LocationId=102,LocationName="Hyderabad"},
            new Location(){LocationId=103,LocationName="Bangalore"}
        );

        modelBuilder.Entity<ServiceType>().HasData(
            new ServiceType(){ServTypeId=201,ServiceTypeName="ServType1",PricePerKm=10.00},
            new ServiceType(){ServTypeId=202,ServiceTypeName="ServType2",PricePerKm=15.00},
            new ServiceType(){ServTypeId=203,ServiceTypeName="ServType3",PricePerKm=20.00}
        );
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        optionBuilder.UseSqlServer(ConString);
    }
}