using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace Lab7.Models
{
    [DataContract]
    public class RestaurantInfo
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Summary { get; set; }

        [DataMember]
        public int Rating { get; set; }
        [DataMember]
        public Address Location { get; set; }

    }

    [DataContract]
    public class Address
    {
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Province { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
    }

}
