using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLogic
{
    class FindYourMatchManager
    {
        private readonly List<FictionUsers> r_ListOfFictionUsers;
        private readonly List<string> r_NorthArea;
        private readonly List<string> r_CenterArea;
        private readonly List<string> r_SouthArea;
        private FictionUsers m_PotentionalMatch;
         
        public FindYourMatchManager()
        {
            r_ListOfFictionUsers = new List<FictionUsers>();
            r_NorthArea = new List<string>();
            r_CenterArea = new List<string>();
            r_SouthArea = new List<string>();
            initializeListOfFictionMatchUsers();
            inializeListOfAreas();
        }

        private void initializeListOfFictionMatchUsers()
        {         
            r_ListOfFictionUsers.Add(new FictionUsers("Avi Ron", eGender.Male, "24", "Karmiel"));
            r_ListOfFictionUsers.Add(new FictionUsers("Avital Cohen", eGender.Female, "32", "Tel Aviv"));
            r_ListOfFictionUsers.Add(new FictionUsers("Moshe Yarkoni", eGender.Male, "45", "Eilat"));
            r_ListOfFictionUsers.Add(new FictionUsers("Michal Fridman", eGender.Female, "38", "Haifa"));
            r_ListOfFictionUsers.Add(new FictionUsers("Roi Levi", eGender.Male, "22", "Ashkelon"));
            r_ListOfFictionUsers.Add(new FictionUsers("Shir Shinom", eGender.Female, "49", "Ramle"));
            r_ListOfFictionUsers.Add(new FictionUsers("Shahar Glick", eGender.Male, "35", "Bat Yam"));
            r_ListOfFictionUsers.Add(new FictionUsers("Noam Golan", eGender.Female, "40", "Rehovot"));
        }

        internal bool checkIfThereIsMatch(string i_Gender, string i_Age, string i_Area)
        {
            int minAge = Int32.Parse((i_Age.Split('-'))[0]);

            int maxAge = Int32.Parse((i_Age.Split('-'))[1]);

            /*int index = i_Age.IndexOf('-');
            int minAge = Int32.Parse(i_Age.Substring(0, index));
            int maxAge = Int32.Parse(i_Age.Substring(index + 1));*/
            string area = null;
            string north = "North";
            string center = "Center";
            string south = "South";
            bool isMatch = false;
            eGender eGender = (eGender)Enum.Parse(typeof(eGender), i_Gender);

            foreach (FictionUsers fictionUser in r_ListOfFictionUsers)
            {
                if (r_NorthArea.Contains(fictionUser.City))
                {
                    area = north;
                }
                if (r_CenterArea.Contains(fictionUser.City))
                {
                    area = center;
                }
                if (r_SouthArea.Contains(fictionUser.City))
                {
                    area = south;
                }
                if (fictionUser.Gender == eGender && area.Equals(i_Area) &&
                    Int32.Parse(fictionUser.Age) >= minAge && Int32.Parse(fictionUser.Age) <= maxAge)
                {
                    m_PotentionalMatch = fictionUser;
                    isMatch = true;
                    break;
                }
            }

            return isMatch;
        }

        private void inializeListOfAreas()
        {
            foreach(FictionUsers fictionUser in r_ListOfFictionUsers)
            {
                if(fictionUser.City.Equals("Karmiel") || fictionUser.City.Equals("Haifa"))
                {
                    r_NorthArea.Add(fictionUser.City);
                }

                if(fictionUser.City.Equals("Tel Aviv") || fictionUser.City.Equals("Ramla") || 
                    fictionUser.City.Equals("Bat Yam") || fictionUser.City.Equals("Rehovot"))
                {
                    r_CenterArea.Add(fictionUser.City);
                }

                if(fictionUser.City.Equals("Ashkelon") || fictionUser.City.Equals("Eilat"))
                {
                    r_SouthArea.Add(fictionUser.City);
                }
            }
        }

        internal FictionUsers GetPotentionalMatch()
        {
            return m_PotentionalMatch;
        }
    }
}
