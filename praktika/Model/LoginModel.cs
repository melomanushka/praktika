using praktika.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika.Model
{
    internal class LoginModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ErrorMessage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstPasswordForSignUp { get; set; }
        public string SecondPasswordForSignUp { get; set; }
        public DataBaseModel DataBaseModel { get; set; }
    }
}
