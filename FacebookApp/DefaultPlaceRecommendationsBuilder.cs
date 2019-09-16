using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Vladi_308921915_Diana_323643932
{
    public class DefaultPlaceRecommendationsBuilder : IPlaceRecommendationsBuilder
    {
        private PlaceRecommendations m_PlaceRecommendationsInstance = null;

        public DefaultPlaceRecommendationsBuilder()
        {
            m_PlaceRecommendationsInstance = new PlaceRecommendations();
        }

        public void BuildIPlaceRecommendations(IOrderFriendList i_Orderer)
        {
            m_PlaceRecommendationsInstance.FriendListOrderer = i_Orderer;
        }

        public PlaceRecommendations GetResult()
        {
            return m_PlaceRecommendationsInstance;
        }
    }
}
