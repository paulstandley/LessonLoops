using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLoops
{
    class Animals
    {
        // protected, methods of a subclass can change values, private, only methods inside the class can change values
        private string name;
        private string sound;

        public const string SHELTER = "Pauls Animal House";
        public readonly int IdNum;

        public void MakeSound()
        {
            Console.WriteLine("{0} makes the sound {1}", name, sound);
        }

        public Animals()
            :this("No Name", "No Sound") { }

        public Animals(string name)
            : this(name, "No Sound") { }

        public Animals(string name, string sound)
        {
            SetName(name);
            Sound = sound;
            numOfAnimals = 1;
            Random rand = new Random();
            IdNum = rand.Next(1, 4366576);
        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }else
            {
                this.name = "No Name";
                Console.WriteLine("Error name canot contain numbers");
            }
        }
        // Get and Set
        public string GetName()
        {
            return name;
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                // value is the set value passed in
                if(value.Length > 13)
                {
                    sound = "No Sound";
                    Console.WriteLine("Your sound was too long");
                }else
                {
                    sound = value;
                }
            }
        }
        // C# can get and set
        public string Owner { get; set; } = "No Owner";

        public static int numOfAnimals = 0;

        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set
            {
                numOfAnimals += value;
            }
        }
    }
}
