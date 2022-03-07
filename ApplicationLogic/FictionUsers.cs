using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    public class FictionUsers
    {
        public string Age { get; }
        public string City { get; }
        public string Name { get; }
        public string BirthMonth { get; }

        public FictionUsers(string i_Age, string i_City, string i_Name, string i_BirthMonth)
        {
            Age = i_Age;
            City = i_City;
            Name = i_Name;
            BirthMonth = i_BirthMonth;
        }
    }
}
