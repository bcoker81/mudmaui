namespace AspNetCoreBlazorStateManagement.ViewModels
{
    public class CreateEntityBusinessViewModel
    {
        private string? businessName;
        private string? typeOfBusiness;
        private string? emailAddress;
        private string? websiteUrl;

        public string? BusinessName
        {
            get => businessName ?? string.Empty;
            set
            {
                businessName = value;
                NotifyStateChanged();
            }
        }

        public string? TypeOfBusiness
        {
            get => typeOfBusiness ?? string.Empty;
            set
            {
                typeOfBusiness = value;
                NotifyStateChanged();
            }
        }

        public string? EmailAddress
        {
            get => emailAddress ?? string.Empty;
            set
            {
                emailAddress = value;
                NotifyStateChanged();
            }
        }

        public string? WebsiteUrl
        {
            get => websiteUrl ?? string.Empty;
            set
            {
                websiteUrl = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}