//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;
//using FacebookWrapper.ObjectModel;
//using FacebookWrapper;

//namespace BasicFacebookFeatures
//{
//    public partial class FormMain : Form
//    {
//        public FormMain()
//        {
//            InitializeComponent();
//            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
//        }

//        private void buttonLogin_Click(object sender, EventArgs e)
//        {
//            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

//            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
//                    /// (This is Desig Patter's App ID. replace it with your own)
//                    "1450160541956417", 
//                    /// requested permissions:
//					"email",
//                    "public_profile"
//                    /// add any relevant permissions
//                    );

//            buttonLogin.Text = $"Logged in as {loginResult.LoggedInUser.Name}";
//        }

//        private void buttonLogout_Click(object sender, EventArgs e)
//        {
//			FacebookService.LogoutWithUI();
//			buttonLogin.Text = "Login";
//		}
//	}
//}

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
        internal User LoggedInUser { get; set; }
        //private static ApplicationManager m_ApplicationManager;
       // private LoginResult m_LoginResult;
       internal ApplicationManager ApplicationManager { get; set; }

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            r_AppSettings = AppSettings.LoadFromFile();
            //r_AppSettings = new AppSettings();
            fetchFormSettings();
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
            

            ////buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            //buttonLogin.Text = "Logged in";
            //if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            //{
                LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
            //    fetchUserInfo();
            //}
            //else
            //{
            //    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            //}

            defineCheckBoxAsVisible();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (r_AppSettings.RememberUser && !string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
            {
                //m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                //fetchLoggedInUser();
                //buttonLogin.Text = "Logged In";



                //buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.Text = "Logged in";
               // if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                //{
                   
                  m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                  LoggedInUser = m_LoginResult.LoggedInUser;
                fetchUserInfo();
                //}
                //else
                //{
                  //  MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
                //}

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
                //new Thread(showFriends).Start();
            }
            else
            {
                listBoxFriends.Items.Clear();
            }
        }
        //private void checkBoxShowFriends_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (checkBoxFriends.Checked)
        //    {
        //        showFriends();
        //        //new Thread(showFriends).Start();
        //    }
        //    else
        //    {
        //        listBoxFriends.Items.Clear();
        //    }
        //}


        private void showFriends()
        {

            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            FacebookObjectCollection<User> userFriends = LoggedInUser.Friends;
            foreach (User friend in userFriends)
            {
                listBoxFriends.Items.Add(friend);
                //friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (listBoxFriends.Items.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }
        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
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
        }

        //private void checkBoxAlbums_CheckedChanged_1(object sender, EventArgs e)
        //{

        //}
        //private void checkBoxAlbums_CheckedChanged(object sender, EventArgs e)
        //{

        //}
        private void checkBoxAlbums_CheckedChanged(object sender, EventArgs e)
        {
            listBoxAlbums.Items.Clear();
            if (checkBoxAlbums.Checked)
            {
                showAlbums();
                //new Thread(showAlbums).Start();
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
                //friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
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
        //private void checkBoxPosts_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        private void checkBoxShowPosts_CheckedChanged(object sender, EventArgs e)
        {
            listBoxPosts.Items.Clear();
            if (checkBoxPosts.Checked)
            {
                fetchPosts();
                //new Thread(fetchPosts).Start();

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
                /*else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }*/
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonTrivia_Click(object sender, EventArgs e)
        {
            ApplicationManager = new ApplicationManager(){LoggedInUser = LoggedInUser};
            this.Hide();
            TriviaFriendsForm triviaFriendsForm = new TriviaFriendsForm(this);
            triviaFriendsForm.ShowDialog();
        }
    }
}

