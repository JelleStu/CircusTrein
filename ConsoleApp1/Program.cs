using System;
using System.Collections.Generic;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Lion = new Carnivoor("lion", 3);
            Animal Giraffe = new Herbivoor("giraffe", 5);
            Animal Zebra = new Herbivoor("zebra", 3);
            Animal Antilope = new Herbivoor("antilope", 3);
            Animal GrizzlyBear = new Carnivoor("Grizzlybeer", 5);
            Animal Squirrel = new Herbivoor("Squirrel", 1);
            Animal Tarantulla = new Carnivoor("Tarantulla", 1);
            var train = new Train();

            train.AddAnimal(Lion);
            train.AddAnimal(Giraffe);
            train.AddAnimal(Zebra);
            train.AddAnimal(Antilope);
            train.AddAnimal(GrizzlyBear);
            train.AddAnimal(Squirrel);
            train.AddAnimal(Tarantulla);

            Console.WriteLine(train.ReturnAnimalsFromWagons());
        }
    }
}
