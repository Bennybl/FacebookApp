using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }
        User m_LoggedInUser;
        LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns20aa"); /// the current password for Desig Patter

            m_LoginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own) - Replaced
                    "169144092019421", 
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
                    /// add any relevant permissions
                    );

            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;

                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
		}

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                textBoxPostStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }
        private void buttonEvents_LinkClicked(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxFetchEvents.Items.Clear();
            listBoxFetchEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxFetchEvents.Items.Add(fbEvent);
            }

            if (listBoxFetchEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void listBoxFetchEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFetchEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxFetchEvents.SelectedItem as Event;
                pictureBoxEvents.LoadAsync(selectedEvent.Cover.SourceURL);
            }
        }

        private void linkFriends_LinkClicked(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxFetchFriends.Items.Add(friend.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void listBoxFetchFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFetchFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFetchFriends.SelectedItem as User;
                pictureBoxFriendsProfile.LoadAsync(selectedFriend.PictureNormalURL);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        ///FormAppSettings m_FormAppSettings = null;

        public static class AppSettings
        {
            public static string s_AppID = "1450160541956417"; /// (desig patter's "Design Patterns Course App 2.4" app)
            public static string[] s_Permissions = new string[] {
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
            "user_videos"};
        }

        private void pictureBoxEvents_Click(object sender, EventArgs e)
        {

        }
    }
}
