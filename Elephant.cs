using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVariables
{
    internal class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}.\nMy ears are {EarSize} inches tall.");
        }

    }
}
