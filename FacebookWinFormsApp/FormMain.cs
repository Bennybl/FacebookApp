using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using TestBed;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        User m_LoggedInUser;
        LoginResult m_LoginResult;
        Dictionary<String, List<Event>> m_citiesAndEvents = new Dictionary<string, List<Event>>();
        Dictionary<String, string[]> m_comboBoxFacebookObjectsOptional = new Dictionary<string, string[]>();


        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
            m_comboBoxFacebookObjectsOptional.Add("Pages", new string[] { "Most liked Pages", "Oldest Page" });
            m_comboBoxFacebookObjectsOptional.Add("Friends", new string[] { "Friends with post mutual Friends", "Friends with most Friends" });
            m_comboBoxFacebookObjectsOptional.Add("Groups", new string[] { "Groups with most members", "Groups with most friends" });
        }
        

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
                changeButtonsStatus();
                fetchCitiesAndEvents();
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
            pictureBoxProfile.Image = null;
            changeButtonsStatus();
            clearBoxes();
		}

        private void clearBoxes()
        {
            listBoxEvents.Items.Clear();
            listBoxAlbums.Items.Clear();
            listBoxGroups.Items.Clear();
            listBoxFriends.Items.Clear();
            listBoxPages.Items.Clear();
            listBoxNewsFeed.Items.Clear();
            listBoxPosts.Items.Clear();
        }

        private void fetchCitiesAndEvents()
        {
            foreach(Event selectedEvent in m_LoggedInUser.Events)
            {
                addEvent(selectedEvent);
            }
            if(m_LoggedInUser.Friends != null)
            {
                foreach(User friend in m_LoggedInUser.Friends)
                {
                    foreach(Event selectedEvent in friend.Events)
                    {
                        addEvent(selectedEvent);
                    }
                }
            }
            foreach(String cityName in m_citiesAndEvents.Keys)
            {
                listBoxCities.Items.Add(cityName);
            }
        }

        private void addEvent(Event i_selectedEvent)
        {
            String city = i_selectedEvent.Place.Location.City;
            if(!m_citiesAndEvents.ContainsKey(city))
            {
                m_citiesAndEvents.Add(city, new List<Event>());
            }
            m_citiesAndEvents[city].Add(i_selectedEvent);
        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxCities.SelectedItems.Count == 1)
            {
                listBoxEventsByCity.Items.Clear();
                String city = listBoxCities.SelectedItem.ToString();
                foreach(Event selectedEvent in m_citiesAndEvents[city])
                {
                    listBoxEventsByCity.Items.Add(selectedEvent);
                }
            }

        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                //textBoxPostStatus.Text = m_LoggedInUser.Posts[0].Message;
            }
        }

        private void changeButtonsStatus()
        {
            buttonFetchEvents.Enabled = !buttonFetchEvents.Enabled;
            buttonFetchFriends.Enabled = !buttonFetchFriends.Enabled;
            buttonFetchPages.Enabled = !buttonFetchPages.Enabled;
            buttonFetchGroups.Enabled = !buttonFetchGroups.Enabled;
            buttonFetchPosts.Enabled = !buttonFetchPosts.Enabled;
            buttonPostStatus.Enabled = !buttonPostStatus.Enabled;
            buttonRefresh.Enabled = !buttonRefresh.Enabled;
            buttonFetchAlbums.Enabled = !buttonFetchAlbums.Enabled;
            buttonAboutMe.Enabled = !buttonAboutMe.Enabled;
        }

        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEvents.LoadAsync(selectedEvent.Cover.SourceURL);
            }

        }

        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";

            try
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend.Name);
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

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                pictureBoxFriends.LoadAsync(selectedFriend.PictureSmallURL);
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxPostStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach(Post post in m_LoggedInUser.Posts)
            {
                if(post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if(post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }


            if(listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            fetchPages();
        }

        private void fetchPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = "Name";

            try
            {
                foreach(Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxPages.Items.Add(page);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(listBoxPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void pictureBoxProfile_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            fetchGroups();
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            try
            {
                foreach(Group group in m_LoggedInUser.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshNewsFeed();
        }

        private void refreshNewsFeed()
        {
            int counter = 0;
            listBoxNewsFeed.Items.Clear();
            foreach(Post post in m_LoggedInUser.NewsFeed)
            {
                listBoxNewsFeed.Items.Add(post);
                counter++;
                if(counter == 200)
                {
                    break;
                }
            }

            if(listBoxNewsFeed.Text.Equals("Load"))
            {
                listBoxNewsFeed.Text = "Refresh";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFetchAlbums_Click(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";
            foreach(Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
                //album.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if(listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxPages.SelectedItem as Page;
                pictureBoxPages.LoadAsync(selectedPage.PictureSmallURL);
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroups.LoadAsync(selectedGroup.PictureSmallURL);
                
            }
        }


        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if(listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if(selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbums.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxProfile.Image = pictureBoxProfile.ErrorImage;
                }
            }
        }

        FormAboutMe m_FormAboutMe = null;
        private void buttonAboutMe_Click(object sender, EventArgs e)
        {
            if (m_FormAboutMe == null)
            {
                m_FormAboutMe = new FormAboutMe(m_LoggedInUser);
            }
            m_FormAboutMe.ShowDialog();
        }

        FormAppSettings m_FormAppSettings = null;
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if(m_FormAppSettings == null)
            {
                m_FormAppSettings = new FormAppSettings();
            }
            m_FormAppSettings.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tabFeature2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEventDetails_Click(object sender, EventArgs e)
        {
            if(listBoxEventsByCity.Items.Count == 1)
            {
                FormEvent formEvent = new FormEvent(listBoxEventsByCity.SelectedItem as Event);
                formEvent.ShowDialog();
            }
        }

        private void comboBoxFacebookObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxFacebookObjects.SelectedItem.ToString();

            comboBoxFacebookObjectsOptions.Items.Clear();
            
            comboBoxFacebookObjectsOptions.Items.AddRange(m_comboBoxFacebookObjectsOptional[selectedItem]);
        }

        private void comboBoxFacebookObjectsOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxFacebookObjectsOptions.SelectedItem)
            {
                case "Most liked Pages":
                    listBoxFacebookItems.Items.Clear();
             
                    List<Page> sortedPagesByLikes = m_LoggedInUser.LikedPages.OrderBy(o => o.LikesCount).ToList();
                    foreach (Page page in sortedPagesByLikes)
                    {
                        listBoxFacebookItems.Items.Add(page);
                    }
                    break;

                case "Oldest Page":

                    listBoxFacebookItems.Items.Clear();
                    break;

                case "Friends with post mutual Friends":
                    listBoxFacebookItems.Items.Clear();
                    foreach (Friend friend in sotrtedMutualFreinds())
                    {
                        listBoxFacebookItems.Items.Add(friend);
                    }
                    break;

                case "Friends with most Friends":
                    listBoxFacebookItems.Items.Clear();
                    List<User> sortedFriendsByFriends = m_LoggedInUser.Friends.OrderBy(o => o.Friends.Count).ToList();
                    foreach (User friend in sortedFriendsByFriends)
                    {
                        listBoxFacebookItems.Items.Add(friend);
                    }
                    break;

                case "Groups with most members":
                    listBoxFacebookItems.Items.Clear();
                    List<Group> sortedGroupByMembers = m_LoggedInUser.Groups.OrderBy(o => o.Members.Count).ToList();
                    foreach (Group group in sortedGroupByMembers)
                    {
                        listBoxFacebookItems.Items.Add(group);
                    }
                    break;

                case "Groups with most friends":
                    listBoxFacebookItems.Items.Clear();
                    foreach(GroupExtend group in sotrtedMutualFreindsInGroup())
                    {
                        listBoxFacebookItems.Items.Add(group);
                    }
                    break;
            }
        }

        private List<Friend> sotrtedMutualFreinds()
        {
            List<Friend> friendList = new List<Friend>();

            foreach(User user_i in m_LoggedInUser.Friends)
            {
                Friend friend;
                friend = user_i as Friend;
                
                foreach (User user_j in user_i.Friends)
                {
                    if (friend.Friends.Contains((user_j)))
                    {
                        friend.AddMutualFriends((user_j));
                    }

                }
                friendList.Add(friend);
            }
            friendList.OrderBy(o => o.m_MutuaLFrinds.Count).ToList();
            return friendList;
        }

        private List<GroupExtend> sotrtedMutualFreindsInGroup()
        {
            List<GroupExtend> gruopList = new List<GroupExtend>();

            foreach (Group gruop_i in m_LoggedInUser.Groups)
            {
                
                GroupExtend group;
                group = gruop_i as GroupExtend;

                foreach (User user_j in gruop_i.Members)
                {
                    if (group.Members.Contains((user_j)))
                    {
                        group.AddMutualFriends((user_j));
                    }

                }
                gruopList.Add(group);
            }
            gruopList.OrderBy(o => o.m_MutuaLFrinds.Count).ToList();
            return gruopList;
        }

        private void listBoxFacebookItems_SelectedIndexChanged(object sender, EventArgs e)
            {
            listBoxPost.Items.Clear();
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                object selectedItem;
                switch (comboBoxFacebookObjects.SelectedItem.ToString())
                {
                    case "Pages":
                        selectedItem = listBoxFriends.SelectedItem as Page;

                        break;

                    case "Friends":
                        selectedItem = listBoxFriends.SelectedItem as User;
          
                        break;

                    case "Groups":
                        selectedItem = listBoxFriends.SelectedItem as Group;
                        break;
                }
                List<Post> sortedPostByLikes = m_LoggedInUser.Posts.OrderBy(o => o.LikedBy.Count).ToList();
                foreach (Post post in sortedPostByLikes)
                {
                    listBoxFacebookItems.Items.Add(post);
                }

            }

        }
    }
}
