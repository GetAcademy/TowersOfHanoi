// See https://aka.ms/new-console-template for more information

using TowersOfHanoi.Console;

var game = new Game();
while (game.IsRunning)
{
    Console.Clear();
    MyConsole.WriteGame(game, 2, 10, 20, 8);
    Console.SetCursorPosition(1, 15);
    var fromTowerNo = MyConsole.Ask("Hvilket tårn vil du flytte fra? ");
    var toTowerNo = MyConsole.Ask("Hvilket tårn vil du flytte til? ");
    game.Move(fromTowerNo, toTowerNo);
}
Console.Clear();
MyConsole.WriteGame(game, 2, 10, 20, 8);
Console.WriteLine("Løst!");


