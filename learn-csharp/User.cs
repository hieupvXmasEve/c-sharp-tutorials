namespace learn_csharp;

public abstract class User
{
    public User(string name, string email, string password)
    {
        Name = name;
        Email = email;
        Password = password;
    }

    public string Name { get; set; }
    public string Email { get; set; }
    protected string Password { get; set; } // protected - chỉ có trong class và các class kế thừa

    public void Login()
    {
        Console.WriteLine($"{Name} đã đăng nhập bằng email: {Email}");
    }

    public virtual void SubmitFeedback()
    {
        Console.WriteLine($"{Name} đã gửi phản hồi chung.");
    }

    // Phương thức trừu tượng, lớp con phải triển khai
    public abstract void DisplayRole();
}