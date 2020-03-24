using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        private int _size = 10;
        private List<Animal> animals;

        public Wagon()
        {
            animals = new List<Animal>();
        }

        public void Add(Animal a)
        {
            animals.Add(a);
            _size -= a.GetSize();
        }

        public bool CanAddAnimal(Animal a)
        {
            if (_size < a.GetSize() || a is Carnivoor && HasCarnivoor())
                return false;
            switch (a)
            {
                case Herbivoor _ when a.GetSize() > GetLargestCarnivoor():
                case Carnivoor _ when a.GetSize() < GetSmallestHerbivoor():
                    return true;
                default:
                    return false;
            }
        }

        private bool HasCarnivoor()
        {
          //  return animals.Any(a => a is Carnivoor);
            foreach (Animal animal in animals)
            {
                if (animal.GetType() == typeof(Carnivoor))
                {
                    return true;
                }
            }
            return false;
        }

        private int GetLargestCarnivoor()
        {
//            Animal largestCarnivoor = animals.Where(a => a is Carnivoor).OrderByDescending(a => a.GetSize())
//                                             .FirstOrDefault();
//            return largestCarnivoor?.GetSize() ?? -1;
            foreach (Animal animal in animals)
            {
                if (animal.GetType() == typeof(Carnivoor))
                {
                    return animal.GetSize();
                }
            }
            return 0;
        }

        private int GetSmallestHerbivoor()
        {
        //    Animal smallestHerbivoor = animals.Where(a => a is Herbivoor).OrderBy(a => a.GetSize()).FirstOrDefault();
        //    return smallestHerbivoor?.GetSize() ?? -1;
            Animal smallestHerbivoor = null;
            foreach (Animal animal in animals)
            {
                if (animal.GetType() == typeof(Herbivoor))
                {
                    if (smallestHerbivoor != null && animal.GetSize() < smallestHerbivoor.GetSize())
                    {
                        smallestHerbivoor = animal;
                    }
                    smallestHerbivoor = animal;
                }
            }
            if (smallestHerbivoor != null) return smallestHerbivoor.GetSize();
                return 0;
        }


        public int GetSize()
        {
            return _size;
        }


        public string AnimalsInWagon()
        {
            StringBuilder sb = new StringBuilder();
            animals.ForEach(a => sb.Append($"{a.GetName()} "));
            return sb.ToString();
        }
    }
}