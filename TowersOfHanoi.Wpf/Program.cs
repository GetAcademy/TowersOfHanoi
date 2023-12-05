using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using TowersOfHanoi.Logic;

namespace TowersOfHanoi.Wpf
{
    class Program
    {

        [STAThread]
        public static void Main(string[] args)
        {
            // Pause til 10:35

            var game = new  Game();
            var app = new Application();
            var window = new Window();
            var gamePanel = new StackPanel{Orientation = Orientation.Horizontal };
            foreach (var tower in game.Towers)
            {
                var towerPanel = new StackPanel { Orientation = Orientation.Vertical, VerticalAlignment = VerticalAlignment.Bottom };
                foreach (var disk in tower.GetDisks())
                {
                    var rectangle = new Rectangle
                    {
                        Width = 20 * disk.Size,
                        Height = 20,
                        Fill = Brushes.Blue,
                        Margin = new Thickness(5)
                    };
                    towerPanel.Children.Add(rectangle);
                }
                var towerBase = new Rectangle
                {
                    Width = 200,
                    Height = 20,
                    Fill = Brushes.Red,
                    Margin = new Thickness(5)
                };
                towerPanel.Children.Add(towerBase);
                gamePanel.Children.Add(towerPanel);
            }
            window.Content = gamePanel;
            app.Run(window);
        }

        /*
        [STAThread]
        public static void Main(string[] args)
        {
            _counter = 0;
            var app = new Application();
            var window = new Window();
            var button = new Button { Content = "Hei!" };
            _label = new Label { Content = "0" };
            var panel = new StackPanel(); // { Orientation = Orientation.Horizontal };
            panel.Children.Add(button);
            panel.Children.Add(_label);
            button.Click += ButtonClick;
            window.Content = panel;
            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            _counter++;
            _label.Content = _counter;
        }
        */
    }
}
