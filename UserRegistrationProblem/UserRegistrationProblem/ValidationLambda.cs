using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class ValidationLambda
    {
        public bool Validate_FN_Lambda(string fn) => Regex.IsMatch(fn, "^[A-Z]{1}[a-z]{2,}$") ? true : false;
        public bool Validate_LN_Lambda(string ln) => Regex.IsMatch(ln, "^[A-Z]{1}[a-z]{2,}$") ? true : false;
        public bool Validate_PhNo_Lambda(string phno) => Regex.IsMatch(phno, "^[6-9]{1}[0-9]{9}$") ? true : false;
        public bool Validate_Password_Lambda(string Password) => Regex.IsMatch(Password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!@#$%&*+]).{8,}$") ? true : false;
        public bool Validate_EmailID_Lambda(string email ) => Regex.IsMatch(email, "^[0-9A-Za-z]+[.+_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3}){0,1}$") ? true : false;
    }
}
