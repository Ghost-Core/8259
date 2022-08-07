using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Models
{
    public class RestaurantEditViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Province")]
        public StateProvinceType ProvinceState { get; set; }
        [Required]
        [RegularExpression(@"^[a‐zA‐Z]\d[a‐zA‐Z](\s)*\d[a‐zA‐Z]\d$",
        ErrorMessage = "Must be in the form of A1A 1A1")]
        [Display(Name = "Postal Code")]
        public string PostalZipCode { get; set; }
        [Required]
        [Display(Name = "Summary")]
        public string Summary { get; set; }
        [Required]
        [Range(1, 5)]
        [Display(Name = "Rating (1 to 5)")]
        public decimal Rating { get; set; }
        public static List<RestaurantEditViewModel> GetRestaurantEditVeiwModel(restaurant restaurant1)
        {
            List<RestaurantEditViewModel> rest = new List<RestaurantEditViewModel>();
            int id = 0;
            foreach (restaurant rs in restaurant1)
            {
                RestaurantEditViewModel edit = new RestaurantEditViewModel();
                edit.Id = id++;
                edit.Name = rs.name;
                edit.StreetAddress = rs.address.street;
                edit.City = rs.address.city;
                edit.ProvinceState = rs.address.province;
                edit.PostalZipCode = rs.address.postalcode;
                edit.Summary = rs.reviews.reviewerinfo.summary;
                decimal MaxRating = rs.reviews.reviewerinfo.rating.max == 0 ? 5 : rs.reviews.reviewerinfo.rating.max;
                edit.Rating = rs.reviews.reviewerinfo.rating.Value / MaxRating * 5;
                rest.Add(edit);
            }
            return rest;
        }

    }
}
