using System;
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
        //sehirID
        //UlkeID
        //IlceID
        //public string UserAddress { get; set; }
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
