namespace learn_csharp;

public class Student : User, ILearningActivity
{
    public Student(string name, string email, string password, string studentId) : base(name, email, password)
    {
        StudentId = studentId;
    }

    public string StudentId { get; set; }

    public void ParticipateInActivity()
    {
        Console.WriteLine($"{Name} tham gia làm bài tập.");
    }


    public void JoinCourse(string courseName)
    {
        Console.WriteLine($"{Name} (ID: {StudentId}) đã tham gia khóa học {courseName}");
    }

    public override void SubmitFeedback()
    {
        Console.WriteLine($"{Name} đã gửi phản hồi về hệ thống.");
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"{Name} là sinh viên.");
    }
}