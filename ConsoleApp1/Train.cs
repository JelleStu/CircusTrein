using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        private string returnmessage;
        private List<Wagon> wagons = new List<Wagon>();

        public Train()
        {
            wagons = new List<Wagon>();
        }

        public string ReturnAnimalsFromWagons()
        {
            StringBuilder sb = new StringBuilder();
            for (var i = 0; i < wagons.ToList().Count; i++)
            {
                var wagon = wagons.ToList()[i];
                sb.AppendLine($"Wagon {i} : {wagon.AnimalsInWagon()} size remaining: {wagon.GetSize()}.");
            }

            return sb.ToString();
        }

        public void AddAnimal(Animal animal)
        {
            Wagon availableWagon = null;
            foreach (Wagon w in wagons)
            {
                if (w.CanAddAnimal(animal))
                {
                    availableWagon = w;
                    break;
                }
            }

            if (availableWagon == null)
            {
                availableWagon = new Wagon();
                wagons.Add(availableWagon);
            }

            availableWagon.Add(animal);
        }
    }
}