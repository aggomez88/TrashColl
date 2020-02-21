using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string PickupDay { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string OneTimePickUp { get; set; }
        public string AccountBalance { get; set; }

        [ForeignKey("IdentityUser")]
        [Display(Name ="IdentityUser")]

        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        [NotMapped]
        public IEnumerable<IdentityUser> IdentityUsers { get; set; }

        [ForeignKey("Address")]
        [Display(Name = "AddressUserId")]

        public int AddressUserId { get; set; }
        public Address Address { get; set; }

        [NotMapped]
        public IEnumerable<Address> Addresses { get; set; }

    }
}
