﻿using MovieRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        //Foreign key
        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        //IHttpActionResult mismatch Customer [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}