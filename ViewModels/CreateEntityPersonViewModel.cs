namespace AspNetCoreBlazorStateManagement.ViewModels
{
    public class CreateEntityPersonViewModel
    {
        private bool? identity;
        private bool? fingerprinted;
        private bool? providedFirstAid;
        private bool? photo;
        private string? lastName;
        private string? firstName;
        private string? middleName;
        private string? genSuffix;

        public string? LastName
        {
            get => lastName ?? string.Empty;
            set
            {
                lastName = value;
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

        public string? GenSuffix
        {
            get => genSuffix ?? string.Empty;
            set
            {
                genSuffix = value;
                NotifyStateChanged();
            }
        }

        public bool? ProvidedFirstAid
        {
            get => providedFirstAid ?? false;
            set
            {
                providedFirstAid = value;
                NotifyStateChanged();
            }
        }

        public bool? Photo
        {
            get => photo ?? false;
            set
            {
                photo = value;
                NotifyStateChanged();
            }
        }

        public bool? Fingerprinted
        {
            get => fingerprinted ?? false;
            set
            {
                fingerprinted = value;
                NotifyStateChanged();
            }
        }
        public bool? Identity
        {
            get => identity ?? false;
            set
            {
                identity = value;
                NotifyStateChanged();
            }
        }


        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}