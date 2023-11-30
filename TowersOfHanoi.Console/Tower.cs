namespace TowersOfHanoi.Console
{
    internal class Tower
    {
        private Stack<Disk> _disks;

        public Tower(params Disk[] disks)
        {
            _disks = new Stack<Disk>(disks);
        }
    }
}
