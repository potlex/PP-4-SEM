using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    public class First
    {
        private const int count = 3;
        public const int secondCount = 5;
        protected const int thirdCount = 10;

        private string name;
        public string secondName;
        protected string thirdName;

        private int Total { get; set; }
        public int SecondTotal { get; set; }
        protected int ThirdTotal { get; set; }  

        public First () { }
        public First (First previousFirst) 
        {
            name = previousFirst.name;
            secondName = previousFirst.secondName;
            thirdName = previousFirst.thirdName;
            Total = previousFirst.Total;
            SecondTotal = previousFirst.SecondTotal;
            ThirdTotal = previousFirst.ThirdTotal;
        }
        public First(string name, string secondName, string thirdName, 
            int total, int secondTotal, int thirdTotal)
        {
            this.name = name;
            this.secondName = secondName;
            this.thirdName = thirdName;
            Total = total;
            SecondTotal = secondTotal;
            ThirdTotal = thirdTotal;
        }

        public void Check() 
        {
            if (SecondTotal == 0)
            {
                Console.WriteLine("Total is empty!");
            }
        }
        private int PrivateCheck() 
        {
            if (Total != 0)
            {
                Total = 0;
                Console.WriteLine($"Total = {Total}");
                return Total;
            }
            else 
                return 1;
        }
        protected string ProtectedCheck()
        {
            if (thirdName.Length != 0)
            {
                thirdName += " sss...";
                return thirdName;
            }
            else
            {
                return thirdName = "Empty :/";
            }
        }
    }
}
