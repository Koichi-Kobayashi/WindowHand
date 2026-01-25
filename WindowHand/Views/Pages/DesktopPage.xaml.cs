using WindowHand.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace WindowHand.Views.Pages
{
    public partial class DesktopPage : INavigableView<DesktopPageViewModel>
    {
        public DesktopPageViewModel ViewModel { get; }

        public DesktopPage(DesktopPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
