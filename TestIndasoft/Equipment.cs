using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndasoft
{
    public class Equipment
    {
        public int Id { get; }
        public string AllInformation = "Вся необходимая информация об оборудовании для лаборатории";

       public Equipment(int id)
        {
            Id = id;
        }
    }
}
