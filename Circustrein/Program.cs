using System;
using System.Collections.Generic;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Lion = new Animal("lion", 3, false);
            Animal Giraffe = new Animal("giraffe", 5, true);
            Animal Zebra = new Animal("zebra", 3, true);
            Animal Antilope = new Animal("antilope", 3, true);
            Animal GrizzlyBear = new Animal("Grizzlybeer", 5, false);
            Animal Eekhoorn = new Animal("Eekhoorn", 1, true);
            Animal Birderspin = new Animal("Vogelspin", 1, false);
            var wagons = new Wagons();

            wagons.AddAnimalToWagon(Lion);
            wagons.AddAnimalToWagon(Giraffe);
            wagons.AddAnimalToWagon(Zebra);
            wagons.AddAnimalToWagon(Antilope);
            wagons.AddAnimalToWagon(GrizzlyBear);
            wagons.AddAnimalToWagon(Eekhoorn);
            wagons.AddAnimalToWagon(Birderspin);

            //wagons.AddAnimalToWagon(Lion);
            //wagons.AddAnimalToWagon(Giraffe);
            //wagons.AddAnimalToWagon(Zebra);
            //wagons.AddAnimalToWagon(Antilope);
            //wagons.AddAnimalToWagon(GrizzlyBear);
            //wagons.AddAnimalToWagon(Eekhoorn);
            //wagons.AddAnimalToWagon(Birderspin);

            Console.WriteLine(wagons.ReturnAnimalsFromWagons());
        }
    }
}
