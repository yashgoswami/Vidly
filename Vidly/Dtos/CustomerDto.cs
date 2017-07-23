using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {

        public int ID { get; set; }

        // Adding attributes to decide db field proerties
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }
        
        // EF will treat this as a foreign key

        public byte MembershipTypeId { get; set; }
    }
}