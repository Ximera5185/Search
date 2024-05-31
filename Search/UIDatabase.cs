using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Search
{
    internal class UIDatabase
    {
       private List<Сriminal> _сriminals = new List<Сriminal> { };

       public UIDatabase() 
       {
            Method();
       }  
        public void Method() 
        {
            Database database = new Database();

            _сriminals = database.GetCriminalList();

            var filteredCriminals = _сriminals.Where(criminal => criminal.Age >= 40).Select(criminal => criminal);

            foreach (var crimonal in filteredCriminals)
            {
                Console.WriteLine($"{crimonal.FullName} {crimonal.Weight} {crimonal.Height} {crimonal.Nationality} {crimonal.Detained}");
            }

            Console.ReadKey();
        }

        
    }
}
