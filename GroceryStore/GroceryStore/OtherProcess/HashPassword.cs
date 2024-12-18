using BCrypt.Net;

public static class HashPassword
{
    // Hash mật khẩu
    public static string _HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    // Xác minh mật khẩu
    public static bool VerifyPassword(string password, string hashedPassword)
    {
        return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
    }
}
