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
        //private List<string> m_ListOfQuestions;

        public ApplicationManager() 
        {
            //m_LoggedInUser = i_LoggedInUser;
            m_TriviaManager = new TriviaManager();
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

        //public bool CheckIfAnswerIsCorrect(eKeyQuestions currentQuestion, string chosenAnswer)
        //{

        //}



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
