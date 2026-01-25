using WindowHand.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace WindowHand.Views.Pages
{
    public partial class SystemPage : INavigableView<SystemPageViewModel>
    {
        public SystemPageViewModel ViewModel { get; }

        public SystemPage(SystemPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
