using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Problem_3.Generic_List.Attributes;
using Problem_3.Generic_List.Models;


namespace Problem_4.Generic_List_Version
{
    class Program
    {
        static void Main(string[] args)
        {
            Type typeList = typeof (GenericList<>);
            Object[] attributes = typeList.GetCustomAttributes(false);
            foreach (Object attribute in attributes)
            {
                Console.WriteLine(((VersionAttribute)attribute).Version);
            }
            //Same thing using lambda 
                typeof (GenericList<>).GetCustomAttributes(false)
                    .OfType<VersionAttribute>()
                    .ToList()
                    .ForEach(p => Console.WriteLine(p.Version));
        }
    }
}
