using System.Collections.Generic;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    class GroupExtend : Group
    {
        private List<User> m_MutualFrinds = new List<User>();

        public GroupExtend() { }
        public List<User> MutualFriends
        {
            get { return m_MutualFrinds; }
        }

        public void AddMutualFriends(User i_MutualFriend)
        {
            m_MutualFrinds.Add(i_MutualFriend);
        }
    }
}