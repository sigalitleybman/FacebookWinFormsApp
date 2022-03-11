using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    public class ApplicationManager
    {
        public User LoggedInUser { get; set; }
        private TriviaManager m_TriviaManager;
        private FindYourMatchManager m_FindYourMatchManager;
        private MainFormManager m_MainFormManager;
        
        public ApplicationManager() 
        {
            m_TriviaManager = new TriviaManager();
            m_FindYourMatchManager = new FindYourMatchManager();
            m_MainFormManager = new MainFormManager();
        }

        public void initializeQuestions(FictionUsers i_ChosenFriend)
        {
             m_TriviaManager.initializeQuestions(i_ChosenFriend);
        }

        public List<string> GetListOfQuestions()
        {
            return m_TriviaManager.GetListOfQuestions();
        }

        public List<string> GetListOfAnswers(int i_IndexOfSpecificQuestion)
        {
            switch (i_IndexOfSpecificQuestion)
            {
                case 0:
                    return m_TriviaManager.getListOfCitiesAnswers();
                case 1:
                    return m_TriviaManager.getListOfAgesAnswers();
                case 2:
                    return m_TriviaManager.getListOfMonthsAnswers();
            }

            return null;
        }

        public void resetWrongAndCorrectAnswers()
        {
            m_TriviaManager.resetWrongAndCorrectAnswers();
        }

        public bool CheckIfAnswerIsCorrect(eKeyQuestions i_CurrentQuestion, string i_ChosenAnswer)
        {
            return m_TriviaManager.checkIfAnswerIsCorrect(i_CurrentQuestion, i_ChosenAnswer);
        }

        public void updateResults(int i_IndexOfQuestion, bool i_IsCorrectAnswer)
        {
            m_TriviaManager.updateResults(i_IndexOfQuestion, i_IsCorrectAnswer);
        }

        public int GetCorrectResults()
        {
            return m_TriviaManager.getCorrectResults();
        }

        public int GetWrongResults()
        {
            return m_TriviaManager.getWrongResults();
        }

        public void initializeChosenFriend(FictionUsers i_ChosenFriend)
        {
            m_TriviaManager.initializeChosenFriend(i_ChosenFriend);
        }

        public List<FictionUsers> GetListOfFictionUsersToTriviaForm()
        {
            return m_TriviaManager.GetListOfFictionUsers();
        }

        public void initializeDictionaryOfQuestionsAndAnswers()
        {
            m_TriviaManager.initializeDictionaryOfQuestionsAndAnswers();
        }

        public bool checkIfThereIsMatch(string i_Gender, string i_Age, string i_City)
        {
            return m_FindYourMatchManager.checkIfThereIsMatch(i_Gender, i_Age, i_City);
        }

        public FictionUsers GetPotentionalMatch()
        {
            return m_FindYourMatchManager.GetPotentionalMatch();
        }

        public List<FictionUsers> GetListOfFictionUsersToMainForm()
        {
            return m_MainFormManager.GetListOfFictionUsersToMainForm();
        }

        /**
         * In case we can access the user's friends via facebook
         */
        //public User GetPotentionalMatchUser()
        //{
        //    return m_FindYourMatchManager.GetPotentionalMatchUser();
        //}

        /**
        * In case we can access the user's friends via facebook
        */
        //public int getUserAge()
        //{
        //    return m_FindYourMatchManager.calculateTheAgeOfTheUser();
        //}
    }
}
