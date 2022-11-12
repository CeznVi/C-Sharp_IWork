using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IWork
{
    //Класс бригади будівельників
    internal class Team
    {

        public List<IWorker> teamlist = new List<IWorker> { };
        public void PrintBrigadeComposition()
        {
            Console.WriteLine("Склад бригади: ");
            foreach (var item in teamlist)
            {
                Console.WriteLine($"- {item.Name} -=- {item.ReturnJobTitle()}");
            }
        }
    }

    //Класс будівельник
    internal class Worker : IWorker
    {
        private string JobTitle = "будівельник";
        public string Name { get; set; }
        public Worker(string n) { Name = n; }
        public string ReturnJobTitle()
        {
            return JobTitle;
        }
        public void Create(House house, Team team)
        {
            if (house.basement == null)
            {
                Basement basement = new Basement();
                basement.Create(house);
                Console.WriteLine($"Будівельник {Name} встановив {basement.Name}");
            }
            else if (house.walls == null || house.walls.Count < 4)
            {
                if (house.walls == null)
                    house.walls = new List<Walls>();
                Walls walls = new Walls();
                walls.Create(house);
                Console.WriteLine($"Будівельник {Name} встановив {walls.Name}");
            }
            else if (house.roof == null)
            {
                Roof roof = new Roof();
                roof.Create(house);
                Console.WriteLine($"Будівельник {Name} встановив {roof.Name}");

            }
            else if (house.door == null)
            {
                Door door = new Door();
                door.Create(house);
                Console.WriteLine($"Будівельник {Name} встановив {door.Name}");
            }
            else if (house.windows == null || house.windows.Count < 4)
            {
                if (house.windows == null)
                    house.windows = new List<Window>();
                Window windows = new Window();
                windows.Create(house);
                Console.WriteLine($"Будівельник {Name} встановив {windows.Name}");
            }
        }
    }
    //Класс бригадир
    internal class TeamLeader : IWorker
    {
        private string JobTitle = "бригадир";

        public string Name { get; set; }
        public TeamLeader(string n) { Name = n; }

        public string ReturnJobTitle()
            {
                return JobTitle;
            }
        public void Create(House house, Team team)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"--Бригадир {Name} підготував звіт:");
            house.Report();
            Console.WriteLine("------------------------------------");
        }
    }
    
    
}
