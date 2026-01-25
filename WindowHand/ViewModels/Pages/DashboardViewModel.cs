using System.Collections.ObjectModel;
using WindowHand.Models;
using Wpf.Ui.Controls;

namespace WindowHand.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        public DashboardViewModel()
        {
            CategoryGroups = new ObservableCollection<DashboardCategoryGroup>
            {
                new("システム", new ObservableCollection<DashboardCategory>
                {
                    new("表示", "解像度やスケーリング", SymbolRegular.Settings24),
                    new("サウンド", "音量と出力先", SymbolRegular.DataHistogram24),
                    new("通知", "通知の表示と集中モード", SymbolRegular.Settings24),
                    new("電源", "スリープと電源ボタン", SymbolRegular.Home24),
                    new("ストレージ", "容量とクリーンアップ", SymbolRegular.DataHistogram24),
                    new("復元", "システムの復元とバックアップ", SymbolRegular.Settings24)
                }),
                new("デスクトップ", new ObservableCollection<DashboardCategory>
                {
                    new("壁紙", "テーマと背景", SymbolRegular.Home24),
                    new("アイコン", "デスクトップの表示項目", SymbolRegular.Settings24),
                    new("タスクバー", "配置と表示内容", SymbolRegular.DataHistogram24),
                    new("スタート", "おすすめやピンの表示", SymbolRegular.Settings24),
                    new("右クリック", "コンテキストメニュー", SymbolRegular.Home24),
                    new("ウィジェット", "表示と候補", SymbolRegular.DataHistogram24)
                }),
                new("エクスプローラー", new ObservableCollection<DashboardCategory>
                {
                    new("表示", "プレビューと項目サイズ", SymbolRegular.Settings24),
                    new("クイックアクセス", "よく使うフォルダー", SymbolRegular.Home24),
                    new("拡張子", "拡張子と隠し項目", SymbolRegular.Settings24),
                    new("圧縮", "ZIPの関連付け", SymbolRegular.DataHistogram24),
                    new("ライブラリ", "ライブラリの表示", SymbolRegular.Home24),
                    new("ショートカット", "作成と整理", SymbolRegular.Settings24)
                }),
                new("ネットワーク", new ObservableCollection<DashboardCategory>
                {
                    new("Wi-Fi", "ネットワークの接続管理", SymbolRegular.DataHistogram24),
                    new("イーサネット", "有線接続の設定", SymbolRegular.Settings24),
                    new("プロキシ", "プロキシとVPN", SymbolRegular.Home24),
                    new("共有", "共有と検出", SymbolRegular.Settings24),
                    new("リモート", "リモートデスクトップ", SymbolRegular.DataHistogram24),
                    new("時刻同期", "時刻と言語", SymbolRegular.Settings24)
                }),
                new("セキュリティ", new ObservableCollection<DashboardCategory>
                {
                    new("アカウント", "ローカルとMicrosoft", SymbolRegular.Home24),
                    new("ログオン", "サインイン方法", SymbolRegular.Settings24),
                    new("UAC", "管理者権限の通知", SymbolRegular.Settings24),
                    new("プライバシー", "アクセス権の管理", SymbolRegular.DataHistogram24),
                    new("保護", "セキュリティの状態", SymbolRegular.Settings24),
                    new("更新", "Windows Update", SymbolRegular.DataHistogram24)
                })
            };
        }

        public ObservableCollection<DashboardCategoryGroup> CategoryGroups { get; }
    }
}
