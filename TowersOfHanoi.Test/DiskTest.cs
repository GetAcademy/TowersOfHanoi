using TowersOfHanoi.Logic;

namespace TowersOfHanoi.Test
{
    internal class DiskTest
    {
        [Test]
        public void Test1()
        {
            // arrange
            var disk1 = new Disk(1);
            var disk2 = new Disk(2);

            // act
            var isGreaterThan = disk1.IsGreaterThan(disk2);

            // assert
            Assert.IsTrue(isGreaterThan);
        }
    }
}
