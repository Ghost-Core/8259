using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using Lab7.Models;
using Microsoft.AspNetCore.Cors;
using System.Runtime.Serialization;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab7.Controllers
{

    [EnableCors]
    [Route("[controller]")]
    [ApiController]
    public class RestaurantReviewController : ControllerBase
    {
        [HttpGet]
        public List<RestaurantInfo> Get()
        {
            restaurant_review reviews = GetRestaurantsFromXml();
            List<RestaurantInfo> restInfos = new List<RestaurantInfo>();
            int id = 0;
            foreach (restaurant rest in reviews.restaurant)
            {
                RestaurantInfo restInfo = GetRestaurantInfo(rest);
                restInfo.id = id;
                restInfos.Add(restInfo);
                id++;
            }
            return restInfos;
        }
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            restaurant_review reviews = GetRestaurantsFromXml();

            restaurant restaurant = reviews.restaurant.Where(p => p.id.Trim().ToUpper() == id.Trim().ToUpper()).FirstOrDefault();
            if (restaurant == null)
            {
                return NotFound($"id {id} does not exist");
            }
            return Ok(restaurant);

        }
        [Route("[action]/{name}")]
        [HttpGet]
        public restaurant GetRestaurantByName(string name)
        {

            restaurant_review reviews = GetRestaurantsFromXml();

            restaurant restaurant = reviews.restaurant.Where(p => p.id.Trim().ToUpper() == id.Trim().ToUpper()).FirstOrDefault();

            return restaurant;
        }


        [HttpPost]
        public void Post([FromBody] restaurant restaurant)
        {

            restaurant_review reviews = GetRestaurantsFromXml();

            List<restaurant> items = reviews.restaurant.ToList();

            string lastId = items[items.Count - 1].id;
            int lastNum = int.Parse(lastId.Substring(1)) + 1;
            restaurant.id = "S" + lastNum.ToString();

            items.Add(restaurant);
            reviews.restaurant = items.ToArray();

            WriteRestaurantsToXml(reviews);
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



        // saving restaurant info into XML
        public bool SaveRestaurant(RestaurantInfo restInfo)
        {
            var restaurantListXML = GetRestaurantsFromXml();
            var selectedRestaurant = restaurantListXML.restaurant.Where(res => res.name == restInfo.Name).FirstOrDefault();
            if (selectedRestaurant != null)
            {
                string xmlFile = Path.GetFullPath(@"Data/restaurant_review.xml");
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
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            restaurant_review restaurantList = GetRestaurantsFromXml(); ;

            restaurantList.restaurant = restaurantList.restaurant.Where(p => p.id != id).ToArray();

            WriteRestaurantsToXml(restaurantList);
        }
        // Function to get the list of restaurants from XML file
        public restaurant_review GetRestaurantsFromXml()
        {

            restaurant_review restaurantList = null;
            string xmlFile = Path.GetFullPath(@"Data/restaurant_review.xml");

            //opening the xml file and deserializing it (converting xml file into object)
            using (FileStream xs = new FileStream(xmlFile, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(restaurant_review));
                restaurantList = (restaurant_review)serializer.Deserialize(xs);
            }
            return restaurantList;
        }
        public restaurant_review WriteRestaurantsToXml(restaurant_review restaurantList)
        {

            string xmlFile = Path.GetFullPath(@"Data/restaurant_review.xml");

            //opening the xml file and deserializing it (converting xml file into object)
            using (FileStream xs = new FileStream(xmlFile, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(restaurant_review));
                serializer.Serialize(xs, restaurantList);
            }
            return restaurantList;
        }

    }
}
