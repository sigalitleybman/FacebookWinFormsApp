using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    public class ApplicationManager
    {
        private User m_LoggedInUser { get; set; }
        private TriviaManager m_TriviaManager;
        //private List<string> m_ListOfQuestions;
        public ApplicationManager(User i_LoggedInUser) 
        {
            m_LoggedInUser = i_LoggedInUser;
            m_TriviaManager = new TriviaManager(m_LoggedInUser);
        }

        public List<string> GetListOfQuestions()
        {
            return m_TriviaManager.GetListOfQuestions();
        }

/*        public void ManagerTheQuestions(int i_IndexOfQuestions)
        {
            m_TriviaManager.ManagerTheQuestions(i_IndexOfQuestions);
        }*/
    }
}
