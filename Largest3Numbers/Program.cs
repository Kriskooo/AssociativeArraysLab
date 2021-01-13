using System;
using System.Collections.Generic;
using System.Linq;
namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine(string.Join(' ',list));
            

            //var list = new List<int>()
            //{

            //};
            //var result = list
            //    .Skip()
            //    .Take()
            //    .ToList();
            //foreach (var number in result)
            //{
            //}
        }
    }
}
