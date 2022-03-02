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

namespace BasicFacebookFeatures
{
    public partial class TriviaFriendsForm : Form
    {
        private readonly User r_LoggedInUser;
        private List<string> m_TriviaQuestions;
        private ApplicationManager m_ApplicationManager;
        private int m_IndexOfQuestions = 0;
        private const int k_NumOfQuestions = 3;

        public TriviaFriendsForm()
        {
            InitializeComponent();
        }

        public TriviaFriendsForm(User iLoggedInUser)
        {
            InitializeComponent();
            r_LoggedInUser = iLoggedInUser;
            //m_TriviaQuestions = new List<string>();
            InitializeListBoxOfFriends();
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
            displaySelectedFriendImageAndQuestions();
        }

        private void displaySelectedFriendImageAndQuestions()
        {
            displayImageOfFriend();
            displayQuestions();
        }

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

        private void displayQuestions()
        {
            if (m_TriviaQuestions == null)
            {
                m_TriviaQuestions = m_ApplicationManager.GetListOfQuestions();
            }

            
            // TODO: add randomalic questions to the listboxfriend
          
            labelDescriptionQuestion.Text = m_TriviaQuestions[m_IndexOfQuestions];
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
    }
}
