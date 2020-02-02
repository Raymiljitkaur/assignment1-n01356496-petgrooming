﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Owner
    {
        [Key]
        public int ownerID { get; set; }
        public string ownerName { get; set;}
        public int  ownerPhone { get; set; }
        public String ownerAddress { get; set; }
        public string ownerEmail { get; set; }

        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)

            An owner must reference a list of pets
            
        */
        public int PetID { get; set; }
        [ForeignKey ("PetID")]
        public virtual Pet Pet { get; set; }

    }
}