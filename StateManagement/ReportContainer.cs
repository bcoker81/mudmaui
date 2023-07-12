namespace AspNetCoreBlazorStateManagement.StateManagement;

public class ReportContainer
{
    private bool? selectedCitationReport;
    private bool? selectedAirReport;
    private bool? lprChecked;
    private string? incidentNumber;
    private string? occurred;
    private DateTime? startDateTime;
    private int latitude;
    private int longitude;

    public bool AirReportProperty
    {
        get => selectedAirReport ?? false;
        set
        {
            selectedAirReport = value;
            NotifyStateChanged();
        }
    }

    public bool CitationReportProperty
    {
        get => selectedCitationReport ?? false;
        set
        {
            selectedCitationReport = value;
            NotifyStateChanged();
        }
    }

    public bool LPRChecked
    {
        get => lprChecked ?? false;
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


    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}