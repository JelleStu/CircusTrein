using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Circustrein
{
    class Wagon
    {
        private int wagonNumber;
        private int size = 10;
        private List<Animal> AnimalsInWagon;
        private bool bigflesheater;
        private bool flesheater;
        private string animalnames;
        private Animal smallestAnimal;
        


        public Wagon(int _wagonNumber)
        {
            this.wagonNumber = _wagonNumber;
            AnimalsInWagon = new List<Animal>();
        }

        public void Add(Animal a)
        {
            AnimalsInWagon.Add(a);
            size -= a.GetSize();
        }

        public bool CanAddAnimal(Animal a)
        {
            if (size > a.GetSize())
                return true;
            return (a is FaggotVegan || a is UberCarnivoor && GetLargestFaggotVegan() > a.GetSize());
        }

        private int GetLargestFaggotVegan()
        {
            Animal a = null;
            a = AnimalsInWagon.Where(ani => ani is FaggotVegan).OrderBy(ani => ani.size).FirstOrDefault();
            return a?.GetSize() ?? -1;
        }




        public void addAnimalToWagon(Animal _animal)
        {
            this.AnimalsInWagon.Add(_animal);
            this.size = this.size - _animal.GetSize();
        }

        public int ReturnSize()
        {
            return this.size;
        }

        public int ReturnWagonNumber()
        {
            return wagonNumber;
        }

        public bool HasBigFleshEater()
        {
            return bigflesheater;
        }

        public string ReturnAnimalsInWagon()
        {
            foreach (Animal Animal in AnimalsInWagon)
            { 
                animalnames += " " + Animal.ReturnNameAnimal();
            }

            return animalnames;
        }

        public void BigFleshEaterInWagon()
        {
            this.bigflesheater = true;
        }

        public bool WagonCheckFleshEater()
        {
            return this.flesheater;
        }

        public void SetFleshEater()
        {
            this.flesheater = true;
        }

        public int SmallestHerbivor()
        {
            Animal smallestHerbivor = null;
                foreach (Animal animal in AnimalsInWagon)
                {
                    if (animal.IsHerbivoor())
                    {
                        smallestHerbivor = animal;
                        break;
                    }
                }

                if (smallestHerbivor == null)
                    return 5; // No herbivors in the list, can't return smallest size

                foreach (Animal animal in AnimalsInWagon)
                    if (animal.IsHerbivoor() && animal.GetSize() <= smallestHerbivor.GetSize())
                        smallestHerbivor = animal;
                return smallestHerbivor.GetSize();
        }

        public int SizeFleshEater()
        {
            if (this.flesheater == true)
            {
                foreach (Animal animalFlesh in AnimalsInWagon)
                {
                    if (animalFlesh.IsHerbivoor() == false)
                    {
                        return animalFlesh.GetSize();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 0;
        }
    }
}
