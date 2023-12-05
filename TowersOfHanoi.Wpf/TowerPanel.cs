using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TowersOfHanoi.Wpf
{
    class TowerPanel : StackPanel
    {
        public TowerPanel()
        {
            Orientation = Orientation.Vertical;
            VerticalAlignment = VerticalAlignment.Bottom;
            //Background = Brushes.AntiqueWhite;
        }
    }
}
