using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonLoops
{
    class Genus
    {
        private string name;
        protected string sound;

        protected GenusId genusId = new GenusId();
        public void SetGenusId(int id, string owner)
        {
            genusId.Id = id;
            genusId.Owner = owner;
        }
        public void GetGenusId()
        {
            Console.WriteLine($"{Name} id is {genusId.Id} and owned by {genusId.Owner}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound}");
        }

        public Genus()
            :this("No Name", "No Sound") { }

        public Genus(string name)
            :this(name, "No Sound") { }

        public Genus(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(Char.IsDigit))
                {
                    name = "No Name";
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                }
                else
                {
                    sound = value;
                }
            }
        }
        public class AnimalHealth
        {
            public bool HealthyWeight(double height,
                double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else return false;
            }

        }
    }
}
