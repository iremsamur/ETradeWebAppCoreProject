﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public int RoleID { get; set; }
        public Role Role { get; set; }


        public string UserName { get; set; }
        public string UserTcIdentificationNumber { get; set; }


        public int? CountryID { get; set; }
        public Country Country { get; set; }

        public int? CityID { get; set; }
        public City City { get; set; }

        public int? DistrictID { get; set; }
        public District District { get; set; }


        public string UserEmail { get; set; }
        public long UserMobileNumber { get; set; }
        public long UserPhoneNumber { get; set; }
        public string UserPassword { get; set; }
        public string AskSecurity { get; set; }
        public string SecurityQuestionAndAnswer { get; set; }
        public DateTime UserRegistrationDate { get; set; }

        public List<AddressDefinition> AddressDefinitions;


        //public List<User> Users { get; set; }
    }
}
