using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    public class Second : IFirst
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

        public void Upgrade(int amount) 
        {
            SecondTotal += amount;
        }
        public void Downgrade(int amount)
        {
            SecondTotal -= amount;
        }

        int IFirst.Amount { get; set; }
        IFirst.AmountHandler? message;
        event IFirst.AmountHandler IFirst.Message
        {
            add => message += value;
            remove => message -= value;
        }
        private int[] arr = new int[100];
        public int this[int index]   
        {
            get => arr[index];
            set => arr[index] = value;
        }

        public Second(string name, string secondName, string thirdName, int total, int secondTotal, int thirdTotal)
        {
            this.name = name;
            this.secondName = secondName;
            this.thirdName = thirdName;
            Total = total;
            SecondTotal = secondTotal;
            ThirdTotal = thirdTotal;
        }
    }
}
