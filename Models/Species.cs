using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGrooming.Models
{
    public class Species
    {

        [Key]
        public int speciesID { get; set; }

        public string speciesName { get; set; }


        //Representing the "Many" in (One Species to many Pets)
        public ICollection<Pet> Pets { get; set; }
    }
}