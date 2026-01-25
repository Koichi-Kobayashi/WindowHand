using System.Collections.ObjectModel;
using System.Management;
using WindowHand.Models;

namespace WindowHand.ViewModels.Pages
{
    public partial class NetworkPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<NetworkAdapterInfo> _wifiAdapters = new();

        [ObservableProperty]
        private bool _isLoading;

        [ObservableProperty]
        private string? _errorMessage;

        [ObservableProperty]
        private bool _showWifiOnly = true;

        public NetworkPageViewModel()
        {
            _ = RefreshAsync();
        }

        partial void OnShowWifiOnlyChanged(bool value)
        {
            if (!IsLoading)
            {
                _ = RefreshAsync();
            }
        }

        [RelayCommand]
        private async Task RefreshAsync()
        {
            IsLoading = true;
            ErrorMessage = null;

            try
            {
                var adapters = await Task.Run(() => LoadAdapters(ShowWifiOnly));
                WifiAdapters = new ObservableCollection<NetworkAdapterInfo>(adapters);

                if (WifiAdapters.Count == 0)
                {
                    ErrorMessage = ShowWifiOnly
                        ? "Wi-Fiアダプタが見つかりませんでした。"
                        : "物理アダプタが見つかりませんでした。";
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = $"読み込みに失敗しました: {ex.Message}";
            }
            finally
            {
                IsLoading = false;
            }
        }

        private static IReadOnlyList<NetworkAdapterInfo> LoadAdapters(bool showWifiOnly)
        {
            var results = new List<NetworkAdapterInfo>();

            using var searcher = new ManagementObjectSearcher(
                "SELECT * FROM Win32_NetworkAdapter WHERE PhysicalAdapter = TRUE");

            foreach (ManagementObject mo in searcher.Get())
            {
                var name = Convert.ToString(mo["Name"]);
                var description = Convert.ToString(mo["Description"]);
                var connectionId = Convert.ToString(mo["NetConnectionID"]);

                if (showWifiOnly && !IsWifiAdapter(name, description, connectionId))
                {
                    continue;
                }

                results.Add(new NetworkAdapterInfo
                {
                    Name = name ?? "(不明)",
                    Description = description,
                    DeviceId = Convert.ToString(mo["DeviceID"]),
                    NetConnectionId = connectionId,
                    NetEnabled = mo["NetEnabled"] as bool?
                });
            }

            return results;
        }

        private static bool IsWifiAdapter(string? name, string? description, string? connectionId)
        {
            return ContainsWifiToken(name)
                || ContainsWifiToken(description)
                || ContainsWifiToken(connectionId);
        }

        private static bool ContainsWifiToken(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            return value.Contains("wi-fi", StringComparison.OrdinalIgnoreCase)
                || value.Contains("wifi", StringComparison.OrdinalIgnoreCase)
                || value.Contains("wireless", StringComparison.OrdinalIgnoreCase)
                || value.Contains("wlan", StringComparison.OrdinalIgnoreCase)
                || value.Contains("802.11", StringComparison.OrdinalIgnoreCase);
        }
    }
}
