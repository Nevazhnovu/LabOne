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
            	
Console.WriteLine("Protocol: " + url.Substring(0, url.IndexOf("://")));
                url = url.Substring(url.IndexOf("://") + 3);
                Console.WriteLine("Server: " + url.Substring(0, url.IndexOf('/')));
                

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
