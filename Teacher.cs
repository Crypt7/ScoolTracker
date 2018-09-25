using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoolTracker
{
    class Teacher : Member, Ipayee
    {
        public string Subject;

        public void Pay()
        {
            Console.WriteLine("paying teacher");
        }
    }

}
