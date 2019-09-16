using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Vladi_308921915_Diana_323643932
{
    public class AlteredUser : User
    {
        public new string Name { get; set; }

        public new string PictureNormalURL { get; set; }
    }
}
