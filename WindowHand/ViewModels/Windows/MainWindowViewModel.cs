using System.Collections.ObjectModel;
using Wpf.Ui.Controls;

namespace WindowHand.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _applicationTitle = "WPF UI - WindowHand";

        private static NavigationViewItem CreateGroup(string title, params NavigationViewItem[] items)
        {
            var group = new NavigationViewItem
            {
                Content = title,
                Tag = $"{title}_GROUP",
                IsExpanded = false
            };

            foreach (var item in items)
            {
                group.MenuItems.Add(item);
            }

            return group;
        }

        [ObservableProperty]
        private ObservableCollection<object> _menuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "ダッシュボード",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(Views.Pages.DashboardPage)
            },
            CreateGroup("システム",
                new NavigationViewItem()
                {
                    Content = "表示",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.SystemPage)
                },
                new NavigationViewItem()
                {
                    Content = "サウンド",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.SystemPage)
                },
                new NavigationViewItem()
                {
                    Content = "通知",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.SystemPage)
                },
                new NavigationViewItem()
                {
                    Content = "電源",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.SystemPage)
                },
                new NavigationViewItem()
                {
                    Content = "ストレージ",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.SystemPage)
                },
                new NavigationViewItem()
                {
                    Content = "復元",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.SystemPage)
                }
            ),
            CreateGroup("デスクトップ",
                new NavigationViewItem()
                {
                    Content = "壁紙",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.DesktopPage)
                },
                new NavigationViewItem()
                {
                    Content = "アイコン",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.DesktopPage)
                },
                new NavigationViewItem()
                {
                    Content = "タスクバー",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.DesktopPage)
                },
                new NavigationViewItem()
                {
                    Content = "スタート",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.DesktopPage)
                },
                new NavigationViewItem()
                {
                    Content = "右クリック",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.DesktopPage)
                },
                new NavigationViewItem()
                {
                    Content = "ウィジェット",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.DesktopPage)
                }
            ),
            CreateGroup("エクスプローラー",
                new NavigationViewItem()
                {
                    Content = "表示",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.ExplorerPage)
                },
                new NavigationViewItem()
                {
                    Content = "クイックアクセス",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.ExplorerPage)
                },
                new NavigationViewItem()
                {
                    Content = "拡張子",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.ExplorerPage)
                },
                new NavigationViewItem()
                {
                    Content = "圧縮",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.ExplorerPage)
                },
                new NavigationViewItem()
                {
                    Content = "ライブラリ",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.ExplorerPage)
                },
                new NavigationViewItem()
                {
                    Content = "ショートカット",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.ExplorerPage)
                }
            ),
            CreateGroup("ネットワーク",
                new NavigationViewItem()
                {
                    Content = "Wi-Fi",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.NetworkPage)
                },
                new NavigationViewItem()
                {
                    Content = "イーサネット",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.NetworkPage)
                },
                new NavigationViewItem()
                {
                    Content = "プロキシ",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.NetworkPage)
                },
                new NavigationViewItem()
                {
                    Content = "共有",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.NetworkPage)
                },
                new NavigationViewItem()
                {
                    Content = "リモート",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.NetworkPage)
                },
                new NavigationViewItem()
                {
                    Content = "時刻同期",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.NetworkPage)
                }
            ),
            CreateGroup("セキュリティ",
                new NavigationViewItem()
                {
                    Content = "アカウント",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                    TargetPageType = typeof(Views.Pages.SecurityPage)
                },
                new NavigationViewItem()
                {
                    Content = "ログオン",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.SecurityPage)
                },
                new NavigationViewItem()
                {
                    Content = "UAC",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.SecurityPage)
                },
                new NavigationViewItem()
                {
                    Content = "プライバシー",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.SecurityPage)
                },
                new NavigationViewItem()
                {
                    Content = "保護",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                    TargetPageType = typeof(Views.Pages.SecurityPage)
                },
                new NavigationViewItem()
                {
                    Content = "更新",
                    Icon = new SymbolIcon { Symbol = SymbolRegular.DataHistogram24 },
                    TargetPageType = typeof(Views.Pages.SecurityPage)
                }
            )
        };

        [ObservableProperty]
        private ObservableCollection<object> _footerMenuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            }
        };

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems = new()
        {
            new MenuItem { Header = "Home", Tag = "tray_home" }
        };
    }
}
