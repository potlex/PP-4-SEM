﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            All someall = new All();
            Some somesome = new Some();

            someall.Method();
            somesome.Method();
        }
    }
}