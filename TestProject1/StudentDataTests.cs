using NUnit.Framework;

namespace AOP3UVV.Tests {
    [TestFixture]
    public class StudentDataTests {
        private StudentData student;
        private string passwordCorrect;

        [SetUp]
        public void SetUp() {
            student = new StudentData("filipe", "123456", "email.com", 1, "10/04/1993");
            passwordCorrect = "1";
        }

        [Test]
        public void CheckWithPasswordIsEmpty() {
            //Asserts
            Assert.That(student.Password, Is.Not.Empty);
            Assert.That(student.Registration.ToString(), Is.EqualTo(passwordCorrect));
        }

    }
}
