# Password Generator

This is a simple password generator written in C# that generates a random password, a corresponding salt, and a hashed password using the PBKDF2 algorithm. It is designed to provide a secure and efficient way to generate and hash passwords for applications.

## How to Use

1. **Compile**: Compile the provided C# code using a C# compiler such as `csc` or use an integrated development environment (IDE) like Visual Studio.

    ```sh
    csc PasswordManager.cs
    ```

2. **Run**: Execute the compiled program.

    ```sh
    PasswordManager.exe
    ```

3. **Output**: The program will display the generated password, its corresponding salt, and the hashed password. These can be used for secure password storage in your application's database.

## Functionality

- **Random Password Generation**: The program generates a random password of configurable length using a set of alphanumeric characters.
- **Secure Salt Generation**: A random salt is generated securely to be used alongside the password during hashing. This adds additional security to the hashed password.
- **Password Hashing**: The password is hashed using the PBKDF2 algorithm, which is considered a secure method for password hashing. This produces a hashed password that can be safely stored in a database.

## Security Considerations

- **Password Strength**: The strength of the generated password can be adjusted by changing the length and character set used in the generation process.
- **Secure Salt Generation**: The program uses a secure method for generating random salts, enhancing the security of the hashed passwords.
- **Password Hashing**: Passwords are hashed using the PBKDF2 algorithm, which is resistant to brute-force attacks and rainbow table attacks.

## Best Practices

- **Code Readability**: The code is written with readability in mind, making it easy to understand and maintain.
- **Error Handling**: Proper error handling should be implemented in a production environment to handle exceptions gracefully.
- **Documentation**: This README provides clear instructions on how to compile and use the program, as well as explanations of its functionality.

## Disclaimer

This password generator is provided as-is and should be used responsibly. While it employs secure practices for password generation and hashing, it is essential to implement additional security measures based on your application's specific requirements and environment.
