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
        private readonly List<string> r_TriviaQuestions;
        private int m_IndexOfQuestions = 0;
        private readonly List<FictionUsers> r_ListOfFictionUsers;
        private FictionUsers m_ChosenFriend;
        internal ApplicationManager ApplicationManager { get; set; }

        /**
         * In the case we can access the login user's chosen friend via facebook
         * // private User m_ChosenFriend;
         */

        public TriviaFriendsForm(FormMain i_FormMain)
        {
            InitializeComponent();
            r_LoggedInUser = i_FormMain.LoggedInUser;
            ApplicationManager = i_FormMain.ApplicationManager;
            r_TriviaQuestions = ApplicationManager.GetListOfQuestions();
            r_ListOfFictionUsers = ApplicationManager.GetListOfFictionUsersToTriviaForm();
            InitializeListBoxOfFriends();
        }
       
        private void InitializeListBoxOfFriends()
        {
            /**
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
            /**
             * In case we can access the user's friend via facebook
             */
            //ApplicationManager.initializeChosenFriend(sender as User);          
            
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
           
            listBoxFriend.Enabled = false;
            ApplicationManager.initializeChosenFriend(m_ChosenFriend);
            ApplicationManager.resetWrongAndCorrectAnswers();
            displaySelectedFriendQuestions();
            checkBoxChangeFriend.Enabled = true;
            buttonSubmit.Enabled = true;
        }

        private void displaySelectedFriendQuestions()
        {
            ApplicationManager.initializeQuestions(m_ChosenFriend);
            ApplicationManager.initializeDictionaryOfQuestionsAndAnswers();
            displayQuestionsAndAnswers();
        }

        private void displayQuestionsAndAnswers()
        {
            displayQuestions();
        }

        private void displayQuestions()
        {
            ApplicationManager.GetListOfQuestions();
            pictureBoxNextQuestion.Enabled = false;
            labelDescriptionQuestion.Text = r_TriviaQuestions[m_IndexOfQuestions];
            labelDescriptionQuestion.Show();
            displayAnswers(m_IndexOfQuestions);
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
     
        private void displayAnswers(int i_IndexOfCurrentQuestion)
        {
            List<string> answersToSpecificQuestion = ApplicationManager.GetListOfAnswers(i_IndexOfCurrentQuestion);

            radioButtonFirstAnswer.Text = answersToSpecificQuestion[0];
            radioButtonSecondAnswer.Text = answersToSpecificQuestion[1];
            radioButtonThirdAnswer.Text = answersToSpecificQuestion[2];
        }

        private void CheckIfTheAnswerIsCorrect(object sender, EventArgs e) 
        {
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
                buttonSubmit.Enabled = false;
                labelFeedback.Visible = true;
                labelFeedback.Text =
                    $"You succeeded in {ApplicationManager.GetCorrectResults()} questions " +
                    Environment.NewLine +
                    $"and failed in {ApplicationManager.GetWrongResults()} questions";
            }
        }

        private void checkBoxChangeFriend_CheckedChanged(object sender, EventArgs e)
        {
            labelFeedback.Text = "";
            if (checkBoxChangeFriend.Checked)
            {
                listBoxFriend.Enabled = true;
            }
            else
            {
                listBoxFriend.Enabled = false;
            }

            m_IndexOfQuestions = 0;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            BackToMainForm();
        }

        private void BackToMainForm()
        {
            this.Close();
        }
    }
}
