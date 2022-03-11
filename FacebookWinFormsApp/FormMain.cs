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

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly AppSettings r_AppSettings;
        private FacebookWrapper.LoginResult m_LoginResult;
        private readonly List<FictionUsers> r_ListOfFictionUsers;
        internal User LoggedInUser { get; set; }
       internal ApplicationManager ApplicationManager { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.LoadFromFile();
            fetchFormSettings();
            ApplicationManager = new ApplicationManager() { LoggedInUser = LoggedInUser };
            r_ListOfFictionUsers = ApplicationManager.GetListOfFictionUsersToMainForm();
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
                    /// requested permissions:
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
                    "user_videos"
            );           
            LoggedInUser = m_LoginResult.LoggedInUser;
            fetchUserInfo();
            defineCheckBoxAsVisible();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                buttonLogin.Text = "Logged in";
                m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                defineCheckBoxAsVisible();
            }
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
            checkBoxAlbums.Visible = true;
            checkBoxFriends.Visible = true;
            checkBoxPosts.Visible = true;
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
        }

        private void checkBoxFriends_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFriends.Checked)
            {
                showFriends();
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
                listBoxFriends.Items.Add(fictionUser.Name);
            }

            /**
             * In case we can access user's friend via fecebook
             */
            //listBoxFriends.Items.Clear();
            //listBoxFriends.DisplayMember = "Name";
            //FacebookObjectCollection<User> userFriends = LoggedInUser.Friends;
            //foreach (User friend in userFriends)
            //{
            //    listBoxFriends.Items.Add(friend);
            //    //friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            //}
            //if (listBoxFriends.Items.Count == 0)
            //{
            //    MessageBox.Show("No Friends to retrieve :(");
            //}
        }

        /**
        * In case we can access user's friend via fecebook
        */
        /*private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }*/

        /*private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend.PictureLargeURL != null)
                {
                    pictureBoxFriends.LoadAsync(selectedFriend.PictureLargeURL);
                }
                else
                {
                    pictureBoxFriends.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }*/

        private void checkBoxAlbums_CheckedChanged(object sender, EventArgs e)
        {
            listBoxAlbums.Items.Clear();
            if (checkBoxAlbums.Checked)
            {
                showAlbums();
            }
            else
            {
                pictureBoxAlbum.Image = null;
            }
        }

        private void showAlbums()
        {
            listBoxAlbums.DisplayMember = "Name";
            FacebookObjectCollection<Album> userAlbums = LoggedInUser.Albums;
            foreach (Album album in userAlbums)
            {
                listBoxAlbums.Items.Add(album);
            }

            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }

        private void checkBoxShowPosts_CheckedChanged(object sender, EventArgs e)
        {
            listBoxPosts.Items.Clear();
            if (checkBoxPosts.Checked)
            {
                fetchPosts();
            }
            else 
            {
                    listBoxComments.DataSource = null;
            }
        }

        private void fetchPosts()
        {
            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonTrivia_Click(object sender, EventArgs e)
        {
            this.Hide();
            TriviaFriendsForm triviaFriendsForm = new TriviaFriendsForm(this);
            triviaFriendsForm.ShowDialog();
            this.Show();
        }

        private void buttonFindYourMatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            FindYourMatchForm findYourMatchForm = new FindYourMatchForm(this);
            findYourMatchForm.ShowDialog();
            this.Show();
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected = LoggedInUser.Posts[listBoxPosts.SelectedIndex];
            listBoxComments.DisplayMember = "Message";
            listBoxComments.DataSource = selected.Comments;
        }

        private void checkBoxLikedPages_CheckedChanged(object sender, EventArgs e)
        {
            listBoxLikedPages.Items.Clear();
            if(checkBoxLikedPages.Checked)
            {
                fetchLikedPages();
            }
            else
            {
                pictureBoxLikedPages.Image = null;
            }
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";
            try
            {
                foreach (Page page in LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                pictureBoxLikedPages.LoadAsync(selectedPage.PictureNormalURL);
            }
        }
    }
}

