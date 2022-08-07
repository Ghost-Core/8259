using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class RestaurantOverviewViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Rataurant")]
        public string Name { get; set; }
        [Display(Name = "Food Type")]
        public string FoodType { get; set; }
        [Display(Name = "Rating (best=5)")]
        public decimal Rating { get; set; }
        [Display(Name = "Cost (most expensive=5)")]
        public decimal Cost { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Province")]
        public string ProvinceState { get; set; }


        public static List<RestaurantOverviewViewModel> GetRestaurantOverviews(restaurant_review reviews)
        {
            List<RestaurantOverviewViewModel> overviews = new List<RestaurantOverviewViewModel>();
            int id = 0;
            foreach (restaurant rs in reviews.restaurant)
            {
                RestaurantOverviewViewModel overview = new RestaurantOverviewViewModel();
                overview.Id = id++;
                overview.Name = rs.name;
                overview.FoodType = rs.food;
                decimal maxCost = rs.pricerating.max == 0 ? 5 : rs.pricerating.max;
                overview.Cost = rs.pricerating.Value / maxCost * 5;
                decimal MaxRating = rs.reviews.reviewerinfo.rating.max == 0 ? 5 : rs.reviews.reviewerinfo.rating.max;
                overview.Rating = rs.reviews.reviewerinfo.rating.Value / MaxRating * 5;
                overview.City = rs.address.city;
                overview.ProvinceState = rs.address.province.ToString();
                overviews.Add(overview);
            }
            return overviews;
        }

    }
    
}
