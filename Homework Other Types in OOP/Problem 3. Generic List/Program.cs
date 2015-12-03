using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Problem_3.Generic_List.Models;

namespace Problem_3.Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<String> imena = new GenericList<string>();
            imena.Add("Pesho");
            imena.Add("Mesho");
            imena.Add("Gosho");
            imena.Add("Tosho");
            imena.Add("Misho");
           
            Console.WriteLine(imena.Count);
            Console.WriteLine(imena.Contains("Gosho"));
            Console.WriteLine(imena.Min());
            Console.WriteLine(imena.Max());
            Console.WriteLine(imena.ElementAtIndex(0));
            Console.WriteLine(imena);
        }
    }
}
