using Wpf.Ui.Controls;

namespace WindowHand.Models
{
    public sealed class DashboardCategory
    {
        public DashboardCategory(string title, string description, SymbolRegular iconSymbol)
        {
            Title = title;
            Description = description;
            IconSymbol = iconSymbol;
        }

        public string Title { get; }

        public string Description { get; }

        public SymbolRegular IconSymbol { get; }
    }
}
