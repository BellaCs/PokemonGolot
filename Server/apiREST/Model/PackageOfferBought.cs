using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apiREST.Model
{
    public class PackageOfferBought
    {
        [ForeignKey("Package")]
        public string? package { get; set; }
        [ForeignKey("User")]
        public string? user { get; set; }
        public DateTime? last_bought_date { get; set; }


        [ForeignKey("package")]
        public virtual PackageOffer? Package { get; set; }
        [ForeignKey("user")]
        public virtual User? User { get; set; }
    }
}
