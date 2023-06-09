using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Faculty fac = new Faculty();
            Organization example = new Organization();
            Organization org = new Organization(1, "BoomMalePav", "BMP", "242235", DateTime.Now);
            University uni = new University();

            Faculty facNew = new Faculty("GrownPay", "GP", "54534534");
            University uniNew = new University("Destiny Now Incorpotaion", "DN inc", "53254325");
        }
    }
}
