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
            int monthNumber = InputIntNumber("номер месяца :");
            OutStringMessage(GetName(monthNumber), "это : ");
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
                case 1: return "январь , зима";
                case 2: return "февраль , зима";
                case 3: return "март , весна";
                case 4: return "апрель , весна";
                case 5: return "май , весна";
                case 6: return "июнь , лето";
                case 7: return "июль , лето";
                case 8: return "август , лето";
                case 9: return "сентябрь , осень";
                case 10: return "октябрь , осень";
                case 11: return "ноябрь , осень";
                case 12: return "декабрь , зима";
                default: return "ошибка ";
            }
        }
        static void OutStringMessage(string message, string name)
        {
            Console.WriteLine($"{name} : {message}");
        }
    }
}
