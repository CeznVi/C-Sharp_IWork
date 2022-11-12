using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWork
{
    //Класс дому
    internal class House
    {
        public Basement basement;
        public List<Walls> walls = new List<Walls> { };
        public List<Window> windows = new List<Window> { };
        public Door door;
        public Roof roof;

        public bool IsFinished()
        {
            if (basement != null && door != null && roof != null && (walls.Count == 4) && (windows.Count == 4))
            {
                Console.WriteLine("\n+++++++++++++++");
                Console.WriteLine("ДІМ побудовано");
                Console.WriteLine("+++++++++++++++");

                return true;
            }
            else
                return false;
        }
        public void Report()
        {
            if (basement != null)
                Console.WriteLine("----фундамент встановлено;");
            if (walls.Count > 0)
                Console.WriteLine($"----стін вствновлено - {walls.Count};");
            if (windows.Count > 0)
                Console.WriteLine($"----вікон вствновлено - {windows.Count};");
            if (door != null)
                Console.WriteLine("----двері встановлено;");
            if (roof != null)
                Console.WriteLine("----кришу встановлено;");

        }
    }

    //Класс фундаменту
    internal class Basement : IPart
    {
        public string Name { get; } = "фундамент";

        public void Create(House house)
        {
            house.basement = new Basement();
        }
        
    }

    //Класс стін
    internal class Walls : IPart
    {
        public string Name { get; } = "стіну";

        public void Create(House house)
        {
            house.walls.Add(new Walls());
        }


    }

    //Класс дверей
    internal class Door : IPart
    {
        public string Name { get; } = "дверь";

        public void Create(House house)
        {
            house.door = new Door();
        }
    }

    //Класс вікон
    internal class Window : IPart
    {
        public string Name { get; } = "вікно";

        public void Create(House house)
        {
            house.windows.Add(new Window());
        }
    }

    //Класс криші
    internal class Roof
    {
        public string Name { get; } = "кришу";

        public void Create(House house)
        {
            house.roof = new Roof();
        }
    }
}
