using System;

namespace ITSUmbria2020.OnlineGameLibrary.Models
{
    abstract class Player
    {
        public string Name { get; set; }
        public int Healtpoints { get; set; }
        public int Manatpoints { get; set; }
        public int ExpBar { get; set; }
        public bool Gender { get; set; }

    }

    class Wizard
    {

    }

    class Warrior
    {

    }

    class Rogue
    {

    }

}
