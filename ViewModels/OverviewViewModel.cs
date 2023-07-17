using AspNetCoreBlazorStateManagement.Models;

namespace AspNetCoreBlazorStateManagement.ViewModels;

public class OverviewViewModel
{
    private int longitude;
    private int latitude;
    private DateTime? startDateTime;
    private string? occurred;
    private string? incidentNumber;
    private bool lprChecked;

    public int RNumber { get; set; }
    public string? OccurredWhen { get; set; }
    public TimeOnly? TimeOfIncident { get; set; }
    public string? TroopOfOccurence { get; set; }
    public string? addressType { get; set; }
    public StreetAddressModel? StreetAddress { get; set; }
    public List<EntityPersonModel> PersonEntities { get; set; } = new();
    public List<EntityBusinessModel> BusinessEntities { get; set; } = new();


    public bool LPRChecked
    {
        get => lprChecked;
        set
        {
            lprChecked = value;
            NotifyStateChanged();
        }
    }

    public string IncidentNumber
    {
        get => incidentNumber ?? string.Empty;
        set
        {
            incidentNumber = value;
            NotifyStateChanged();
        }
    }

    public string Occurred
    {
        get => occurred ?? string.Empty;
        set
        {
            occurred = value;
            NotifyStateChanged();
        }
    }

    public DateTime? StartDateTime
    {
        get => startDateTime;
        set
        {
            startDateTime = value;
            NotifyStateChanged();
        }
    }

    public int Latitude
    {
        get => latitude;
        set
        {
            latitude = value;
            NotifyStateChanged();
        }
    }

    public int Longitude
    {
        get => longitude;
        set
        {
            longitude = value;
            NotifyStateChanged();
        }
    }

    public string? AddressType
    {
        get => addressType ?? string.Empty;
        set
        {
            addressType = value;
            NotifyStateChanged();
        }
    }

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}