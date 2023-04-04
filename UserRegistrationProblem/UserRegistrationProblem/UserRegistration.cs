using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        public static string NAME = "^[A-Z]{1}[a-z]{2,}$";
        public static string PHONE_NUMBER = "^[6-9]{1}[0-9]{9}$";
        public static string EMAIL_ID = "^[0-9A-Za-z]+[.+_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string PASSWORD = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[!@#$%&*+]).{8,}$";
        public string Validate_FN(string fn)
        {
            if (Regex.IsMatch(fn, NAME))
                return "VALID";
            return "INVALID";
            
        }
        public string Validate_LN(string ln)
        {
            if (Regex.IsMatch(ln, NAME))
                return "VALID";
            return "INVALID";
        }
        public string Validate_PhNo(string phno)
        {
            if (Regex.IsMatch(phno, PHONE_NUMBER))
                return "VALID";
            return "INVALID";
        }
        public string Validate_EmailId(string email)
        {
            if (Regex.IsMatch(email, EMAIL_ID))
                return "VALID";
            return "INVALID";
        }
        public string Validate_Password(string password)
        {
            if (Regex.IsMatch(password, PASSWORD))
                return "VALID";
            return "INVALID";
        }
    }
}