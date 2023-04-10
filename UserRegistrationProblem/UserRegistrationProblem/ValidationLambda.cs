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

    }
}
