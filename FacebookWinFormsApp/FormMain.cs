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
                //buttonLogin.Text = "Logged in";
                //m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                //LoggedInUser = m_LoginResult.LoggedInUser;
                //fetchUserInfo();
                //defineCheckBoxAsVisible();
            }
        }

        private void autoLogin()
        {
            //buttonLogin.Text = "Logged in";
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
           // listBoxAlbums.Items.Clear();
            if (checkBoxAlbums.Checked)
            {
                new Thread(showAlbums).Start();
            }
            else
            {
               // pictureBoxAlbum.Image = null;
            }
        }

        private void showAlbums()
        {
            //listBoxAlbums.Invoke(new Action(() => listBoxAlbums.DisplayMember = "Name"));
            listBoxAlbums.Invoke(new Action(() =>
            {

                //FacebookObjectCollection<Album> userAlbums = LoggedInUser.Albums;
                //foreach (Album album in userAlbums)
                //{
                //    listBoxAlbums.Items.Add(album);
                //}

                albumBindingSource.DataSource = LoggedInUser.Albums;

                if (listBoxAlbums.Items.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }));
        }

        //private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    new Thread(displaySelectedAlbum).Start();
        //}

        //private void displaySelectedAlbum()
        //{
        //    Invoke(new Action(() =>
        //    {
        //        if (listBoxAlbums.SelectedItems.Count == 1)
        //        {
        //            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
        //            if (selectedAlbum.PictureAlbumURL != null)
        //            {
        //                pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
        //            }
        //            else
        //            {
        //                pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
        //            }
        //        }
        //    }));
        //}

        private void checkBoxShowPosts_CheckedChanged(object sender, EventArgs e)
        {
            //listBoxPosts.Items.Clear();
            if (checkBoxPosts.Checked)
            {
                new Thread(fetchPosts).Start();
            }
            else 
            {
                //listBoxComments.DataSource = null;
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() =>
            {
                //foreach (Post post in LoggedInUser.Posts)
                //{
                //    if (post.Message != null)
                //    {
                //        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                //    }
                //}


                postBindingSource.DataSource = LoggedInUser.Posts.Where(post=>post.Message != null);


                if (listBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }));
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

        //private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Invoke(new Action(() =>
        //    {
        //        Post selected = LoggedInUser.Posts[listBoxPosts.SelectedIndex];
        //        listBoxComments.DisplayMember = "Message";
        //        listBoxComments.DataSource = selected.Comments;
        //    }));
        //}

        private void checkBoxLikedPages_CheckedChanged(object sender, EventArgs e)
        {
            //listBoxLikedPages.Items.Clear();
            if (checkBoxLikedPages.Checked)
            {
                new Thread(fetchLikedPages).Start();
           }
            else
            {
               // pictureBoxLikedPages.Image = null;
            }
        }

        private void fetchLikedPages()
        {
           listBoxLikedPages.Invoke(new Action(() =>
            {
                //listBoxLikedPages.Items.Clear();
                //listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.DisplayMember = "Name"));
                //try
                //{
                    //foreach (Page page in LoggedInUser.LikedPages)
                    //{
                        //listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
                        pageBindingSource.DataSource = LoggedInUser.LikedPages;
                    //}
                //}
                //catch (Exception ex)
                //{
                  //  MessageBox.Show(ex.Message);
                //}

                if (listBoxLikedPages.Items.Count == 0)
                {
                    MessageBox.Show("No liked pages to retrieve :(");
                }
            }));
        }

        private void likedByBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //private void listBoxLikedPages_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    Invoke(new Action(() =>
        //    {
        //        if (listBoxLikedPages.SelectedItems.Count == 1)
        //        {
        //            Page selectedPage = listBoxLikedPages.SelectedItem as Page;
        //            pictureBoxLikedPages.LoadAsync(selectedPage.PictureNormalURL);
        //        }
        //    }));
        //}

        //private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Invoke(new Action(() =>
        //    {
        //        if (listBoxLikedPages.SelectedItems.Count == 1)
        //        {
        //            Page selectedPage = listBoxLikedPages.SelectedItem as Page;
        //            pictureBoxLikedPages.LoadAsync(selectedPage.PictureNormalURL);
        //        }
        //    }));
        //}

        //private void likesCountLabel_Click(object sender, EventArgs e)
        //{

        //}

        //private void countryLabel_Click(object sender, EventArgs e)
        //{

        //}
    }
}