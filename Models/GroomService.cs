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

       
    }
}