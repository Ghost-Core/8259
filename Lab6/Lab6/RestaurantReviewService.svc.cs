using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml.Serialization;

namespace Lab6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RestaurantReviewService : IRestaurantReviewService
    {

        public List<string> GetRestaurantNames()
        {
            List<string> names = new List<string>();
            restaurant_review allRestaurants = GetRestaurantsFromXml();
            if (allRestaurants != null)
            {
                foreach (restaurant rest in allRestaurants.restaurant)
                {
                    names.Add(rest.name);
                }
            }
            return names;

        }

        // Getting the information for the restaurant from the list by name
        public RestaurantInfo GetRestaurantByName(string name)
        {
            restaurant_review all_restaurants = GetRestaurantsFromXml();
            if (all_restaurants != null)
            {
                foreach (restaurant rests in all_restaurants.restaurant)
                {
                    if (rests.name == name)
                    {
                        var restInfo = new RestaurantInfo
                        {
                            Name = rests.name,
                            Rating = rests.reviews.reviewerinfo.rating.Value,
                            Summary = rests.reviews.reviewerinfo.summary,
                            Location = new Address
                            {
                                Street = rests.address.street,
                                Province = rests.address.province.ToString(),
                                City = rests.address.city,
                                PostalCode = rests.address.postalcode
                            }
                        };
                        return restInfo;
                    }
                }
            }
            // return empty RestaurantInfo is name not found
            return new RestaurantInfo();
        }
        // Getting the information for the restaurant from the list by rating
        public List<RestaurantInfo> GetRestaurantsByRating(int rating)
        {
            var restaurantListXML = GetRestaurantsFromXml();
            var restaurantInfoList = new List<RestaurantInfo>();
            foreach (var rests in restaurantListXML.restaurant)
            {
                if (rests.reviews.reviewerinfo.rating.Value < rating)
                {
                    var restInfo = new RestaurantInfo
                    {
                        Name = rests.name,
                        Rating = rests.reviews.reviewerinfo.rating.Value,
                        Summary = rests.reviews.reviewerinfo.summary,
                        Location = new Address
                        {
                            Street = rests.address.street,
                            Province = rests.address.province.ToString(),
                            City = rests.address.city,
                            PostalCode = rests.address.postalcode
                        }
                    };
                    restaurantInfoList.Add(restInfo);
                }
            }
            //if there is nothing found, it returns an empty restinfo
            return restaurantInfoList;
        }

        // saving restaurant info into XML
        public bool SaveRestaurant(RestaurantInfo restInfo)
        {
            var restaurantListXML = GetRestaurantsFromXml();
            var selectedRestaurant = restaurantListXML.restaurant.Where(res => res.name == restInfo.Name).FirstOrDefault();
            if (selectedRestaurant != null)
            {
                string xmlFile = HttpContext.Current.Server.MapPath(@"App_Data/restaurant_review.xml");
                selectedRestaurant.reviews.reviewerinfo.summary = restInfo.Summary;
                selectedRestaurant.reviews.reviewerinfo.rating.Value = (byte)restInfo.Rating;
                using (FileStream xs = new FileStream(xmlFile, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(restaurant_review));
                    serializer.Serialize(xs, restaurantListXML);
                }
                return true;
            }
            return false;
        }

        // Function to get the list of restaurants from XML file
        public restaurant_review GetRestaurantsFromXml()
        {
            restaurant_review restaurantList = null;
            string xmlFile = HttpContext.Current.Server.MapPath(@"App_Data/restaurant_review.xml");

            //opening the xml file and deserializing it (converting xml file into object)
            using (FileStream xs = new FileStream(xmlFile, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(restaurant_review));
                restaurantList = (restaurant_review)serializer.Deserialize(xs);
            }
            return restaurantList;
        }
    }

}
