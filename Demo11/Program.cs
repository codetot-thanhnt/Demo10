using System;

namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var door = new Door();
            door.Color = "Red";
            //door.ShowData();
            var house = new House(200);
            house.Door = door;
            //var apartment = new Apartment();
            //apartment.Area = 200;
            //apartment.Door = door;
            //apartment.ShowData();
            var person = new Person("Hieu", house);
            //var person = new Person();
            person.ShowData();
            Console.ReadLine();
        }
    }
}
