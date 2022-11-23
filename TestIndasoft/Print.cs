using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndasoft
{
    internal class Print
    {
        public static void ForUser(string message)
        {
            Console.WriteLine("Сообщение для пользователя :"+ message);
            Console.ReadLine();
        }

        public static void InMessage(string message)
        {
            Console.WriteLine("Внутренняя информация :" + message);
            Console.ReadLine();
        }
    }
}
