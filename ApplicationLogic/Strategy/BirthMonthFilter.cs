using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic.Stretegy
{
    internal class BirthMonthFilter
    {
        public ISeasoneFilter seasoneFilter { get; set; }
        private List<FictionUsers> listOfUserThatMatchTheSeason = new List<FictionUsers> { };

        public List<FictionUsers> FilterByMonth(List<FictionUsers> friendsList)
        {
            foreach(FictionUsers friend in friendsList)
            {
                if(seasoneFilter.checkIfMonthMatch(friend.BirthMonth))
                {
                    listOfUserThatMatchTheSeason.Add(friend);
                }
            }

            return listOfUserThatMatchTheSeason;
        }
    }
}
