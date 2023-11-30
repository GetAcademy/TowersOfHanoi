// See https://aka.ms/new-console-template for more information

using TowersOfHanoi.Console;

var disk1 = new Disk(3);
var disk2 = new Disk(5);
var disk3 = new Disk(7);

//var towerA = new Tower(new Disk[0]);
//var towerB = new Tower(new Disk[]{disk1, disk2, disk3});

var towerA = new Tower(5);
var towerB = new Tower(5, disk1, disk2, disk3);

MyConsole.WriteDisk(disk1, 5, 10);
MyConsole.WriteDisk(disk2, 6, 10);
MyConsole.WriteDisk(disk3, 7, 10);