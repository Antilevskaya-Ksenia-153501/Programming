using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public abstract class Commodity
    {
        public Commodity()
        {
            Console.WriteLine("Конструкор базового класса вызван");
        }
        protected DateTime ManufactureDate;
        protected string Name;
        protected int Price;
        protected int WorkingLife;
        public abstract string Info();

        public virtual bool IsCorrespondsToWorkingLife(DateTime currentDate)
        {
            return (currentDate < ManufactureDate + new TimeSpan(WorkingLife, 0, 0, 0));
        }

        public virtual void Buy()
        {
            Console.WriteLine("Цена за штуку - {0}", Price);
        }

        public string Sold()
        {
            return "Продано в количестве 1 штуки";
        }
    }

    public class Product : Commodity
    {
        public Product(string name, int price, DateTime manufactureDate, int workingLife)
        {
            Name = name;
            Price = price;
            ManufactureDate = manufactureDate;
            WorkingLife = workingLife;
        }

        public override string Info()
        {
            return string.Format("\nНазвание продукта - {0}\nЦена - {1}\nДата производства - {2}\nСрок годности - {3} дней", Name, Price, ManufactureDate, WorkingLife);
        }

    }

    public sealed class Batch : Product
    {
        private int Count;
        public Batch(string name, int price, DateTime manufactureDate, int workingLife, int count) : base(name, price, manufactureDate, workingLife)
        {
            Count = count;
        }

        public override string Info()
        {
            return string.Format("\nНазвание продукта - {0}\nЦена - {1}\nКоличество - {2}\nДата производства - {3}\nСрок годности - {4} дней", Name, Price, Count, ManufactureDate, WorkingLife);
        }

        public override void Buy()
        {
            Console.WriteLine("Цена за штуку - {0}",Math.Abs(Price/Count));
        }

        public string Sold(int Number)
        {
            Count -= Number;
            if (Count != 0 && Count > 0)
                return string.Format("\nПродано в количестве {0} штук(-и)", Number);
            else 
                return "Вы хотите продать больше, чем имеете";
        }
    }
}
