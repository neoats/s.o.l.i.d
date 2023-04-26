using NUnit.Framework;

namespace singleResponsibility.UnitTest;

[TestFixture]
public class EmailSenderTests
{
    [Test]
    public void SendEmail_ValidParameters_EmailSentSuccessfully()
    {
        // Arrange
        var sender = new EmailSender();
        var email = "john@example.com";
        var subject = "Test Email";
        var body = "Email Tested";

        // Act
        sender.SendEmail(email, subject, body);

        // Assert
        // Check the email server to verify that the email was sent correctly
    }
}