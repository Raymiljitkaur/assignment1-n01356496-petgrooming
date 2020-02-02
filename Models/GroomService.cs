using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
        [Key]
        public int serviceID { get; set; }
        public string serviceName { get; set; }
        public int serviceDuration { get; set; }
        public int serviceCost { get; set; }

        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost 
                - Duration is supposed to be in nminutes 
         */
    }
}