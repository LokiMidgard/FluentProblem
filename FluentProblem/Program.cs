using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            // code will generated when ftl file is changed.
            // use "go to definition" to get to the code.

            // Will not work
            var sharedPhotos = Sample.SharedPhotos["test", 4, "male"];
            
            // will not work
            var test = Sample.Test["Test-User", 1];

            // Will Work
            var halloWorld = Sample.HelloWorld;

            Console.WriteLine(halloWorld); 
            Console.WriteLine(sharedPhotos);
            Console.WriteLine(test);
            Console.ReadKey(true);
        }
    }
}
