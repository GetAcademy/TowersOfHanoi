namespace TowersOfHanoi.Console
{
    internal class Game
    {
        public Tower[] Towers { get; }

        public Game()
        {
            Towers = new Tower[]
            {
                new Tower(2, 4, 6),
                new Tower(),
                new Tower(),
            };
        }
    }
}
