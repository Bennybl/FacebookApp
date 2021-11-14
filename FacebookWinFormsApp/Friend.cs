using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class Friend : User 
    {
        private List<User> m_MutuaLFrinds = new List<User>();

        public Friend() { }
        public List<User> MutualFriends
        {
            get { return m_MutuaLFrinds; }
        } 

        public void AddMutualFriends(User i_MutualFriend)
        {
            m_MutuaLFrinds.Add(i_MutualFriend);
        }
    }
}