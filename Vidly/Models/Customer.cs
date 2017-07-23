using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }

        // Adding attributes to decide db field proerties
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }

        /// <summary>
        /// This is called Navigation property
        /// </summary>
        public MembershipType MembershipType { get; set; }

        // EF will treat this as a foreign key

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
                
    }
}