using NUnit.Framework;

namespace singleResponsibility.UnitTest;

[TestFixture]
public class CustomerRepositoryTests
{
    [Test]
    public void Add_ValidCustomer_CustomerAddedToDatabase()
    {
        // Arrange
        var customer = new Customer { Name = "John Doe", Email = "john@example.com" };
        var repo = new CustomerRepository();

        // Act
        repo.Add(customer);

        // Assert
        // Check the database to verify that the customer was added correctly
    }

}