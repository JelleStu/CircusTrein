using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public abstract class AnimalInterface
    {
        private int size;
    }

    public class FaggotVegan : Animal {
        public FaggotVegan(string _name, int _size, bool _herbivoor) : base("Giraffe", 5, true)
        {
        }
    };
    public class UberCarnivoor : Animal {
        public UberCarnivoor(string _name, int _size, bool _herbivoor) : base(" leeuw", 3, false)
        {
        }
    };
    
}
