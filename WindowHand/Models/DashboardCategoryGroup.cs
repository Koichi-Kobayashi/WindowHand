using System.Collections.ObjectModel;

namespace WindowHand.Models
{
    public sealed class DashboardCategoryGroup
    {
        public DashboardCategoryGroup(string title, ObservableCollection<DashboardCategory> categories)
        {
            Title = title;
            Categories = categories;
        }

        public string Title { get; }

        public ObservableCollection<DashboardCategory> Categories { get; }
    }
}
