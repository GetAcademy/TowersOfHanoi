namespace TowersOfHanoi.Console
{
    internal class Game
    {
        private readonly Tower[] _towers;

        public Game()
        {
            _towers = new Tower[]
            {
                new Tower(3, 2, 1),
                new Tower(),
                new Tower(),
            };
        }
    }
}
