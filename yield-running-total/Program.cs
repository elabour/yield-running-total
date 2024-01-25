using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yield_running_total
{
    internal class Program
    {
      
public static List<int> vals = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


public static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;

            foreach (int val in vals)
            {
                runningTotal += val;
                yield return runningTotal;
            }
        }
        static void Main(string[] args)
        {

        
            foreach (int x in RunningTotal())
            {
                Console.WriteLine(x);
            }

            Console.Read();

        }

       

    }
}
