using System.Collections.ObjectModel;
using Generated.Settings;

namespace WindowHand.ViewModels.Pages
{
    public partial class SystemPageViewModel : ObservableObject
    {
        public ObservableCollection<SettingsShortcutRow> Shortcuts { get; }

        [ObservableProperty]
        private string? _errorMessage;

        public SystemPageViewModel()
        {
            Shortcuts = new ObservableCollection<SettingsShortcutRow>();

            foreach (var category in SettingsMenuFactory.CreateDefault())
            {
                foreach (var item in category.Items)
                {
                    Shortcuts.Add(new SettingsShortcutRow(
                        categoryName: category.Name,
                        name: item.Name,
                        uri: item.Uri,
                        source: item));
                }
            }
        }

        [RelayCommand]
        private void Open(SettingsShortcutRow row)
        {
            ErrorMessage = null;

            if (!MsSettingsSupport.TryOpen(row.Uri, out var error))
            {
                ErrorMessage = $"開けませんでした: {row.Name}";
                if (error != null)
                {
                    ErrorMessage = $"{ErrorMessage} ({error.Message})";
                }
            }
        }
    }

    public sealed class SettingsShortcutRow
    {
        public SettingsShortcutRow(string categoryName, string name, string uri, SettingsItemVm source)
        {
            CategoryName = categoryName;
            Name = name;
            Uri = uri;
            Source = source;
        }

        public string CategoryName { get; }

        public string Name { get; }

        public string Uri { get; }

        public SettingsItemVm Source { get; }
    }
}
