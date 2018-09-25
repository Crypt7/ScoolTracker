using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolTracker
{
    class Principal : Member, Ipayee
    {
        public void Pay()
        {
            Console.WriteLine("paying principal");
        }
    }
}
