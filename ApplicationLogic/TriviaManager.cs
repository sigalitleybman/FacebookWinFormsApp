using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    //check git !!!
    internal class TriviaManager
    {
        private readonly Dictionary<string, string> r_TriviaQuestionsAndAnswers;
        private readonly List<string> m_ListOfQuestions;
        private DateTime m_BirthDateOfTheFriend;
        private int m_CorrectAnswers = 0;
        private int m_WrongAnswers = 0;

        internal User ChosenFriend { get; set; }
       // internal User LoggedInUser { get; set; }
        
        public TriviaManager()
        {
            //ChosenFriend = i_ChosenFriend;
            m_ListOfQuestions = new List<string>();
            r_TriviaQuestionsAndAnswers = new Dictionary<string, string>();
            m_BirthDateOfTheFriend = Convert.ToDateTime(ChosenFriend.Birthday);
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
                    specificAnswer = ChosenFriend.Location.Location.City;
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

        internal List<string> getListOfAgesAnswers()
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

            listOfOptionalAgesAnswers.Add(firstAgeOptional);
            listOfOptionalAgesAnswers.Add(secondAgeOptional);
            listOfOptionalAgesAnswers.Add(friendAge);

            return listOfOptionalAgesAnswers;
        }

        internal List<string> getListOfCitiesAnswers()
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

        internal List<string> getListOfMonthsAnswers()
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

        //private enum eKeyQuestions
        //{
        //    City = 0,
        //    Age,
        //    BirthMonth
        //}
        internal bool checkIfAnswerIsCorrect(eKeyQuestions eCurrentQuestion, string chosenAnswer)
        {
            bool isCorrectAnswer = false;
            string indexOfQuestion = m_ListOfQuestions[(int)eCurrentQuestion];

            if (r_TriviaQuestionsAndAnswers[indexOfQuestion] == chosenAnswer)
            {
                isCorrectAnswer = true;
            }

            return isCorrectAnswer;
        }

        internal void updateResults(bool i_IsCorrectAnswer)
        {
            if (i_IsCorrectAnswer)
            {
                m_CorrectAnswers++;
            }
            else
            {
                m_WrongAnswers++;
            }
        }

        internal int getCorrectResults()
        {
            return m_CorrectAnswers;
        }

        internal int getWrongResults()
        {
            return m_WrongAnswers;
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
