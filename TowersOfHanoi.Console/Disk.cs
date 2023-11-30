namespace TowersOfHanoi.Console
{
    internal class Disk
    {
        public int Size { get; }

        public Disk(int size)
        {
            Size = size;
        }

        public bool IsGreaterThan(Disk topDisk)
        {
            return Size > topDisk.Size;
        }
    }
}
