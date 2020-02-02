﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class Groomer
    {
        public int groomerID { get; set; }
        public string groomerName { get; set; }
        public int groomerEmpno { get; set; }
        public int groomerPhone { get; set; }
        public DateTime groomerDOB { get; set; }
        public int groomerExp { get; set; }
        public int groomerRate { get; set; }





        /* 
            A groomer is someone who is employed to groom pets
            Some things that describe a groomer
                - Name
                - Date of Birth
                - Phone Number
                - Hourly Rate
                - experience
                - employee number 
                - phone number 
                -


            A booking must reference to a groomer
        */
    }
}