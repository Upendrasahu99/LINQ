using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
    internal class Collection
    {
        List<int> numbers = new List<int> { 1, 5, 3, 6 };
        public void findEven()
        {
           
            // LINQ query for find even number 
            var evenNumber = from num in numbers
                             where num % 3 == 0
                             select num;

            foreach (var num in evenNumber)
            {
                Console.WriteLine(num);
            }
        }

        public void NumberHavingFactor3()
        {
            // LINQ query for find the number having factor 3
            var Factor3 = from num in numbers where num % 3 == 0 select num;
            foreach ( var num in Factor3)
            {
                Console.WriteLine(num);
            }
        }
    }
}
