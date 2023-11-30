namespace TowersOfHanoi.Console
{
    internal class MyConsole
    {
        public static void WriteDisk(Disk disk, int row, int col)
        {
            var x = col - disk.Size / 2;
            System.Console.SetCursorPosition(x, row);
            System.Console.Write(string.Empty.PadLeft(disk.Size, '='));
        }

        public static void WriteTower(Tower tower, int row, int col)
        {

        }
    }
}
