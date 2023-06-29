namespace AspNetCoreBlazorStateManagement.StateManagement;

public class ReportContainer
{
    private bool? selectedCitationReport;
    private bool? selectedAirReport;

    public bool AirReportProperty{
        get => selectedAirReport ?? false;
        set {
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

    public event Action? OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}