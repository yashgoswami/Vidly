using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        /// <summary>
        /// This is called Navigation property
        /// </summary>
        public MembershipType MembershipType { get; set; }

        // EF will treat this as a foreign key
        public byte MembershipTypeId { get; set; }
    }
}