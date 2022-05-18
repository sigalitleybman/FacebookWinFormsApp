using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Stretegy
{
    internal class BirthMonthFilter
    {
        public ISeasoneFilter SeasoneFilter { get; set; }
        private readonly List<FictionUsers> r_ListOfUserThatMatchTheSeason = new List<FictionUsers> { };

        public List<FictionUsers> FilterByMonth(List<FictionUsers> friendsList)
        {
            foreach(FictionUsers friend in friendsList)
            {
                if(SeasoneFilter.CheckIfMonthMatch(friend.BirthMonth))
                {
                    r_ListOfUserThatMatchTheSeason.Add(friend);
                }
            }

            return r_ListOfUserThatMatchTheSeason;
        }
    }
}
