﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace A18_Ex03_Vladi_308921915_Diana_323643932
{
    public class EventsFinderByMaximumAttendees : EventsFinderBy
    {
        public override void GetValidEvents(int i_Number, User i_User)
        {
            foreach (Event fbEvent in i_User.Events)
            {
                lock (sr_AddToListLock)
                {
                    if (fbEvent.AttendingUsers.Count <= i_Number)
                    {
                        ListOfValidEvents.Add(fbEvent);
                    }
                }
            }
        }
    }
}
