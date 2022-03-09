// check git$$$$$$$
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using ApplicationLogic;
using eKeyQuestions = ApplicationLogic.eKeyQuestions;
using FictionUsers = ApplicationLogic.FictionUsers;

namespace BasicFacebookFeatures
{
    public partial class TriviaFriendsForm : Form
    {
        private readonly User r_LoggedInUser;
        private readonly List<string> m_TriviaQuestions;
        //private readonly List<string> m_TriviaAnswersToSpecificQuestion;
        private int m_IndexOfQuestions = 0;
        private const int k_NumOfQuestions = 3;
        private string m_currentQuestion;
        private readonly List<FictionUsers> r_ListOfFictionUsers;
        private FictionUsers m_ChosenFriend;

       // private User m_ChosenFriend;
        //private ApplicationManager m_ApplicationManager;

        internal ApplicationManager ApplicationManager { get; set; }

        //public TriviaFriendsForm()
        //{
        //    InitializeComponent();
        //}

        public TriviaFriendsForm(FormMain i_FormMain)
        {
            InitializeComponent();
            r_LoggedInUser = i_FormMain.LoggedInUser;
            ApplicationManager = i_FormMain.ApplicationManager;
            m_TriviaQuestions = ApplicationManager.GetListOfQuestions();
            r_ListOfFictionUsers = ApplicationManager.GetListOfFictionUsers();
            InitializeListBoxOfFriends();
            
            //m_TriviaQuestions = new List<string>();
            //InitializeListOfQuestions();
        }
       
        private void InitializeListBoxOfFriends()
        {
            /*
             * This section is in comment because we cant get user's friends via facebook
             */
            //listBoxFriend.Items.Clear();
            //listBoxFriend.DisplayMember = "Name";
            //FacebookObjectCollection<User> userFriends = r_LoggedInUser.Friends;
            //foreach (User friend in userFriends)
            //{
            //    listBoxFriend.Items.Add(friend);
            //}

            
            foreach (var user in r_ListOfFictionUsers)
            {
                listBoxFriend.Items.Add(user.Name);
            }

        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ApplicationManager.initializeChosenFriend(sender as User);
            //m_ChosenFriend = r_ListOfFictionUsers.Where(Name == listBoxFriend.SelectedItem) ;
            //m_ChosenFriend = listBoxFriend.SelectedItem as FictionUsers;
            for (int i = 0; i < r_ListOfFictionUsers.Count; i++)
            {
                if (listBoxFriend.SelectedItem == "Haim Levi")
                {
                    m_ChosenFriend = r_ListOfFictionUsers[0];
                }
                if (listBoxFriend.SelectedItem == "Dor Cohen")
                {
                    m_ChosenFriend = r_ListOfFictionUsers[1];
                }
                if (listBoxFriend.SelectedItem == "Dana Ron")
                {
                    m_ChosenFriend = r_ListOfFictionUsers[2];
                }
            }

            listBoxFriend.Enabled = false;
            ApplicationManager.initializeChosenFriend(m_ChosenFriend);
            displaySelectedFriendQuestions();
            checkBoxChangeFriend.Enabled = true;
            buttonSubmit.Enabled = true;
        }

        private void displaySelectedFriendQuestions()
        {
            //displayImageOfFriend();
            ApplicationManager.initializeQuestions(m_ChosenFriend);
            ApplicationManager.initializeDictionaryOfQuestionsAndAnswers();
            displayQuestionsAndAnswers();
            
        }

        //private void initTriviaQuestions(User i_ChosenFriend)
        //{
        //    Dictionary<string, string> questionAndAnswers = ApplicationManager.InitTrivia(i_ChosenFriend);
        //    startTriviaGame();
        //}

        //private void displayImageOfFriend()
        //{
        //    if (listBoxFriend.SelectedItems.Count == 1)
        //    {
        //        User selectedFriend = listBoxFriend.SelectedItem as User;
        //        if (selectedFriend.PictureLargeURL != null)
        //        {
        //            pictureBoxFriend.LoadAsync(selectedFriend.PictureLargeURL);
        //        }
        //        else
        //        {
        //            pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
        //        }
        //    }
        //}

        private void displayQuestionsAndAnswers()
        {
            displayQuestions();
            //displayAnswers();
        }
        private void displayQuestions()
        {
            //if (m_TriviaQuestions == null)
            //{
            //    m_TriviaQuestions = ApplicationManager.GetListOfQuestions();
            //}
            pictureBoxNextQuestion.Enabled = false;
            
            // TODO: add randomalic questions to the listboxfriend
          
            labelDescriptionQuestion.Text = m_TriviaQuestions[m_IndexOfQuestions];
            labelDescriptionQuestion.Show();
            displayAnswers(m_IndexOfQuestions);
            m_currentQuestion = Enum.GetName(typeof(eKeyQuestions), m_IndexOfQuestions);

            if (m_IndexOfQuestions < 3)
            {
                m_IndexOfQuestions++;
            }

            if (m_IndexOfQuestions == 3)
            {
                pictureBoxNextQuestion.Enabled = false;
            }


        }

        private void pictureBoxNextQuestion_Click(object sender, EventArgs e)
        {
            displayQuestions();
        }

        //this method should recieve the current question
        private void displayAnswers(int i_IndexOfCurrentQuestion)
        {
            List<string> answersToSpecificQuestion = ApplicationManager.GetListOfAnswers(i_IndexOfCurrentQuestion);

            radioButtonFirstAnswer.Text = answersToSpecificQuestion[0].ToString();
            radioButtonSecondAnswer.Text = answersToSpecificQuestion[1].ToString();
            radioButtonThirdAnswer.Text = answersToSpecificQuestion[2];
        }

        private void CheckIfTheAnswerIsCorrect(object sender, EventArgs e) 
        {
            //TODO: check how convert the string(Age) to his name type in enum
            //eKeyQuestions currentQuestion =  Enum.Parse(eKeyQuestions, m_currentQuestion);
            eKeyQuestions currentQuestion = (eKeyQuestions)(m_IndexOfQuestions - 1);
            string chosenAnswer = null;
            bool isCorrectAnswer;

            if (radioButtonFirstAnswer.Checked)
            {
                chosenAnswer = radioButtonFirstAnswer.Text;
            }
            else if (radioButtonSecondAnswer.Checked)
            {
                chosenAnswer = radioButtonSecondAnswer.Text;
            }
            else if(radioButtonThirdAnswer.Checked)
            {
                chosenAnswer = radioButtonThirdAnswer.Text;
            }

            isCorrectAnswer = ApplicationManager.CheckIfAnswerIsCorrect(currentQuestion, chosenAnswer);

            updateResults((int)currentQuestion, isCorrectAnswer);
            pictureBoxNextQuestion.Visible = true;
            pictureBoxNextQuestion.Enabled = true;
            checkIfItsTheLastQuestion(currentQuestion);
        }

        private void updateResults(int i_IndexOfQuestion, bool i_IsCorrectAnswer)
        {
            ApplicationManager.updateResults(i_IndexOfQuestion, i_IsCorrectAnswer);
        }

        private void checkIfItsTheLastQuestion(eKeyQuestions i_CurrentQuestion)
        {
            if ((int) i_CurrentQuestion == 2)
            {
                pictureBoxNextQuestion.Enabled = false;
                labelFeedback.Visible = true;
                labelFeedback.Text =
                    $"You succeeded in {ApplicationManager.GetCorrectResults()} questions " +
                    Environment.NewLine +
                    $"and failed in {ApplicationManager.GetWrongResults()} questions";
            }
        }

        private void checkBoxChangeFriend_CheckedChanged(object sender, EventArgs e)
        {
            listBoxFriend.Enabled = true;
            m_IndexOfQuestions = 0;
        }
    }
}
