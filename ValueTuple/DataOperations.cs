using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTuple
{
    public class DataOperations
    {
      
        public (string firstname, string lastname) GetFullName()
        {
            return ("Mert", "OGUZ");
        }
    }
}
