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
        //private List<string> m_ListOfQuestions;

        public ApplicationManager() 
        {
            //m_LoggedInUser = i_LoggedInUser;
            m_TriviaManager = new TriviaManager();
            m_FindYourMatchManager = new FindYourMatchManager();
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

        public bool CheckIfAnswerIsCorrect(eKeyQuestions currentQuestion, string chosenAnswer)
        {
            return m_TriviaManager.checkIfAnswerIsCorrect(currentQuestion, chosenAnswer);
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

        public List<FictionUsers> GetListOfFictionUsers()
        {
            return m_TriviaManager.GetListOfFictionUsers();
        }

        public void initializeDictionaryOfQuestionsAndAnswers()
        {
            m_TriviaManager.initializeDictionaryOfQuestionsAndAnswers();
        }

        public bool checkIfThereIsMatch(string i_Gender, string i_Age, string i_Area)
        {
            return m_FindYourMatchManager.checkIfThereIsMatch(i_Gender, i_Age, i_Area);
        }

        public FictionUsers GetPotentionalMatch()
        {
            return m_FindYourMatchManager.GetPotentionalMatch();
        }

        //public Dictionary<string, string> InitTrivia(User i_ChosenFriend)
        //{

        //    m_TriviaManager = new TriviaManager(){ChosenFriend = i_ChosenFriend};
        //    return m_TriviaManager.InitTriviaQuestionsAndAnswers();
        //}




        /*        public void ManagerTheQuestions(int i_IndexOfQuestions)
                {
                    m_TriviaManager.ManagerTheQuestions(i_IndexOfQuestions);
                }*/
    }
}
