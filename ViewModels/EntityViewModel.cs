namespace AspNetCoreBlazorStateManagement.ViewModels
{
    public class EntityViewModel
    {
        private string? firstName;
        private string? middleName;
        private string? lastName;
        private DateTime? dob;

        public DateTime? Dob
        {
            get => dob;
            set
            {
                dob = value;
                NotifyStateChanged();
            }
        }

        public string? FirstName
        {
            get => firstName ?? string.Empty;
            set
            {
                firstName = value;
                NotifyStateChanged();
            }
        }

        public string? MiddleName
        {
            get => middleName ?? string.Empty;
            set
            {
                middleName = value;
                NotifyStateChanged();
            }
        }

        public string? LastName
        {
            get => lastName ?? string.Empty;
            set
            {
                lastName = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}