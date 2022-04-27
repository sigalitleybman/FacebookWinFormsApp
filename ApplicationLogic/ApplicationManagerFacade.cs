using System;
using System.Collections.Generic;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace ApplicationLogic
{
    public sealed class ApplicationManagerFacade
    {
        private static readonly object sr_CreationalLockContext = new object();
        private static ApplicationManagerFacade s_OneAndOnlyInstance = null;
        private TriviaManager r_TriviaManager;
        private FindYourMatchManager r_FindYourMatchManager;
        private MainFormManager r_MainFormManager;
        public User LoggedInUser { get; set; }

        public static ApplicationManagerFacade Instance
        {
            get
            {
                if(s_OneAndOnlyInstance == null)
                {
                    lock (sr_CreationalLockContext)
                    {
                        if(s_OneAndOnlyInstance == null)
                        {
                            s_OneAndOnlyInstance = new ApplicationManagerFacade();
                        }
                    }
                }

                return s_OneAndOnlyInstance;
            }
        }

        private ApplicationManagerFacade()
        {
        }

        public void CreateFeatures()
        {
            r_TriviaManager = new TriviaManager(); 
            r_FindYourMatchManager = new FindYourMatchManager();
            r_MainFormManager = new MainFormManager();
        }

        public void InitializeQuestions(FictionUsers i_ChosenFriend)
        {
             r_TriviaManager.initializeQuestions(i_ChosenFriend);
        }

        public List<string> GetListOfQuestions()
        {
            return r_TriviaManager.getListOfQuestions();
        }

        public List<string> GetListOfAnswers(int i_IndexOfSpecificQuestion)
        {
            switch (i_IndexOfSpecificQuestion)
            {
                case 0:
                    return r_TriviaManager.getListOfCitiesAnswers();
                case 1:
                    return r_TriviaManager.getListOfAgesAnswers();
                case 2:
                    return r_TriviaManager.getListOfMonthsAnswers();
            }

            return null;
        }

        public void ResetWrongAndCorrectAnswers()
        {
            r_TriviaManager.resetWrongAndCorrectAnswers();
        }

        public bool CheckIfAnswerIsCorrect(eKeyQuestions i_CurrentQuestion, string i_ChosenAnswer)
        {
            return r_TriviaManager.checkIfAnswerIsCorrect(i_CurrentQuestion, i_ChosenAnswer);
        }

        public void UpdateResults(int i_IndexOfQuestion, bool i_IsCorrectAnswer)
        {
            r_TriviaManager.updateResults(i_IndexOfQuestion, i_IsCorrectAnswer);
        }

        public int GetCorrectResults()
        {
            return r_TriviaManager.getCorrectResults();
        }

        public int GetWrongResults()
        {
            return r_TriviaManager.getWrongResults();
        }

        public void InitializeChosenFriend(FictionUsers i_ChosenFriend)
        {
            r_TriviaManager.InitializeChosenFriend(i_ChosenFriend);
        }

        public List<FictionUsers> GetListOfFictionUsersToTriviaForm()
        {
            return r_TriviaManager.GetListOfFictionUsers();
        }

        public void InitializeDictionaryOfQuestionsAndAnswers()
        {
            r_TriviaManager.initializeDictionaryOfQuestionsAndAnswers();
        }

        public bool CheckIfThereIsMatch(string i_Gender, string i_Age, string i_City)
        {
            return r_FindYourMatchManager.checkIfThereIsMatch(i_Gender, i_Age, i_City);
        }

        public FictionUsers GetPotentionalMatch()
        {
            return r_FindYourMatchManager.GetPotentionalMatch();
        }

        public List<FictionUsers> GetListOfFictionUsersToMainForm()
        {
            return r_MainFormManager.GetListOfFictionUsersToMainForm();
        }

        /**
         * In case we can access the user's friends via facebook
         */
        ////public User GetPotentionalMatchUser()
        ////{
        ////return r_FindYourMatchManager.GetPotentionalMatchUser();
        ////}

        ////public int getUserAge()
        ////{
        ////    return r_FindYourMatchManager.calculateTheAgeOfTheUser();
        ////}
    }
}
