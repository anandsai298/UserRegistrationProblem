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
            UserRegistration ur = new UserRegistration();
            string result = ur.Validate_EmailId("anand@gmail.com");
            Assert.AreEqual(result, "VALID");
        }
        [Test]
        public void GivenValidate_Password_WhenAnalyse_ReturnValid()
        {
            UserRegistration ur = new UserRegistration();
            string result = ur.Validate_Password("Here%123");
            Assert.AreEqual(result, "VALID");
        }
    }
}