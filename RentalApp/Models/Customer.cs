﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(255), Required]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth"),Required,DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
    }
}
