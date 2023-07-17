namespace AspNetCoreBlazorStateManagement.ViewModels
{
    public class VehicleViewModel
    {
        private string? vehicleMake;
        private string? vehicleModel;
        private Int32 vehicleYear;

        public int VehicleYear
        {
            get => vehicleYear;
            set
            {
                vehicleYear = value;
                NotifyStateChanged();
            }
        }
        public string? VehicleMake
        {
            get => vehicleMake ?? string.Empty;
            set
            {
                vehicleMake = value;
                NotifyStateChanged();
            }
        }

        public string? VehicleModel
        {
            get => vehicleModel ?? string.Empty;
            set
            {
                vehicleModel = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}