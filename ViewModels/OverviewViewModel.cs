using AspNetCoreBlazorStateManagement.Models;

namespace AspNetCoreBlazorStateManagement.ViewModels;

public class OverviewViewModel
{
    public int RNumber { get; set; }
    public bool LPR { get; set; }
    public int IncidentNumber { get; set; }
    public string? OccurredWhen { get; set; }
    public DateTime? StartDateTime { get; set; }
    public TimeOnly? TimeOfIncident { get; set; }
    public bool Occurred { get; set; }
    public string? TroopOfOccurence { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public string? AddressType { get; set; }
    public StreetAddressModel? StreetAddress { get; set; }
}