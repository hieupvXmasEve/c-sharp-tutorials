namespace learn_csharp;

public class Person
{
    private readonly string lastName;

    public Person(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.lastName = lastName;
    }

    public string FirstName { get; }

    public void IntroduceMyself()
    {
        Console.WriteLine($"Hi, I'm {FirstName} {lastName}");
    }
}