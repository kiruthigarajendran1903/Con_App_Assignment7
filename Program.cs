using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList
            {
                "apple","banana", "cherry", "date", "elderberry"

            };
            Console.WriteLine("\nDisplay the Array List Items");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


          var containsDate = arrayList.Contains("date");
            Console.WriteLine("\nContains 'date': " + containsDate);


            arrayList.Insert(2, "flg");
            foreach (var item in arrayList)
            {
                Console.WriteLine("\n"+item);
            }

            Console.WriteLine("\nAfter deletion");
                arrayList.Remove("banana");
                foreach (var item in arrayList)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

