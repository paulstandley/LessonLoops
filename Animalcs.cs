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
        }

        // overload constuctor
        public Animalcs(string name = "No Name", string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
        }
    }
}
