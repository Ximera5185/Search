using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class Сriminal
    {

        public Сriminal(string fullName, int age, int height, int weight,string nationality, bool detained)
        {
            FullName = fullName;
            Age = age;
            Height = height;
            Weight = weight;
            Detained = detained;
            Nationality = nationality;
        }

        public string FullName { get; private set; }

        public int Age { get; private set; }
        public int Height { get; private set; } // Рост
        public int Weight { get; private set; } // Вес
        public string Nationality { get; private set; }
        public bool Detained { get; private set; }
    }
}
