using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace Circustrein
{
    public abstract class Animal
    {
        private readonly string _name;
        private readonly int _size;

        public Animal(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public int GetSize()
        {
            return _size;
        }

        public string GetName()
        {
            return _name;
        }
    }
}