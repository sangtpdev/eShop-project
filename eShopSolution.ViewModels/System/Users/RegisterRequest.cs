using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.System.Users
{
    public class RegisterRequest
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime DoB { set; get; }
        public string  Email { get; set; }
        public string PhoneNumber { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
