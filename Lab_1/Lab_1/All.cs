using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class All : IInterface
    {
        private string something;
        public string Something { get; set; }

        public virtual void Method() 
        {
            Console.WriteLine("Hello!");
        }

        public void Start() 
        {
            Console.WriteLine("Start!");
        }
    }
}
