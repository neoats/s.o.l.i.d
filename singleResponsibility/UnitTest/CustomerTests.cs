using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace singleResponsibility.UnitTest
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void IsValidEmail_ValidEmail_ReturnsTrue()
        {
            // Arrange
            var customer = new Customer { Email = "john@example.com" };

            // Act
            var result = customer.IsValidEmail();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
