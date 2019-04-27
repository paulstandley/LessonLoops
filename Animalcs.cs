using System;

namespace LessonLoops
{
    class Animalcs
    {
        public string name;
        public string sound;

        public Animalcs()
        {
            name = "No Name";
            sound = "No Sound";
            numberOfAnimals++;
        }

        public Animalcs(string n = "No Name", string s = "No Sound")
        {
            name = n;
            sound = s;
            numberOfAnimals++;
        }

        // void no return value
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        // static fields and methods blong to the class and not the objects created by them
        // if a static feild changes it will change for all off them.
        static int numberOfAnimals = 0;

        public static int GetNumAnimals()
        {
            return numberOfAnimals;
        }
    }
}
