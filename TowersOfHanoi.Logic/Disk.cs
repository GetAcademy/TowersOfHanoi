namespace TowersOfHanoi.Logic
{
    public class Disk
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
