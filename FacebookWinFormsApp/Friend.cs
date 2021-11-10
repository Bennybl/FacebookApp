using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    class Friend : User 
    {
        public List<User> m_MutuaLFrinds = new List<User>();

        public void AddMutualFriends(User i_MutualFriend)
        {
            m_MutuaLFrinds.Add(i_MutualFriend);
        }
    }
}