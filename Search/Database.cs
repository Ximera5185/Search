using System;
using System.Collections.Generic;
using System.Linq;

namespace Search
{
    internal class Database
    {
        private List<Сriminal> _criminals = new List<Сriminal>() { };

        public Database() 
        {
            AddCriminalToList();
        }

        private void AddCriminalToList() 
        {
            _criminals.Add(new Сriminal("Пупкин Иван Иванович", 180, 70, "Грузин", false));
            _criminals.Add(new Сriminal("Петрова Наталья Адольфовна", 172, 50, "Узбек", false));
            _criminals.Add(new Сriminal("Петрова Ирина Адольфовна", 172, 50, "Узбек", false));
            _criminals.Add(new Сriminal("Уткин Карабас Барабасович", 183, 90, "Русский", true));
            _criminals.Add(new Сriminal("Пеньков Пенек Игоревич", 174, 70, "Бурят", true));
            _criminals.Add(new Сriminal("Голубев Иван Васильевич", 181, 79, "Татар", true));
            _criminals.Add(new Сriminal("Питухов Альберт Михайлович", 189, 89, "Чеченец", false));
        }

        public void SearchCriminal(int height, int  width, string nationality)
        {
            var filteredCriminals = _criminals.Where(criminal => criminal.Height == height && criminal.Weight == width && criminal.Nationality == nationality && criminal.isDetained == false);

            foreach (var crimonal in filteredCriminals)
            {
                Console.WriteLine($"{crimonal.FullName}");
            }

            Console.ReadKey();
        }
    }
}