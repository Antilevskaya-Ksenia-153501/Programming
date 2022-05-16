using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int duration = 0;
            Console.WriteLine("Введите дату вида дд.мм.гггг: ");
            string date = Console.ReadLine();
            Console.WriteLine(DataService.GetDay(date));
            DateTime date1 = DateTime.Now;
            duration = DataService.GetDaysSpan(date1.Day, date1.Month, date1.Year);
            Console.WriteLine($"Количество дней между введённой датой и текущей: {duration}");

        }
    }
}
