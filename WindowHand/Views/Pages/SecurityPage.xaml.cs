using WindowHand.ViewModels.Pages;
using Wpf.Ui.Abstractions.Controls;

namespace WindowHand.Views.Pages
{
    public partial class SecurityPage : INavigableView<SecurityPageViewModel>
    {
        public SecurityPageViewModel ViewModel { get; }

        public SecurityPage(SecurityPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
