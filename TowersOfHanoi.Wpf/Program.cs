using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using TowersOfHanoi.Logic;

namespace TowersOfHanoi.Wpf
{
    class Program
    {
        // Pause til 11:04
        [STAThread]
        public static void Main(string[] args)
        {
            var game = new Game();
            var app = new Application();
            var window = new Window();
            var gamePanel = new GamePanel(game);
            window.Content = gamePanel.Panel;
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
