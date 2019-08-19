using System;
using System.Diagnostics;
using System.Linq;

namespace ProcessQueriesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process[] procs = System.Diagnostics.Process.GetProcesses();   //method that returns all processes

            //foreach (var item in collection)
           // {
                var procs = from p in System.Diagnostics.Process.GetProcesses()
                            where p.WorkingSet64 > 100000000
                            orderby p.ProcessName
                            select p;
            foreach (var item in procs)
            {
                Console.WriteLine(item.ProcessName)
            }
            Console.ReadLine();    
            
    }
}
