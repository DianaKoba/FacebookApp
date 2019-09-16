using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex03_Vladi_308921915_Diana_323643932
{
    public interface IPlaceRecommendationsBuilder
    { 
        void BuildIPlaceRecommendations(IOrderFriendList i_Orderer);

        PlaceRecommendations GetResult();
    }
}
