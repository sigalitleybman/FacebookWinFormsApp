using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    internal class FindYourMatchManager
    {
        private readonly List<FictionUsers> r_ListOfFictionUsers;
        private readonly List<string> r_NorthArea;
        private readonly List<string> r_CenterArea;
        private readonly List<string> r_SouthArea;
        private FictionUsers m_PotentionalMatch;
        private User m_PotentionalMatchUser;
        private readonly User r_LoggedInUser;

        /**
         * In case we can access the user's friends via facebook
         * //private DateTime m_BirthDateOfTheFriend;
         */

        public FindYourMatchManager()
        {
            /**
             *In case we can access the user's friends via facebook
             * // r_LoggedInUser = i_LoggedInUser;
             * //m_BirthDateOfTheFriend = Convert.ToDateTime(r_LoggedInUser.Birthday);
            */
          

            r_ListOfFictionUsers = new List<FictionUsers>();
            r_NorthArea = new List<string>();
            r_CenterArea = new List<string>();
            r_SouthArea = new List<string>();
            initializeListOfFictionMatchUsers();
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

        internal bool checkIfThereIsMatch(string i_Gender, string i_Age, string i_City)
        {
            int minAge = Int32.Parse((i_Age.Split('-'))[0]);

            int maxAge = Int32.Parse((i_Age.Split('-'))[1]);
            bool isMatch = false;
            eGender eGender = (eGender)Enum.Parse(typeof(eGender), i_Gender);


            /**
            * This section is in comment because we cant get user's friends via facebook
            */
            //FacebookObjectCollection<User> userFriends = r_LoggedInUser.Friends;
            //foreach (User user in userFriends)
            //{
            //    int userAge = calculateTheAgeOfTheUser();
            //    if (user.Gender.Equals(i_Gender) && 
            //        userAge >= minAge && userAge <= maxAge &&
            //        user.Location.ToString().ToLower().Equals(i_City))
            //    {
            //        m_PotentionalMatchUser = user;
            //        isMatch = true;
            //        break;
            //    }
            //}

            //return isMatch;



            foreach (FictionUsers fictionUser in r_ListOfFictionUsers)
            {
                if(fictionUser.Gender.Equals(eGender) && fictionUser.City.ToLower().Equals(i_City) &&
                   Int32.Parse(fictionUser.Age) >= minAge && Int32.Parse(fictionUser.Age) <= maxAge)
                {
                    m_PotentionalMatch = fictionUser;
                    isMatch = true;
                    break;
                }
            }

            return isMatch;
        }

        internal FictionUsers GetPotentionalMatch()
        {
            return m_PotentionalMatch;
        }

        /**
         * In case we can access the user's friends via facebook
         */
        //internal User GetPotentionalMatchUser()
        //{
        //    return m_PotentionalMatchUser;
        //}

        /**
        * In case we can access the user's friends via facebook
        */
        //internal int calculateTheAgeOfTheUser()
        //{
        //    var todayTime = DateTime.Today;
        //    int currentAge = todayTime.Year - m_BirthDateOfTheUser.Year - 1;
        //    return currentAge;
        //}

    }
}
