namespace learn_csharp;

public class Teacher : User, ILearningActivity
{
    public Teacher(string name, string email, string password, string teacherId)
        : base(name, email, password)
    {
        TeacherId = teacherId;
    }

    public string TeacherId { get; set; }


    public void ParticipateInActivity()
    {
        Console.WriteLine($"{Name} tham gia giảng dạy.");
    }

    public void CreateCourse(string courseName)
    {
        Console.WriteLine($"{Name} (ID: {TeacherId}) đã tạo khóa học {courseName}");
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} là giảng viên.");
    }
}