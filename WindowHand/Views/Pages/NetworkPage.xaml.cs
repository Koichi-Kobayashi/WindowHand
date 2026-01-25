using WindowHand.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace WindowHand.Views.Pages
{
    public partial class NetworkPage : INavigableView<NetworkPageViewModel>
    {
        public NetworkPageViewModel ViewModel { get; }

        public NetworkPage(NetworkPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
