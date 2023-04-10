using UserRegistrationProblem;

namespace UserRegistrationTestCases
{
    public class Tests
    {
        [Test]
        public void GivenValidate_FN_WhenAnalyse_ReturnValid()
        {
            UserRegistration ur = new UserRegistration();
            string result = ur.Validate_FN("Ask");
            Assert.AreEqual(result,"VALID");
        }
        [Test]
        public void GivenValidate_LN_WhenAnalyse_ReturnValid()
        {
            UserRegistration ur = new UserRegistration();
            string result = ur.Validate_LN("Vijaya");
            Assert.AreEqual(result, "VALID");
        }
        [Test]
        public void GivenValidate_PhNo_WhenAnalyse_ReturnValid()
        {
            UserRegistration ur = new UserRegistration();
            string result = ur.Validate_PhNo("9550616986");
            Assert.AreEqual(result, "VALID");
        }
        [Test]
        public void GivenValidate_EmailId_WhenAnalyse_ReturnValid()
        {
            string[] arr = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com"};
            UserRegistration ur = new UserRegistration();
            string result = ur.Validate_EmailId(arr);
            for(int i=0;i< arr.Length;i++)
            {
                if (arr[i] == "Valid")
                    Assert.AreEqual(result, "VALID");
            }
        }
        [Test]
        public void GivenValidate_Password_WhenAnalyse_ReturnValid()
        {
            UserRegistration ur = new UserRegistration();
            string result = ur.Validate_Password("Here%123");
            Assert.AreEqual(result, "VALID");
        }
        [Test]
        public void GivenValidateFNLambda_WhenAnalyse_ReturnValid()
        {
            ValidationLambda L = new ValidationLambda();
            bool res = L.Validate_FN_Lambda("Ask");
            Assert.IsTrue(res, "VALID");
        }
        [Test]
 
    }
}