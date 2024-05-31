using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    internal class Database
    {
        private List<Сriminal> _criminals = new List<Сriminal>
        {
            new Сriminal("Пупкин Иван Иванович",22,180,70,"Грузин",false),
            new Сriminal("Петрова Наталья Адольфовна",32,172,50,"Узбек",false),
            new Сriminal("Уткин Карабас Барабасович",42,183,90,"Русский",true),
            new Сriminal("Пеньков Пенек Игоревич",54,174,70,"Бурят",true),
            new Сriminal("Голубев Иван Васильевич",23,181,79,"Татар",true),
            new Сriminal("Питухов Альберт Михайлович",98,189,89,"Чеченец",false)
        };

        public List<Сriminal> GetCriminalList() 
        {
            List<Сriminal> copyCriminals = new List<Сriminal>(_criminals);

            return copyCriminals; 
        }
    }
}
