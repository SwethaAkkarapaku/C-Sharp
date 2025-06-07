using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Service
{
    [Key]
    //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long ServId{get;set;}

    [ForeignKey(nameof(ServiceTypeId))]
    public long ServTypeId{get;set;}

    //[ForeignKey(nameof(SourceLocationsId))]
    public long SourceLocId{get;set;}

    //[ForeignKey(nameof(DestLocationsId))]
    public long DestLocId{get;set;}

    [DefaultValue(10)]
    public double Distance{get;set;}

    //navigations
    public ServiceType ServiceTypeId{get;set;}
    public Location SourceLocationsId{get;set;}
    public Location DestLocationsId{get;set;}
    public List<Booking> CurBookings{get;set;}
}