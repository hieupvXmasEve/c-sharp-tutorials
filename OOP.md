# Object-Oriented Programming (OOP)

## 1. Class và Object

- Lý thuyết:
- Class: Là một bản thiết kế (blueprint) để tạo ra các đối tượng. Nó định nghĩa thuộc tính (properties) và hành vi (methods) mà đối tượng sẽ có.
- Object: Là một thể hiện (instance) cụ thể của class, được tạo ra từ class bằng từ khóa new.
- Cách định nghĩa class và tạo instance:

```csharp
class Car
{
    public string Brand;    // Thuộc tính
    public int Speed;

    public void Drive()     // Phương thức
    {
        Console.WriteLine($"{Brand} is driving at {Speed} km/h.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();  // Tạo instance (object) từ class Car
        myCar.Brand = "Toyota";
        myCar.Speed = 120;
        myCar.Drive();          // Output: Toyota is driving at 120 km/h.
    }
}
```

## 2. Encapsulation (Đóng gói)

Lý thuyết:

- Đóng gói là cách ẩn chi tiết triển khai bên trong và chỉ cung cấp giao diện công khai thông qua các access modifiers:
    - public: Có thể truy cập từ mọi nơi.
    - private: Chỉ truy cập được trong cùng class.
    - protected: Truy cập được trong class và các class kế thừa.
    - internal: Chỉ truy cập được trong cùng assembly. (assembly là một tập hợp các file liên quan đến nhau)

Ví dụ:

```csharp
class Employee
{
    private string name;        // Thuộc tính private
    public int Age { get; set; } // Property với getter/setter

    public void SetName(string newName) // Phương thức public để thay đổi name
    {
        if (!string.IsNullOrEmpty(newName))
            name = newName;
    }

    public string GetName()     // Phương thức public để lấy name
    {
        return name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        emp.SetName("John");
        emp.Age = 30;
        Console.WriteLine($"Name: {emp.GetName()}, Age: {emp.Age}");
        // Output: Name: John, Age: 30
    }
}
```

## 3. Inheritance (Kế thừa)

Lý thuyết:

- Kế thừa cho phép một class (class con) thừa hưởng thuộc tính và phương thức từ class khác (class cha) bằng ký tự :.
- Từ khóa base dùng để gọi constructor hoặc phương thức của class cha.

Ví dụ:

```csharp
class Vehicle
{
    public string Brand;

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public void Start()
    {
        Console.WriteLine($"{Brand} is starting.");
    }
}

class Car : Vehicle
{
    public int Speed;

    public Car(string brand, int speed) : base(brand)
    {
        Speed = speed;
    }

    public void Drive()
    {
        Console.WriteLine($"{Brand} is driving at {Speed} km/h.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Honda", 150);
        myCar.Start();  // Output: Honda is starting.
        myCar.Drive();  // Output: Honda is driving at 150 km/h.
    }
}
```

## 4. Polymorphism (Đa hình)

Lý thuyết:

- Đa hình cho phép một hành vi có thể được thực hiện theo nhiều cách khác nhau:
    - Virtual/Override: Phương thức ảo trong class cha có thể bị ghi đè trong class con.
    - Interface: Định nghĩa một hợp đồng (contract) mà các class phải tuân theo.

Ví dụ 1: Virtual/Override

```csharp
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof Woof");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myDog = new Dog();
        myDog.MakeSound();  // Output: Woof Woof
    }
}
```

Ví dụ 2: Interface

```csharp
interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape circle = new Circle(5);
        Console.WriteLine($"Area: {circle.CalculateArea()}"); // Output: Area: 78.539...
    }
}
```

## 5. Abstraction (Trừu tượng)

Lý thuyết:

- Trừu tượng hóa giúp tập trung vào "cái gì" thay vì "làm thế nào".
- Abstract Class: Không thể tạo instance, chứa phương thức trừu tượng (không có thân).
- Interface: Chỉ chứa khai báo phương thức, không có triển khai.

Ví dụ:

```csharp
abstract class Shape
{
    public abstract double CalculateArea(); // Phương thức trừu tượng
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape rect = new Rectangle(4, 5);
        Console.WriteLine($"Area: {rect.CalculateArea()}"); // Output: Area: 20
    }
}
```
