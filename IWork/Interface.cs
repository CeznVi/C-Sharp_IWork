using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWork
{
    internal interface IWorker
    {

        public string Name { get; set; }
        public string ReturnJobTitle();

        public void Create(House house, Team team);
    }

    interface IPart
    {
        public string Name { get; }
        void Create(House house);
    }
}
