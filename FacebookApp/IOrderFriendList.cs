using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Vladi_308921915_Diana_323643932
{
    public interface IOrderFriendList
    {
        List<User> OrderFriendList(List<User> i_FriendsList);
    }
}
