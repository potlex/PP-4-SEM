using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2
{
    public class Fourth : Third
    {
        private int id;
        public int Id 
        { 
            get { return id; } 
            set { id = value; } 
        }

        public Fourth(int _id, int someCount, string someDescription, bool someFix) : base(someCount, someDescription, someFix)
        {
            this.id = _id;
            this.SomeCount = someCount;
            this.SomeFix = someFix;
            this.SomeDescription = someDescription;
        }

        public void GetInfo() 
        {
            if (someFix != false)
            {
                Console.WriteLine($"Object information:\n" +
                                  $"ID: {id}\n" +
                                  $"Count: {someCount}\n" +
                                  $"Type: {SomeDescription}\n");
            }
            else
                Console.WriteLine($"Information about object is not correct!");
;        }
    }
}
