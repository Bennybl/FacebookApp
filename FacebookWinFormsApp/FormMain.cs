using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;
        private LoginResult m_LoginResult;
        private Dictionary<string, List<Event>> m_CitiesAndEvents = new Dictionary<string, List<Event>>();
        private Dictionary<string, List<Page>> m_CitiesAndRestaurants = new Dictionary<string, List<Page>>();
        private Dictionary<string, string[]> m_ComboBoxFacebookObjectsOptional = new Dictionary<string, string[]>();
        private FormAboutMe m_FormAboutMe = null;
        private FormAppSettings m_FormAppSettings = null;

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            m_ComboBoxFacebookObjectsOptional.Add("Pages", new string[] {"Most liked Pages"});
            m_ComboBoxFacebookObjectsOptional.Add("Friends", new string[] {"Friends with post mutual Friends", "Friends with most Friends" });
            m_ComboBoxFacebookObjectsOptional.Add("Groups", new string[] {"Groups with most members", "Groups with most friends" });
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
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                fetchUserInfo();
                changeButtonsStatus();
                fetchCitiesEventsRestaurants();
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
            textBoxPostStatus.Text = "";
            listBoxCities.Items.Clear();
            listBoxEventsByCity.Items.Clear();
            listBoxRestaurantsByCity.Items.Clear();
            listBoxFacebookItems.Items.Clear();
            listBoxPostStatistics.Items.Clear();

        }

        private void fetchCitiesEventsRestaurants()
        {
            foreach(Event selectedEvent in m_LoggedInUser.Events)
            {
                addEvent(selectedEvent);
            }

            foreach(Page selectedPage in m_LoggedInUser.LikedPages)
            {
                if(selectedPage.Category != null && selectedPage.Category.Equals("Restaurant"))
                {
                    addRestaurant(selectedPage);
                }
            }

            if(m_LoggedInUser.Friends != null)
            {
                foreach(User friend in m_LoggedInUser.Friends)
                {
                    foreach(Event selectedEvent in friend.Events)
                    {
                        addEvent(selectedEvent);
                    }
                    foreach(Page selectedPage in m_LoggedInUser.LikedPages)
                    {
                        if(selectedPage.Category != null)// && selectedPage.Category.Equals("Restaurant"))
                        {
                            addRestaurant(selectedPage);
                        }
                    }
                }
            }

            foreach(string cityName in m_CitiesAndEvents.Keys)
            {
                listBoxCities.Items.Add(cityName);
            }
        }

        private void addEvent(Event i_SelectedEvent)
        {
            if(i_SelectedEvent.Place.Location.City != null)
            {
                string city = i_SelectedEvent.Place.Location.City;
                if(!m_CitiesAndEvents.ContainsKey(city))
                {
                    m_CitiesAndEvents.Add(city, new List<Event>());
                }

                m_CitiesAndEvents[city].Add(i_SelectedEvent);
            }
        }

        private void addRestaurant(Page i_Page)
        {
            if(i_Page.Location.City != null)
            {
                string restaurant = i_Page.Location.City;
                if(!m_CitiesAndEvents.ContainsKey(restaurant))
                {
                    m_CitiesAndRestaurants.Add(restaurant, new List<Page>());
                }

                m_CitiesAndRestaurants[restaurant].Add(i_Page);
            }
        }

        private void listBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxCities.SelectedItems.Count == 1)
            {
                listBoxEventsByCity.Items.Clear();
                string city = listBoxCities.SelectedItem.ToString();
                if(m_CitiesAndEvents.ContainsKey(city))
                {
                    foreach(Event selectedEvent in m_CitiesAndEvents[city])
                    {
                        listBoxEventsByCity.Items.Add(selectedEvent);
                    }
                }

                if(m_CitiesAndRestaurants.ContainsKey(city))
                {
                    foreach(Page selectedPage in m_CitiesAndRestaurants[city])
                    {
                        listBoxEventsByCity.Items.Add(selectedPage);
                    }
                }
            }

        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Posts.Count > 0)
            {
                textBoxPostStatus.Text = m_LoggedInUser.Posts[0].Message;
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
            comboBoxFacebookObjects.Enabled = !comboBoxFacebookObjects.Enabled;
            buttonRestaurantDetails.Enabled = !buttonRestaurantDetails.Enabled;
            buttonEventDetails.Enabled = !buttonEventDetails.Enabled;
            buttonLogout.Enabled = !buttonLogout.Enabled;
            buttonSettings.Enabled = !buttonSettings.Enabled;
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
        
        private void buttonAboutMe_Click(object sender, EventArgs e)
        {
            if (m_FormAboutMe == null)
            {
                m_FormAboutMe = new FormAboutMe(m_LoggedInUser);
            }

            m_FormAboutMe.ShowDialog();
        }

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
                Event selectedEvent = listBoxEventsByCity.SelectedItem as Event;
                if(selectedEvent != null)
                {
                    FormEvent formEvent = new FormEvent(listBoxEventsByCity.SelectedItem as Event);
                    formEvent.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cannot retrive event details");
                }
            }
        }

        private void comboBoxFacebookObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxFacebookObjects.SelectedItem.ToString();
            comboBoxFacebookObjectsOptions.Items.Clear();
            comboBoxFacebookObjectsOptions.Items.AddRange(m_ComboBoxFacebookObjectsOptional[selectedItem]);
        }

        private void comboBoxFacebookObjectsOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFacebookItems.Text = comboBoxFacebookObjectsOptions.SelectedItem.ToString();
            listBoxFacebookItems.Items.Clear();
            switch (comboBoxFacebookObjectsOptions.SelectedItem)
            {
                case "Most liked Pages":
                    List<Page> sortedPagesByLikes = m_LoggedInUser.LikedPages.OrderBy(page => page.LikesCount).ToList();
                    foreach (Page page in sortedPagesByLikes)
                    {
                        listBoxFacebookItems.Items.Add(page);
                    }

                    break;

                case "Friends with most mutual Friends":
                    foreach (Friend friend in friendsSortedByMutualFriends())
                    {
                        listBoxFacebookItems.Items.Add(friend);
                    }

                    break;

                case "Friends with most Friends":
                    List<User> sortedFriendsByFriends = m_LoggedInUser.Friends.OrderBy(friend => friend.Friends.Count).ToList();
                    foreach (User friend in sortedFriendsByFriends)
                    {
                        listBoxFacebookItems.Items.Add(friend);
                    }

                    break;

                case "Groups with most members":
                    List<Group> sortedGroupByMembers = m_LoggedInUser.Groups.OrderBy(group => group.Members.Count).ToList();
                    foreach (Group group in sortedGroupByMembers)
                    {
                        listBoxFacebookItems.Items.Add(group);
                    }

                    break;

                case "Groups with most friends":
                    foreach(GroupExtend group in sotrtedMutualFreindsInGroup())
                    {
                        listBoxFacebookItems.Items.Add(group);
                    }

                    break;
            }
        }

        private List<Friend> friendsSortedByMutualFriends()
        {
            List<Friend> friendList = new List<Friend>();
            Friend friend;
            foreach(User friendUser in m_LoggedInUser.Friends)
            {
                friend = friendUser as Friend;
                foreach (User friendOfFriend in friend.Friends)
                {
                    if (m_LoggedInUser.Friends.Contains(friendOfFriend))
                    {
                        friend.AddMutualFriends(friendOfFriend);
                    }

                }

                friendList.Add(friend);
            }

            friendList.OrderBy(userFriend => userFriend.MutualFriends.Count).ToList();

            return friendList;
        }

        private List<GroupExtend> sotrtedMutualFreindsInGroup()
        {
            List<GroupExtend> groupList = new List<GroupExtend>();
            GroupExtend group;
            foreach (Group userGroup in m_LoggedInUser.Groups)
            {
                group = userGroup as GroupExtend;
                foreach (User groupMember in userGroup.Members)
                {
                    if (m_LoggedInUser.Friends.Contains(groupMember))
                    {
                        group.AddMutualFriends((groupMember));
                    }

                }

                groupList.Add(group);
            }

            groupList.OrderBy(userGroup => userGroup.MutualFriends.Count).ToList();

            return groupList;
        }

        private void listBoxFacebookItems_SelectedIndexChanged(object sender, EventArgs e)
            {
            labelFacebookItemsPost.Text = $"{labelFacebookItems.Text} Most liked Posts";
            listBoxPostStatistics.Items.Clear();
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                object selectedItem;
                switch (comboBoxFacebookObjects.SelectedItem.ToString())
                {
                    case "Pages":
                        selectedItem = listBoxFacebookItems.SelectedItem as Page;

                        break;

                    case "Friends":
                        selectedItem = listBoxFacebookItems.SelectedItem as User;
          
                        break;

                    case "Groups":
                        selectedItem = listBoxFacebookItems.SelectedItem as Group;
                        break;
                }

                List<Post> sortedPostByLikes = m_LoggedInUser.Posts.OrderBy(post => post.LikedBy.Count).ToList();
                foreach (Post post in sortedPostByLikes)
                {
                    listBoxPostStatistics.Items.Add(post);
                }

            }

        }

        private void labelEventsSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void buttonRestaurantDetails_Click(object sender, EventArgs e)
        {
            if(listBoxRestaurantsByCity.Items.Count == 1)
            {
                Page selectedPage = listBoxRestaurantsByCity.SelectedItem as Page;
                if(selectedPage != null)
                {
                    FormPage formPage = new FormPage(listBoxRestaurantsByCity.SelectedItem as Page);
                    formPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cannot retrive page details");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelFacebookStas_Click(object sender, EventArgs e)
        {

        }

        private void buttonPageDetails_Click(object sender, EventArgs e)
        {
            Page page = listBoxPages.SelectedItem as Page;
            FormPage form = new FormPage(page);
            form.ShowDialog();
        }

        private void listBoxEventsByCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPostStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxRestaurants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabFeature1_Click(object sender, EventArgs e)
        {

        }
    }
}
