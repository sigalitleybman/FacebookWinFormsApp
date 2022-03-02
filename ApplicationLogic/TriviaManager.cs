using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    class TriviaManager
    {
        private readonly Dictionary<string, string> r_TriviaQuestionsAndAnswers;
        private List<string> m_ListOfQuestions;
        private DateTime m_BirthDateOfTheFriend;

        private User m_ChosenFriend { get; set; }
        private User m_LoggedInUser { get; set; }
        public TriviaManager(User i_ChosenFriend)
        {
            m_ChosenFriend = i_ChosenFriend;
            m_ListOfQuestions = new List<string>();
            r_TriviaQuestionsAndAnswers = new Dictionary<string, string>();
            m_BirthDateOfTheFriend = Convert.ToDateTime(m_ChosenFriend.Birthday);
        }

        private void initializeQuestions(User m_ChosenFriend)
        {
            m_ListOfQuestions.Add($"In which city {m_ChosenFriend.Name} lives?");
            m_ListOfQuestions.Add($"How old {m_ChosenFriend.Name} is?");
            m_ListOfQuestions.Add($"What is {m_ChosenFriend.Name}'s birthday month?");
        }

        private void initializeDictionaryOfQuestionsAndAnswers()
        {
            //int[] values = Enum.GetValues(typeof(eKeyQuestions));
            
            foreach (eKeyQuestions keyQuestion in Enum.GetValues(typeof(eKeyQuestions)))
            {
                r_TriviaQuestionsAndAnswers.Add(m_ListOfQuestions[(int)keyQuestion], GetSpecificAnswer(keyQuestion));
            }
        }

        private string GetSpecificAnswer(eKeyQuestions i_KeyQuestion)
        {
            string specificAnswer = null;

            switch (i_KeyQuestion)
            {
                case eKeyQuestions.City:
                    specificAnswer = m_ChosenFriend.Location.Location.City;
                    break;
                case eKeyQuestions.Age:
                    specificAnswer = calculateTheAgeOfTheFriend();
                    break;
                case eKeyQuestions.BirthMonth:
                    specificAnswer = m_BirthDateOfTheFriend.Month.ToString();
                    break;
            }

            return specificAnswer;
        }

        private string calculateTheAgeOfTheFriend()
        {
            var todayTime = DateTime.Today;
            int currentFriendAge = todayTime.Year - m_BirthDateOfTheFriend.Year - 1;

            return currentFriendAge.ToString();
        }
        internal List<string> GetListOfQuestions ()
        {
            return m_ListOfQuestions;
        }

        private List<string> getListOfAgesAnswers()
        {
           // TODO: check about negetive age 

            string friendAge = calculateTheAgeOfTheFriend();
            List<string> listOfOptionalAgesAnswers = new List<string>();
            Random random = new Random();
            string firstAgeOptional;
            string secondAgeOptional; 
            int minAgeOptional = Int32.Parse(friendAge) - 5;
            int maxAgeOptional = Int32.Parse(friendAge) + 5;

            while (true)
            {
                firstAgeOptional = random.Next(minAgeOptional, maxAgeOptional).ToString();
                secondAgeOptional = random.Next(minAgeOptional, maxAgeOptional).ToString();

                if (!firstAgeOptional.Equals(secondAgeOptional) &&
                    !firstAgeOptional.Equals(friendAge) &&
                    !secondAgeOptional.Equals(friendAge))
                {
                    break;
                }
            }

            return listOfOptionalAgesAnswers;
        }

        private List<string> getListOfCitiesAnswers()
        {
            List<string> listOfOptionalCitiesAnswers = new List<string>();
            string correctAnswer = GetSpecificAnswer(eKeyQuestions.City);
            Random random = new Random();
            string firstCityOptional;
            string secondCityOptional;

            while (true)
            {
                firstCityOptional = random.Next(Enum.GetNames(typeof(eCitiesAnswers)).Length).ToString();
                secondCityOptional = random.Next(Enum.GetNames(typeof(eCitiesAnswers)).Length).ToString();

                if(!firstCityOptional.Equals(secondCityOptional) &&
                   !firstCityOptional.Equals(correctAnswer) &&
                   !secondCityOptional.Equals(correctAnswer))
                {
                    break;
                }
            }

            listOfOptionalCitiesAnswers.Add(firstCityOptional);
            listOfOptionalCitiesAnswers.Add(secondCityOptional);
            listOfOptionalCitiesAnswers.Add(correctAnswer);

            return listOfOptionalCitiesAnswers;
        }

        private List<string> getListOfMonthsAnswers()
        {
            List<string> listOfOptionalMonthsAnswers = new List<string>();
            string correctAnswer = GetSpecificAnswer(eKeyQuestions.BirthMonth);
            Random random = new Random();
            string firstMonthOptional;
            string secondMonthOptional;

            while (true)
            {
                firstMonthOptional = random.Next(Enum.GetNames(typeof(eMonthAnswers)).Length).ToString();
                secondMonthOptional = random.Next(Enum.GetNames(typeof(eMonthAnswers)).Length).ToString();

                if (!firstMonthOptional.Equals(secondMonthOptional) &&
                    !firstMonthOptional.Equals(correctAnswer) &&
                    !secondMonthOptional.Equals(correctAnswer))
                {
                    break;
                }
            }

            listOfOptionalMonthsAnswers.Add(firstMonthOptional);
            listOfOptionalMonthsAnswers.Add(secondMonthOptional);
            listOfOptionalMonthsAnswers.Add(correctAnswer);

            return listOfOptionalMonthsAnswers;
        }

        private enum eKeyQuestions
        {
            City = 0,
            Age,
            BirthMonth
        }

        private enum eCitiesAnswers
        {
            Batyam,
            Ramle,
            Holon,
            Rishon,
            TelAviv,
            Karmiel,
            Lod,
            Rehovot,
            Yafo,
            Eilat
        }

        private enum eMonthAnswers
        {
            January = 0,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        

    }
}
