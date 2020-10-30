using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // This feature was added in .Net Framework 4.7.
            // it is the simplest form of making Tuple
            //ValueTuple
            DataOperations dataOperations = new DataOperations();
            var fullname=dataOperations.GetFullName();
            Console.WriteLine(string.Format("{0} {1}", fullname.firstname, fullname.lastname));
            Console.ReadKey();
        }
    }
}
