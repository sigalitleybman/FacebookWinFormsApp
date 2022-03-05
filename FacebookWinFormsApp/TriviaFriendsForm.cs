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
            InitializeListBoxOfFriends();
            
            //m_TriviaQuestions = new List<string>();
            //InitializeListOfQuestions();
        }
       
        private void InitializeListBoxOfFriends()
        {
            //listBoxFriend.Items.Clear();

            listBoxFriend.DisplayMember = "Name";
            FacebookObjectCollection<User> userFriends = r_LoggedInUser.Friends;
            foreach (User friend in userFriends)
            {
                listBoxFriend.Items.Add(friend);
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriendImageAndQuestions(sender);
        }

        private void displaySelectedFriendImageAndQuestions(object i_Sender)
        {
            displayImageOfFriend();
            displayQuestionsAndAnswers();
            //displayQuestions();
            //initTriviaQuestions(i_Sender as User);
        }

        //private void initTriviaQuestions(User i_ChosenFriend)
        //{
        //    Dictionary<string, string> questionAndAnswers = ApplicationManager.InitTrivia(i_ChosenFriend);
        //    startTriviaGame();
        //}

        private void displayImageOfFriend()
        {
            if (listBoxFriend.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriend.SelectedItem as User;
                if (selectedFriend.PictureLargeURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureLargeURL);
                }
                else
                {
                    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                }
            }
        }

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

            radioButtonFirstAnswer.Text = answersToSpecificQuestion[0];
            radioButtonSecondAnswer.Text = answersToSpecificQuestion[1];
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

            updateResults(isCorrectAnswer);
            pictureBoxNextQuestion.Enabled = true;
            checkIfItsTheLastQuestion(currentQuestion);
        }

        private void updateResults(bool i_IsCorrectAnswer)
        {
            ApplicationManager.updateResults(i_IsCorrectAnswer);
        }

        private void checkIfItsTheLastQuestion(eKeyQuestions i_CurrentQuestion)
        {
            if ((int) i_CurrentQuestion == 2)
            {
                labelFeedback.Text =
                    $"You succeeded in {ApplicationManager.GetCorrectResults()} questions" +
                    $" and failed in {ApplicationManager.GetWrongResults()} questions";
            }
        }
    }
}
