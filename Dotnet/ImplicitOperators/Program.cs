// Client
var request = new UserRequest("John", 30);

User user = request;

UserResponse response = user;

Console.WriteLine($"Name: {response.Name}, Age: {response.Age}");


// Product
public class User
{
    public string Name { get; set; }
    public int Age { get; set; }

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Factory method
    public static implicit operator User(UserRequest request)
        => new User(request.Name, request.Age);

    // Factory method
    public static implicit operator UserResponse(User user)
        => new UserResponse(user.Name, user.Age);
}

public record UserRequest(string Name, int Age);
public record UserResponse(string Name, int Age);
