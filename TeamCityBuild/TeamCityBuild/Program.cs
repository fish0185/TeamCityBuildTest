﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCityBuild
{
    using Newtonsoft.Json;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            var result = new Program().Add(10, 20);
            Console.WriteLine(result);
            JsonConvert.SerializeObject("test");
            Console.ReadLine();
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }
    }
}
