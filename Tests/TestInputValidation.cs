using NUnit.Framework;

[TestFixture]
public class TestInputValidation {
    [Test]
    public void TestForSQLInjection() {
        // Simulate a SQL injection attempt
        string maliciousInput = "'; DROP TABLE Users; --";
        bool isValid = ValidateInput(maliciousInput);
        Assert.IsFalse(isValid, "Input validation failed to catch SQL injection.");
    }

    [Test]
    public void TestForXSS() {
        // Simulate an XSS attack
        string maliciousInput = "<script>alert('XSS');</script>";
        bool isValid = ValidateInput(maliciousInput);
        Assert.IsFalse(isValid, "Input validation failed to catch XSS attack.");
    }

    private bool ValidateInput(string input) {
        // Basic validation logic to prevent SQL injection and XSS
        // This should be replaced with actual validation logic
        if (input.Contains("'") || input.Contains("<script>")) {
            return false;
        }
        return true;
    }
}