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
            string name = InputStringNumber(" первая буква предмета:");
            OutStringMessage(GetName(name), "это : ");
            Console.Read();
        }
        static string InputStringNumber(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        static string GetName(string name)
        {
            switch(name.ToLower())
            {
                case "ф": return "физика";
                case "м": return "математика";
                case "и": return "история";
                case "г": return "география";
                case "б": return "биология";
                default: return "ошибка ";
            }
        }
        static void OutStringMessage(string message, string name)
        {
            Console.WriteLine($"{name} : {message}");
        }
    }
}
