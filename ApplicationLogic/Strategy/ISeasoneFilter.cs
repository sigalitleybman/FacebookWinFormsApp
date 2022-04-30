using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Stretegy
{
    internal interface ISeasoneFilter
    {
        bool checkIfMonthMatch(string birthMonth);
    }
}
