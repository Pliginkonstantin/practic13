using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic13_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = InputIntNumber("номер дня недели :");
            OutStringMessage(GetName(dayNumber), "день недели: ");
            Console.Read();
        }
        static int InputIntNumber(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static string GetName(int dayNum)
        {
            switch(dayNum)
            {
                case 1: return "понедельник";
                case 2: return "вторник";
                case 3: return "среда";
                case 4: return "четверг";
                case 5: return "пятница";
                case 6: return "суббота";
                case 7: return "восскресенье";
                default: return "ошибка . значение не является номером дня недели";
            }
        }
        static void OutStringMessage(string message, string name)
        {
            Console.WriteLine($"{name} : {message}");
        }
    }
}
