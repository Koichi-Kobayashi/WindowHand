using WindowHand.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace WindowHand.Views.Pages
{
    public partial class ExplorerPage : INavigableView<ExplorerPageViewModel>
    {
        public ExplorerPageViewModel ViewModel { get; }

        public ExplorerPage(ExplorerPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
