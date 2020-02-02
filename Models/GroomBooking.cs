using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        public int bookingID { get; set; }
        public int bookingPrice { get; set; }
        public string groomerName { get; set;}
        public string petName { get; set; }
        public string ownerName { get; set; }
        public  string serviceName { get; set; }

        public int groomerID { get; set; }
        [ForeignKey("groomerID")]
        public virtual Groomer Groomer { get; set; }

        public int PetID { get; set; }
        [ForeignKey("PetID")]
        public virtual Pet Pet { get; set; }

        public int ownerID { get; set; }
        [ForeignKey("ownerID")]
        public virtual Owner Owner { get; set; }

        public int serviceID { get; set; }
        [ForeignKey("serviceID")]
        public virtual GroomService GroomService { get; set; }
    }
}