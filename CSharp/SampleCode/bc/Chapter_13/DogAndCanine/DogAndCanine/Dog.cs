﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogAndCanine
{
    public struct Dog
    {
        public string Name;
        public string Breed;

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("My name is {0} and I’m a {1}.", Name, Breed);
        }
    }
}
