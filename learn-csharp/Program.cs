// using learn_csharp;
//
// // var student = new Student("John son", "6j0dH@example.com", "password", "001");
// // student.Login();
// // student.JoinCourse("Lập trình C#");
//
// // Tạo danh sách người dùng
// var users = new User[]
// {
//     new Student("John son", "6j0dH@example.com", "password", "001"),
//     new Teacher("Teacher", "6j0dH@example.com", "password", "002")
// };
// var participants = new ILearningActivity[]
// {
//     new Student("John son", "6j0dH@example.com", "password", "001"),
//     new Teacher("Teacher", "6j0dH@example.com", "password", "002")
// };
//
// foreach (var participant in participants) participant.ParticipateInActivity();
// // Gọi phương thức SubmitFeedback trên từng đối tượng
// foreach (var user in users) user.SubmitFeedback();
//
// var student = new Student("John son", "6j0dH@example.com", "password", "001");
// student.DisplayRole();
//
// var customers = new Queue<string>();
// customers.Enqueue("Khách 1");
// customers.Enqueue("Khách 2");
// customers.Enqueue("Khách 3");
//
// Console.WriteLine("Xử lý khách:");
// while (customers.Count > 0)
// {
//     var nextCustomer = customers.Dequeue(); // Lấy ra từ đầu
//     Console.WriteLine($"Đang phục vụ: {nextCustomer}");
// }
//
// var actions = new Stack<string>();
// actions.Push("Viết chữ"); // Thêm vào đỉnh
// actions.Push("Xóa chữ");
// actions.Push("Thêm ảnh");
//
// Console.WriteLine("Hoàn tác các hành động:");
// while (actions.Count > 0)
// {
//     var lastAction = actions.Pop(); // Lấy ra từ đỉnh
//     Console.WriteLine($"Hoàn tác: {lastAction}");
// }
//
// (double X, double Y) point = (3.5, 7.2);
// Console.WriteLine($"Tọa độ: ({point.X}, {point.Y})");
//

internal class Program
{
    private static void Main()
    {
        var userPerms = Permissions.Read | Permissions.Write; // Kết hợp quyền
        Console.WriteLine($"Quyền của người dùng: {userPerms}");

        // Kiểm tra quyền
        if ((userPerms & Permissions.Read) == Permissions.Read) Console.WriteLine("Có quyền đọc.");
    }

    [Flags]
    private enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
}