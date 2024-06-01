using System;
using System.Collections.Generic;

namespace Search
{
    internal class UIDatabase
    {
        private Database _database = new Database();

        public void Work()
        {
            const string SearchCrimonal = "1";
            const string ExitProgramm = "2";

            string userInpat;

            bool isProgrammWork = true;

            while (isProgrammWork)
            {
                Console.Clear();
                Console.WriteLine($"Для поиска введите {SearchCrimonal} " +
                $"Для выхода {ExitProgramm}");

                userInpat = Console.ReadLine();

                switch (userInpat)
                {
                    case SearchCrimonal:
                        Search();
                        break;

                    case ExitProgramm:
                        isProgrammWork = false;
                        break;
                }
            }
        }

        private void Search()
        {
            int inputUserHeight = GetUserNumber("Введите рост");
            int inputUserWeight = GetUserNumber("Введите вес");

            Console.WriteLine("Введите национальность");

            string inputUserNationality = Console.ReadLine();

            _database.SearchCriminal(inputUserHeight, inputUserWeight, inputUserNationality);
        }

        private int GetUserNumber(string message)
        {
            int number = 0;

            string input = "";

            bool isNumber = false;

            while (isNumber == false)
            {
                Console.WriteLine(message);

                input = Console.ReadLine();

                isNumber = int.TryParse(input, out number);

                if (isNumber == false)
                    Console.WriteLine("Вы ввели не целое число.");
                else
                    isNumber = true;

                Console.Clear();
            }

            return number;
        }
    }
}