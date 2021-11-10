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
        public List<User> m_MutualFrinds = new List<User>();

        public void AddMutualFriends(User i_MutualFriend)
        {
            m_MutualFrinds.Add(i_MutualFriend);
        }
    }
}