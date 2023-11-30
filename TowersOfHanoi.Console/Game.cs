namespace TowersOfHanoi.Console
{
    internal class Game
    {
        public Tower[] Towers { get; }
        public bool IsRunning { get; private set; }

        public Game()
        {
            IsRunning = true;
            Towers = new Tower[]
            {
                new Tower(2, 4, 6),
                new Tower(),
                new Tower(),
            };
        }

        public void Move(int fromTowerNo, int toTowerNo)
        {
            var fromIndex = fromTowerNo - 1;
            var toIndex = toTowerNo - 1;
            var fromTower = Towers[fromIndex];
            var toTower = Towers[toIndex];
            var disk = fromTower.RemoveDisk();
            toTower.AddDisk(disk);
        }
    }
}
