// Parallel.For(0, 5, i =>
// {
//     Console.WriteLine($"Xử lý phần tử {i} trên thread {Task.CurrentId}");
//     Thread.Sleep(1000); // Giả lập công việc
// });
//
// Console.WriteLine("Hoàn thành!");
// Parallel.Invoke(
//     () => DoWork("Công việc 1"),
//     () => DoWork("Công việc 2"),
//     () => DoWork("Công việc 3")
// );
//
// void DoWork(string name)
// {
//     Console.WriteLine($"{name} đang chạy...");
//     Thread.Sleep(1000);
//     Console.WriteLine($"{name} hoàn thành!");
// }

// using System.Reflection;
//
// internal class Person
// {
//     private int age;
//     public string Name { get; set; }
//
//     public void SayHello()
//     {
//         Console.WriteLine($"Hello, I'm {Name}");
//     }
// }
//
// internal class Program
// {
//     private static void Main()
//     {
//         var type = typeof(Person);
//
//         Console.WriteLine("Tên class: " + type.Name);
//         Console.WriteLine("Namespace: " + type.Namespace);
//
//         // Lấy danh sách các property
//         PropertyInfo[] properties = type.GetProperties();
//         Console.WriteLine("Properties:");
//         foreach (var prop in properties) Console.WriteLine($"- {prop.Name} ({prop.PropertyType})");
//
//         // Lấy danh sách các field (bao gồm private)
//         FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
//         Console.WriteLine("Fields:");
//         foreach (var field in fields) Console.WriteLine($"- {field.Name} ({field.FieldType})");
//
//         // Lấy danh sách các method
//         MethodInfo[] methods = type.GetMethods();
//         Console.WriteLine("Methods:");
//         foreach (var method in methods) Console.WriteLine($"- {method.Name}");
//     }
// }

// public class Timer
// {
//     // EventHandler không có tham số dữ liệu tùy chỉnh
//     public event EventHandler OnTick;
//
//     public void Start()
//     {
//         Console.WriteLine("Timer bắt đầu...");
//         OnTick?.Invoke(this, EventArgs.Empty);
//     }
// }
//
// internal class Program
// {
//     private static void Main()
//     {
//         var timer = new Timer();
//         timer.OnTick += TimerTick;
//         timer.Start();
//     }
//
//     private static void TimerTick(object sender, EventArgs e)
//     {
//         Console.WriteLine("Tick từ timer!");
//     }
// }

public class CustomEventArgs : EventArgs
{
    public CustomEventArgs(string message)
    {
        Message = message;
    }

    public string Message { get; }
}

public class Timer
{
    public event EventHandler<CustomEventArgs> OnTick;

    public void Start()
    {
        OnTick?.Invoke(this, new CustomEventArgs("Timer đã tick!"));
    }
}

internal class Program
{
    private static void Main()
    {
        var timer = new Timer();
        timer.OnTick += TimerTick;
        timer.Start();
    }

    private static void TimerTick(object sender, CustomEventArgs e)
    {
        Console.WriteLine("Tick: " + e.Message);
    }
}