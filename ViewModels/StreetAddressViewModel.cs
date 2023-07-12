namespace AspNetCoreBlazorStateManagement.ViewModels;

public class StreetAddressViewModel
{
    private string? rNumber;
    private bool lprChecked;
    private string? incidentNumber;
    private string? occurred;
    private string? searchOccurredOn;
    private DateTime startDateTime;
    private string? troopOfOccurance;
    private string? addressType;
    private int latitude;
    private int longitude;

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

    public string? SearchOccurredOn
    {
        get => searchOccurredOn;
        set
        {
            searchOccurredOn = value ?? string.Empty;
            NotifyStateChanged();
        }
    }

    public DateTime StartDateTime
    {
        get => startDateTime;
        set
        {
            startDateTime = value;
            NotifyStateChanged();
        }
    }

    public string? TroopOfOccurrence
    {
        get => troopOfOccurance;
        set
        {
            troopOfOccurance = value ?? string.Empty;
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

    public string RNumber
    {
        get => rNumber ?? string.Empty;
        set
        {
            rNumber = value;
            NotifyStateChanged();
        }
    }

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

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();

}