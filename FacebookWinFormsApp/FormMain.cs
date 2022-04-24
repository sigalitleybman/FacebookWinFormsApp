using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using ApplicationLogic;
using Message = FacebookWrapper.ObjectModel.Message;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly List<FictionUsers> r_ListOfFictionUsers;
        private readonly AppSettings r_AppSettings;
        private FacebookWrapper.LoginResult m_LoginResult;
        internal User LoggedInUser { get; set; }
        internal ApplicationManagerFacade ApplicationManagerFacade;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.LoadFromFile();
            fetchFormSettings();
            ApplicationManagerFacade = ApplicationManagerFacade.Instance;
            ApplicationManagerFacade.LoggedInUser = LoggedInUser;
            ApplicationManagerFacade.createFeatures();
            r_ListOfFictionUsers = ApplicationManagerFacade.GetListOfFictionUsersToMainForm();
        }

        private void fetchFormSettings()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = r_AppSettings.LastWindowLocation;
            this.Size = r_AppSettings.LastWindowSize;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20cc");
            m_LoginResult = FacebookService.Login(
                "1303346456815400",
                    //// requested permissions:
                    "email",
                    "public_profile",
                    "user_age_range",   
                    "user_birthday",
                    "user_events",
                    "user_friends",
                    "user_gender",
                    "user_hometown",
                    "user_likes",
                    "user_link",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_videos");           
            LoggedInUser = m_LoginResult.LoggedInUser;
            new Thread(fetchUserInfo).Start();
            defineCheckBoxAsVisible();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            { 
                new Thread(autoLogin).Start();
            }
        }

        private void autoLogin()
        {
            m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            LoggedInUser = m_LoginResult.LoggedInUser;
            fetchUserInfo();
            defineCheckBoxAsVisible();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_AppSettings.LastWindowSize = this.Size;
            r_AppSettings.LastWindowLocation = this.Location;
            r_AppSettings.RememberUser = this.checkBoxRememberMe.Checked;
            if (r_AppSettings.RememberUser)
            {
                r_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
            }

            r_AppSettings.SaveToFile();
        }

        private void defineCheckBoxAsVisible()
        {
            Invoke(new Action(() =>
            {
                checkBoxAlbums.Visible = true;
                checkBoxFriends.Visible = true;
                checkBoxPosts.Visible = true;
            }));
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.Enabled = true;
            pictureBoxProfile.Image = null;
        }

        private void fetchUserInfo()
        {
            Invoke(new Action(() =>
            {
                buttonLogin.Text = "Logged in";
                pictureBoxProfile.LoadAsync(LoggedInUser.PictureNormalURL);
                labelProfileName.Visible = true;
                labelProfileName.Text = LoggedInUser.Name;
                if (r_AppSettings.RememberUser)
                {
                    checkBoxRememberMe.Checked = true;
                }
                else
                {
                    checkBoxRememberMe.Checked = false;
                }
            }));
        }

        private void checkBoxFriends_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFriends.Checked)
            {
                new Thread(showFriends).Start();
            }
            else
            {
                listBoxFriends.Items.Clear();
            }
        }
        
        private void showFriends()
        {
            foreach (FictionUsers fictionUser in r_ListOfFictionUsers)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(fictionUser.Name)));
            }

            /**
             * In case we can access user's friend via fecebook
             */
            //  listBoxFriends.Invoke(new Action(() =>
            //{
                  //friendBindingSource.DataSource = LoggedInUser.Albums;
                ////if (listBoxFriends.Items.Count == 0)
                ////{
                ////    MessageBox.Show("No Friends to retrieve :(");
                ////}
           // }));
            }

        /**
        * In case we can access user's friend via fecebook
        */
        /*private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            new Thread(displaySelectedFriend).Start();
        }*/

        private void checkBoxAlbums_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlbums.Checked)
            {
                new Thread(showAlbums).Start();
            }
        }

        private void showAlbums()
        {
            listBoxAlbums.Invoke(new Action(() =>
            {
                albumBindingSource.DataSource = LoggedInUser.Albums;
                if (listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }));
        }

        private void checkBoxShowPosts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPosts.Checked)
            {
                new Thread(fetchPosts).Start();
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() =>
            {
                if(LoggedInUser.Posts.Count != 0)
                {
                    postBindingSource.DataSource = LoggedInUser.Posts.Where(post => post.Message != null);
                }
                else
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }));
        }

        private void buttonTrivia_Click(object sender, EventArgs e)
        {
            this.Hide();
            TriviaFriendsForm triviaFriendsForm = FactoryForm.CreateSpecificForm("TriviaFriendsForm") as TriviaFriendsForm;
            triviaFriendsForm.ShowDialog();
            this.Show();
        }

        private void buttonFindYourMatch_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            FindYourMatchForm findYourMatchForm = FactoryForm.CreateSpecificForm("FindYourMatchForm") as FindYourMatchForm;
            findYourMatchForm.ShowDialog();
            this.Show();
        }

        private void checkBoxLikedPages_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLikedPages.Checked)
            {
                new Thread(fetchLikedPages).Start();
            }
        }

        private void fetchLikedPages()
        {
           listBoxLikedPages.Invoke(new Action(() =>
            {
                pageBindingSource.DataSource = LoggedInUser.LikedPages;
                if (listBoxLikedPages.Items.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                }
            }));
        }

        //private void likedByBindingSource_CurrentChanged(object sender, EventArgs e)
        //{

        //}
    }
}