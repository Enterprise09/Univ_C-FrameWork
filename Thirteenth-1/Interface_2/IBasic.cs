using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    // (1) Create Interface
    interface IBasic
    {
        int TestInstanceMethod();
        int TestProperty { get; set; }
    }
}
