using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    public class Program
    {
        static void Main(string[] args) 
        {
            First firstObject = new First();
            First secondFirstObject = new First("Jame", "Kolles", "Previously", 100, 0, 10);
            First thirdFirstObject = new First(secondFirstObject);

            secondFirstObject.Check();

            Console.WriteLine(secondFirstObject.SecondTotal);
            secondFirstObject.secondName = "Fake";
            Console.WriteLine(secondFirstObject.secondName);

            Second secondObject = new Second("Pit", "Jojh", "Task", 324, 2, 123);
            secondObject.Upgrade(10);
            Console.WriteLine(secondObject.SecondTotal);
            secondObject.Downgrade(5);
            Console.WriteLine(secondObject.SecondTotal);

            Fourth fourthObject = new Fourth(1, 5, "medals", true);
            fourthObject.GetInfo();
            fourthObject.GetSomeMore();
            Console.WriteLine(fourthObject.SomeFix);
            Console.WriteLine(fourthObject.Id);
        }
    }
}
