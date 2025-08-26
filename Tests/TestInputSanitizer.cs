using NUnit.Framework;
using SafeVault.Helpers;

[TestFixture]
public class TestInputSanitizer
{
    [Test]
    public void Test_SQLInjection_Removed()
    {
        string input = "'; DROP TABLE Users; --";
        string sanitized = InputSanitizer.Sanitize(input);
        Assert.IsFalse(sanitized.Contains("'") || sanitized.Contains(";") || sanitized.Contains("--"));
    }

    [Test]
    public void Test_XSS_Removed()
    {
        string input = "<script>alert('XSS');</script>";
        string sanitized = InputSanitizer.Sanitize(input);
        Assert.IsFalse(sanitized.Contains("<script>") || sanitized.Contains("</script>"));
    }

    [Test]
    public void Test_ValidInput_Preserved()
    {
        string input = "user@example.com";
        string sanitized = InputSanitizer.Sanitize(input);
        Assert.AreEqual("user@example.com", sanitized);
    }
}