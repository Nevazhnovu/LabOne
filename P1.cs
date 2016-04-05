using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {


        //[protocol]://[server]/[resource]
        //            http://www.devbg.org/forum/index.php

        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter your URL: ");
                string url = Console.ReadLine();
            	
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR! " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
