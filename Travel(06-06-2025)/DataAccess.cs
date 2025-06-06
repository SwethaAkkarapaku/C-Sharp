using Microsoft.Extensions.DependencyInjection;
using TravelManagement.DTO;

public class DataAccess
{
    TravelEFManagementContext context;
    public DataAccess()
    {
        context = new TravelEFManagementContext();
    }

    //view data from tables
    public List<Location> GetAllLocations()
    {
        return context.locations.ToList();
    }

    public List<ServiceType> GetAllServiceTypes()
    {
        return context.ServiceType.ToList();
    }

    public List<Service> GetAllServices()
    {
        return context.services.ToList();
    }

    public List<Booking> GetAllBookings()
    {
        return context.bookings.ToList();
    }

    //getting data based on specifications
    public List<Service> GetServicesBasedonLocation(long SrcLoc, long destLoc)
    {
        return context.services.Where(srv => srv.SourceLocId == SrcLoc && srv.DestLocId == destLoc).ToList();
    }
    
    //insert data into tables
    public bool AddLocation(long LocId,string LocName)
    {
        Location loc=new Location()
        {
            LocationId=LocId,
            LocationName=LocName
        };
        context.locations.Add(loc);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddService(long SerTypId,long SrcLocId,long DesLocId,double Dist)
    {
        Service srv=new Service()
        {
            SerTypeId=SerTypId,
            SourceLocId=SrcLocId,
            DestLocId=DesLocId,
            Distance=Dist,
        };
        context.services.Add(srv);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddServiceType(string ServTypeName,double pricePerKm)
    {
        var typeList = context.ServiceType.ToList();
        long NextAvailId = 1;
        if (typeList.Count > 0)
        {
            NextAvailId = typeList.Max(t => t.STypeId) + 1;
        }
        ServiceType srvType=new ServiceType()
        {
            STypeId= NextAvailId,
            ServiceTypeName=ServTypeName,
            PricePerKm=pricePerKm
        };
        context.ServiceType.Add(srvType);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool AddBooking(long ServId,DateTime TravDate,int SCount,string BBy)
    {
        Booking books=new Booking()
        {
            ServiceId=ServId,
            TravelDate=TravDate,
            SeatCount=SCount,
            BookBy=BBy,
        };
        context.bookings.Add(books);
        int Res=context.SaveChanges();
        return Res>0;
    }
    public bool DeleteLocation(long LocId)
    {
        //var ServicesList = context.Services.Where(loc => loc.SourceLocId == LocId || loc.DestLocId == LocId).ToList();
        //context.Services.RemoveRange(ServicesList);
        var LocList = context.locations.FirstOrDefault(loc => loc.LocationId == LocId);
        context.locations.Remove(LocList);
        int del = context.SaveChanges();
        return del > 0;
    }
    public List<ServiceEntry> GetAllServicesView()
    {
        var Res = (from sobj in context.services
                   join srcLocObj in context.locations on sobj.SourceLocId equals srcLocObj.LocationId
                   join DestLocObj in context.locations on sobj.DestLocId equals DestLocObj.LocationId
                   join stypeObj in context.ServiceType on sobj.SerTypeId equals stypeObj.STypeId
                   select new ServiceEntry()
                   {
                       ServiceId = sobj.ServiceId,
                       SourceLocId = srcLocObj.LocationName,
                       DestLocId = DestLocObj.LocationName,
                       ServiceTypeName = stypeObj.ServiceTypeName,
                       Distance = sobj.Distance
                   }).ToList();
        return Res;
    }
}