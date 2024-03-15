using System;
using System.Security.Cryptography;
using System.Text;

public class PasswordManager
{
    private const int SaltSize = 32; // Size of the salt in bytes
    private const int IterationCount = 10000; // Number of iterations for PBKDF2

    
    public static void Main(string[] args)
    {
        string password = GenerateRandomPassword();
        string salt = GenerateRandomSalt();
        string hashedPassword = HashPassword(password, salt);

        Console.WriteLine("Generated Password: " + password);
        Console.WriteLine("Salt: " + salt);
        Console.WriteLine("Hashed Password: " + hashedPassword);
    }

    public static string GenerateRandomPassword(int length = 8)
    {
        const string chars = "ABCDEFGHJKLMNPRSTUVYZ123456789";
        StringBuilder password = new StringBuilder();

        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            password.Append(chars[random.Next(chars.Length)]);
        }

        return password.ToString();
    }

    public static string GenerateRandomSalt()
    {
        byte[] saltBytes = new byte[SaltSize];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(saltBytes);
        }
        return Convert.ToBase64String(saltBytes);
    }

    public static string HashPassword(string password, string salt)
    {
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        byte[] saltBytes = Convert.FromBase64String(salt);

        byte[] hashedBytes;
        using (var pbkdf2 = new Rfc2898DeriveBytes(passwordBytes, saltBytes, IterationCount, HashAlgorithmName.SHA256))
        {
            hashedBytes = pbkdf2.GetBytes(32); // 256 bits
        }

        return Convert.ToBase64String(hashedBytes);
    }
}