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
            var sharedPhotos = Sample.SharedPhotos["test", 4, "male"];
            var test = Sample.Test["Test-User", 1];
            var halloWorld = Sample.HelloWorld;
            Console.WriteLine(halloWorld); 
            Console.WriteLine(sharedPhotos);
            Console.WriteLine(test);
            Console.ReadKey(true);
        }
    }
}
