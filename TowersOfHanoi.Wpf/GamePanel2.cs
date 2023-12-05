﻿using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using System.Windows.Shapes;
using TowersOfHanoi.Logic;

namespace TowersOfHanoi.Wpf
{
    class GamePanel2 : StackPanel
    {
        private Game _game;
        private StackPanel[] _towerPanels;
        
        public GamePanel2(Game game)
        {
            _game = game;
            _towerPanels = new StackPanel[game.Towers.Length];
            Orientation = Orientation.Horizontal;
            for (var index = 0; index < game.Towers.Length; index++)
            {
                var towerPanel = new TowerPanel();
                _towerPanels[index] = towerPanel;
                Children.Add(towerPanel);
            }
            var buttonPanel = new TowerPanel();
            AddButton(1, 2, buttonPanel);
            AddButton(1, 3, buttonPanel);
            AddButton(2, 1, buttonPanel);
            AddButton(2, 3, buttonPanel);
            AddButton(3, 1, buttonPanel);
            AddButton(3, 2, buttonPanel);
            Children.Add(buttonPanel);
            UpdateTowers();
        }
        
        private void AddButton(int from, int to, StackPanel panel)
        {
            var button = new Button { Content = $"{from} => {to}" };
            panel.Children.Add(button);
            button.Click += CreateClickMethod(from, to);
        }

        private RoutedEventHandler CreateClickMethod(int from, int to)
        {
            return (object sender, RoutedEventArgs e) =>
            {
                _game.Move(from, to);
                UpdateTowers();
            };
        }

        //private void ButtonClick(object sender, RoutedEventArgs e)
        //{
        //    _game.Move(1, 2);
        //    UpdateTowers();
        //}

        public void UpdateTowers()
        {
            for (var index = 0; index < _game.Towers.Length; index++)
            {
                var tower = _game.Towers[index];
                var towerPanel = _towerPanels[index];
                towerPanel.Children.Clear();
                foreach (var disk in tower.GetDisks())
                {
                    var size = disk.Size;
                    AddRectangle(size, Brushes.Blue, towerPanel);
                }
                AddRectangle(10, Brushes.Red, towerPanel);
            }
        }

        private static void AddRectangle(int size, SolidColorBrush color, StackPanel towerPanel)
        {
            var rectangle = new Rectangle
            {
                Width = 20 * size,
                Height = 20,
                Fill = color,
                Margin = new Thickness(5)
            };
            towerPanel.Children.Add(rectangle);
        }
    }
}
