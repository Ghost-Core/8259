using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string xmlFilePath = Path.GetFullPath("Data/restaurant_review.xml");

            restaurant_review restaurantReviews = null;
            using (FileStream xs = new FileStream(xmlFilePath, FileMode.Open))
            {
                XmlSerializer serializor = new XmlSerializer(typeof(restaurant_review));
                restaurantReviews = (restaurant_review)serializor.Deserialize(xs);
            }
            List<RestaurantOverviewViewModel> overviews = RestaurantOverviewViewModel.GetRestaurantOverviews(restaurantReviews);


            return View(overviews);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error");
            }
            string xmlFilePath = Path.GetFullPath("Data/restaurant_review.xml");

            restaurant_review restaurantReviews = null;
            using (FileStream xs = new FileStream(xmlFilePath, FileMode.Open))
            {
                XmlSerializer serializor = new XmlSerializer(typeof(restaurant_review));
                restaurantReviews = (restaurant_review)serializor.Deserialize(xs);
            }
            if (id.Value < 0 || id.Value >= restaurantReviews.restaurant.Length)
            {
                return RedirectToAction("Error");
            }
            restaurant restaurant = restaurantReviews.restaurant[id.Value];
            //RestaurantEditViewModel rest = RestaurantEditViewModel.GetRestaurantEditVeiwModel(restaurant);
            return View(rest);

            //XmlDocument doc = new XmlDocument();
            //doc.Load(xmlFilePath);
            //foreach (XmlNode node in doc.SelectNodes("/restaurant_reviews/restaurant"))
            //{
            //    if (int.Parse(node["id"].InnerText) == id)
            //    {

            //        var restaurantInfo = new RestaurantEditViewModel();
            //        restaurantInfo.Id = int.Parse(node["id"].InnerText);
            //        restaurantInfo.Name = node["name"].InnerText;
            //        //restaurantInfo.StreetAddress = node["food"].InnerText;
            //        XmlNodeList contactNodes = node.SelectNodes("contact");
            //        foreach (XmlNode contact in contactNodes)
            //        {

            //            XmlNodeList addrNodes = node.SelectNodes("address");
            //            foreach (XmlNode addrn in addrNodes)
            //            {
            //                restaurantInfo.StreetAddress = addrn["st_number"].InnerText + addrn["street"].InnerText;
            //                restaurantInfo.City = addrn["city"].InnerText;
            //                restaurantInfo.ProvinceState = (province)Enum.Parse(typeof(province), addrn["province"].InnerText, true); ;
            //                restaurantInfo.PostalZipCode = addrn["postal"].InnerText;
            //            }
            //        }
            //        XmlNodeList ratingNodes = node.SelectNodes("reviews");
            //        foreach (XmlNode ratNodes in ratingNodes)
            //        {
            //            foreach (XmlNode ratNodes2 in ratNodes.SelectNodes("reviews"))
            //            {
            //                restaurantInfo.Rating = Convert.ToDecimal(ratNodes2["rating"].InnerText);
            //                restaurantInfo.Summary = ratNodes2["summary"].InnerText;
            //            }
            //        }
            //        editRestaurant.Add(restaurantInfo);
            //    }
            //}
            //return View(editRestaurant[0]);
        }
        [HttpPost]
        public IActionResult Edit(RestaurantEditViewModel rsVM)
        {


            string xmlFilePath = Path.GetFullPath("Data/restaurant_review.xml");
            try
            {
                restaurant_review restaurantReviews = null;
                using (FileStream xs = new FileStream(xmlFilePath, FileMode.Open))
                {
                    XmlSerializer serializor = new XmlSerializer(typeof(restaurant_review));
                    restaurantReviews = (restaurant_review)serializor.Deserialize(xs);
                }

                restaurant restaurant = restaurantReviews.restaurant[rsVM.Id];

                restaurant.name = rsVM.Name;
                restaurant.address.street = rsVM.StreetAddress;
                restaurant.address.city = rsVM.City;
                restaurant.address.province = rsVM.ProvinceState;
                restaurant.address.postalcode = rsVM.PostalZipCode;
                restaurant.reviews.reviewerinfo.summary = rsVM.Summary;
                restaurant.reviews.reviewerinfo.rating.Value = (byte)rsVM.Rating;
                using (FileStream xs = new FileStream(xmlFilePath, FileMode.Create))
                {
                    XmlSerializer serializor = new XmlSerializer(typeof(restaurant_review));
                    serializor.Serialize(xs, restaurantReviews);
                }
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error");
            }
            return RedirectToAction("Index");
        
    

            //string xmlFilePath = Path.GetFullPath("Data/restaurant_reviews.xml");

            //XmlDocument doc = new XmlDocument();
            //doc.Load(xmlFilePath);

            //foreach (XmlNode node in doc.SelectNodes("/restaurant_reviews/restaurant"))
            //{
            //    if (int.Parse(node["id"].InnerText) == rsVM.Id)
            //    {
            //        node["name"].InnerText = rsVM.Name;
            //        XmlNodeList addrNodes = node.SelectNodes("address");
            //        foreach (XmlNode addrn in addrNodes)
            //        {
            //            addrn["street_address"].InnerText = rsVM.StreetAddress;
            //            addrn["city"].InnerText = rsVM.City;
            //            addrn["province"].InnerText = rsVM.ProvinceState.ToString();
            //            addrn["postal"].InnerText = rsVM.PostalZipCode;
            //        }

            //        XmlNodeList ratingNodes = node.SelectNodes("reviews");
            //        foreach (XmlNode ratNodes in ratingNodes)
            //        {
            //            foreach (XmlNode ratNodes2 in ratNodes.SelectNodes("review"))
            //            {
            //                ratNodes2["rating"].InnerText = Convert.ToString(rsVM.Rating);
            //                ratNodes2["summary"].InnerText = rsVM.Summary;
            //            }
            //        }
            //    }
            //    doc.Save(xmlFilePath);
            //}
            //return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
