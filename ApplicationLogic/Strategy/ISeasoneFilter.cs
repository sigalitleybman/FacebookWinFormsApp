using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Stretegy
{
    internal interface ISeasoneFilter
    {
        bool CheckIfMonthMatch(string i_BirthMonth);
    }
}
