using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    public class Third
    {
        public int someCount;
        public int SomeCount 
        { 
            get { return someCount; } 
            set { someCount = value; } 
        }
        private string someDescription;
        public string SomeDescription 
        { 
            get { return someDescription; }
            set { someDescription = value; } 
        }
        protected bool someFix;
        public bool SomeFix 
        { 
            get { return someFix; } 
            set { someFix = value; } 
        }

        public Third(int someCount, string someDescription, bool someFix)
        {
            this.someCount = someCount;
            SomeDescription = someDescription;
            this.someFix = someFix;
        }

        public void GetSomeMore() 
        {
            if (someCount >= 5)
                Console.WriteLine("Succesful!");
            else
                Console.WriteLine("Oh, lets try again :/");
        }
    }
}
