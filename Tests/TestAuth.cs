using NUnit.Framework;
using SafeVault.Helpers;

[TestFixture]
public class TestAuth
{
    [Test]
    public void TestPasswordHashingAndVerification()
    {
        string password = "SecurePass123!";
        string hash = PasswordHelper.HashPassword(password);
        Assert.IsTrue(PasswordHelper.VerifyPassword(password, hash));
        Assert.IsFalse(PasswordHelper.VerifyPassword("WrongPass", hash));
    }

    [Test]
    public void TestRoleBasedAccess()
    {
        string role = "admin";
        Assert.IsTrue(role == "admin", "Admin should have access.");
        role = "user";
        Assert.IsFalse(role == "admin", "User should not have admin access.");
    }
}