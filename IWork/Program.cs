using System;
using System.Collections.Generic;
using System.Text;

namespace IWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Підтримка мови
            Console.OutputEncoding = Encoding.Unicode;

            //Ініціалізуємо бригаду
            Team team = new Team();
            team.teamlist.Add(new Worker("Микола"));
            team.teamlist.Add(new Worker("Василій"));
            team.teamlist.Add(new Worker("Юрій"));
            team.teamlist.Add(new Worker("Дмитро"));
            team.teamlist.Add(new TeamLeader("Петро Олексійович Вареник"));     

            //Показати склад бригади
            team.PrintBrigadeComposition();

            //Ініціалізація дому
            House house = new House();

            Random random = new Random();

            Console.WriteLine("\n");

            while(!house.IsFinished())
            {
                team.teamlist[random.Next(0, team.teamlist.Count)].Create(house, team);
            }
                
            







        }
    }
}
