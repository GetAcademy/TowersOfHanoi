namespace TowersOfHanoi.Logic
{
    public class Tower
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

        public Disk GetTopDisk()
        {
            return _disks.Peek();
        }

        public Disk RemoveDisk()
        {
            return _disks.Pop();
        }

        public bool AddDisk(Disk disk)
        {
            if (_disks.Count > 0)
            {
                var topDisk = _disks.Peek();
                if (disk.IsGreaterThan(topDisk)) return false;
            }
            _disks.Push(disk);
            return true;
        }
    }
}
