namespace TowersOfHanoi.Console
{
    internal class Tower
    {
        private readonly Stack<Disk> _disks;

        public Tower(params int[] diskSizes)
        {
            _disks = new Stack<Disk>();
            foreach (var diskSize in diskSizes)
            {
                _disks.Push(new Disk(diskSize));
            }
        }

        public Disk[] GetDisks()
        {
            return _disks.ToArray();
        }
    }
}
