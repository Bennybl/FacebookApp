using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    class GroupExtend : Group
    {
        private List<User> m_MutualFrinds = new List<User>();
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