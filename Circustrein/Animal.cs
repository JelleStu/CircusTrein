using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace Circustrein
{
    public class Animal
    {
        private string name;
        public int size;
        private bool herbivoor; //0 = false 1 = true

        public Animal(string _name, int _size, bool _herbivoor)
        {
            name = _name;
            size = _size;
            herbivoor = _herbivoor;
        }

        public int GetSize()
        {
            return this.size;
        }

        public string ReturnNameAnimal()
        {
            return this.name;
        }

        public bool IsBigFleshEater()
        {
            if (this.size == 5 && this.herbivoor == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsHerbivoor()
        {
            return herbivoor == true;
        }
    }
}
