using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace ValidationEx
{
    [TestClass]
    public class ValidatorTest
    {
        [Fact]
        public void Validate_Name()
        {
            Validator obj = new Validator();

            string name = "Victor";

            if (name.Length < 2 || name.Length > 64)
            {
                Assert.Fail();
            }

            bool result = obj.validateName(name);

            Assert.IsTrue(result);
     
        }
        [Fact]
        public void Validate_LastName()
        {
            Validator obj = new Validator();

            string lastname = "Matos";

            if (lastname.Length < 2 ||lastname.Length > 128)
            {
                Assert.Fail();
            }

            bool result = obj.validateLastName(lastname);

            Assert.IsTrue(result);
        }
        [Fact]
        public void Validate_Age()
        {
            Validator obj = new Validator();

            int age = 9;

            if (age < 1 || age > 18)
            {
                Assert.Fail();
            }

            bool result = obj.validateAge(age);

            Assert.IsTrue(result);
        }
    }
}