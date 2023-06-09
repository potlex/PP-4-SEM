using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    public interface IFirst
    {
        public delegate void AmountHandler();
        public event AmountHandler Message;

        public int Amount { get; set; }

        void Upgrade(int amount);
        void Downgrade(int amount);

        public int this[int index] { get; set; }
    }
}
