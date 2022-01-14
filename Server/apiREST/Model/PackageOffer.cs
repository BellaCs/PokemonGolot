using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace apiREST.Model
{
    public class PackageOffer
    {
        public PackageOffer() 
        {
            buyers = new HashSet<PackageOfferBought>();
            Items = new HashSet<PackageItems>();
        }
        [Key]
        public string? name { get; set; }
        public double? price { get; set; }
        public bool? active { get; set; }


        public ICollection<PackageOfferBought> buyers { get; set; }
        public ICollection<PackageItems> Items { get; set; }
    }
}
