using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
//using ApplicationLogic.FictionUsers;

namespace ApplicationLogic
{
    internal class TriviaManager
    {
        private readonly Dictionary<string, string> r_TriviaQuestionsAndAnswers;
        private readonly List<string> m_ListOfQuestions;
        private int m_CorrectAnswers = 0;
        private int m_WrongAnswers = 0;
        private readonly List<FictionUsers> r_ListOfFictionUsers;
        internal FictionUsers ChosenFriend { get; set; }

        /**
         * In case we can access the user's friends via facebook
         * //internal User ChosenFriend;
         * //private DateTime m_BirthDateOfTheFriend;
         */


        // internal User LoggedInUser { get; set; }

        public TriviaManager()
        {
            //LoggedInUser = i_LoggedInUser
            m_ListOfQuestions = new List<string>();
            r_TriviaQuestionsAndAnswers = new Dictionary<string, string>();
            r_ListOfFictionUsers = new List<FictionUsers>();
            initializeListOfFictionFriends();
        }

        private void initializeListOfFictionFriends()
        {
            FictionUsers friend1 = new FictionUsers("25", "Holon", "Haim Levi", "January");
            FictionUsers friend2 = new FictionUsers("20", "Ramle", "Dor Cohen", "August");
            FictionUsers friend3 = new FictionUsers("22", "Karmiel", "Dana Ron", "September");

            r_ListOfFictionUsers.Add(friend1);
            r_ListOfFictionUsers.Add(friend2);
            r_ListOfFictionUsers.Add(friend3);
        }

        public List<FictionUsers> GetListOfFictionUsers()
        {
            return r_ListOfFictionUsers;
        }

        public void initializeChosenFriend(FictionUsers i_ChosenFriend)
        {
            ChosenFriend = i_ChosenFriend;
            //updateTheBirthDateOfTheChosenFriend();
        }

        /**
         * In case we can access the user's friends via facebook
         */
        //private void updateTheBirthDateOfTheChosenFriend()
        //{
        //    m_BirthDateOfTheFriend = Convert.ToDateTime(ChosenFriend.Birthday);
        //}

        internal void initializeQuestions(FictionUsers m_ChosenFriend)
        {
            if (m_ListOfQuestions != null)
            {
                m_ListOfQuestions.Clear();
            }
            m_ListOfQuestions.Add($"In which city {m_ChosenFriend.Name} lives?");
            m_ListOfQuestions.Add($"How old {m_ChosenFriend.Name} is?");
            m_ListOfQuestions.Add($"What is {m_ChosenFriend.Name}'s birthday month?");
        }

        internal void initializeDictionaryOfQuestionsAndAnswers()
        {
            if (r_TriviaQuestionsAndAnswers != null)
            {
                r_TriviaQuestionsAndAnswers.Clear();
            }
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
                    //specificAnswer = ChosenFriend.Location.Location.City;
                   specificAnswer = ChosenFriend.City;
                    break;
                case eKeyQuestions.Age:
                    //specificAnswer = calculateTheAgeOfTheFriend();
                    specificAnswer = ChosenFriend.Age;
                    break;
                case eKeyQuestions.BirthMonth:
                    //specificAnswer = m_BirthDateOfTheFriend.Month.ToString();
                    specificAnswer = ChosenFriend.BirthMonth;
                    break;
            }

            return specificAnswer;
        }

        internal void resetWrongAndCorrectAnswers()
        {
            m_WrongAnswers = 0;
            m_CorrectAnswers = 0;
        }

        /**
         * In case we can access the user's friends via facebook
         */
        //private string calculateTheAgeOfTheFriend()
        //{
        //    var todayTime = DateTime.Today;
        //    int currentFriendAge = todayTime.Year - m_BirthDateOfTheFriend.Year - 1;
        //    return currentFriendAge.ToString();
        //}

        internal List<string> GetListOfQuestions ()
        {
            return m_ListOfQuestions;
        }

        internal List<string> getListOfAgesAnswers()
        {
            /**
             * In case we can access the user's friends via facebook
             * //string friendAge = calculateTheAgeOfTheFriend();
             */

            string friendAge = ChosenFriend.Age;
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
            int randomForFirstCityOptional;
            int randomForSecondCityOptional;
            string firstCityOptional;
            string secondCityOptional;

            while (true)
            {
                randomForFirstCityOptional = random.Next(Enum.GetNames(typeof(eCitiesAnswers)).Length);
                randomForSecondCityOptional = random.Next(Enum.GetNames(typeof(eCitiesAnswers)).Length);
                firstCityOptional = ((eCitiesAnswers)randomForFirstCityOptional).ToString();
                secondCityOptional = ((eCitiesAnswers)randomForSecondCityOptional).ToString();

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
            int randomForFirstMonthOptional;
            int randomForSecondMonthOptional;
            string firstMonthOptional;
            string secondMonthOptional;

            while (true)
            {
                randomForFirstMonthOptional = random.Next(Enum.GetNames(typeof(eMonthAnswers)).Length);
                randomForSecondMonthOptional = random.Next(Enum.GetNames(typeof(eMonthAnswers)).Length);
                firstMonthOptional = ((eMonthAnswers)randomForFirstMonthOptional).ToString();
                secondMonthOptional = ((eMonthAnswers)randomForSecondMonthOptional).ToString();

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

        internal void updateResults(int i_IndexOfQuestion, bool i_IsCorrectAnswer)
        {
            if (i_IndexOfQuestion == 0)
            {
                m_CorrectAnswers = 0;
                m_WrongAnswers = 0;
            }

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
