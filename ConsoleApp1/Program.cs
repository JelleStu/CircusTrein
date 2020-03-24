using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Animal Lion = new Carnivoor("lion", 3);
            Animal Giraffe = new Herbivoor("giraffe", 5);
            Animal Zebra = new Herbivoor("zebra", 3);
            Animal Antilope = new Herbivoor("antilope", 3);
            Animal GrizzlyBear = new Carnivoor("Grizzlybeer", 5);
            Animal Squirrel = new Herbivoor("Squirrel", 1);
            Animal Tarantulla = new Carnivoor("Tarantulla", 1);
            Animal Monkey = new Herbivoor("monkey", 3);
            Animal Elephant = new Herbivoor("elephant", 3);
            Train train = new Train();

            train.AddAnimal(Lion);
            train.AddAnimal(Giraffe);
            train.AddAnimal(Zebra);
            train.AddAnimal(Antilope);
            train.AddAnimal(GrizzlyBear);
            train.AddAnimal(Squirrel);
            train.AddAnimal(Tarantulla);
            train.AddAnimal(Monkey);
            train.AddAnimal(Elephant);

            Console.WriteLine(train.ReturnAnimalsFromWagons());
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.ToString());
        }
    }
}
