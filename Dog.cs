﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLoops
{
    class Dog : Genus
    {
        public string Sound2 { get; set; } = "Wooff Woff";

        // overight methods of another class
        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Name", string sound = "No Sound", string sound2 = "No Sound 2")
            :base(name, sound)
        {
            Sound2 = sound2;
        } 
    }
}