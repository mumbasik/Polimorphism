using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Polimorphism
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public int age { get; set; }
        public double Speed { get; set; }

        public Animal(string name, double weight, int age, double speed)
        {
            Name = name;
            Weight = weight;
            this.age = age;
            Speed = speed;
        }
        public  virtual void Print()
        {
            Console.WriteLine("Name: " +  Name);
            Console.WriteLine("Weight: " +  Weight);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Speed: " + Speed);
        }

    }
    class Tiger : Animal
    {
     
        public string color { get; set; }
        public Tiger(string color, string name, double weight, int age, double speed) : base(name, weight, age, speed)
        {
            this.color = color;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Color: " +  color);

        }

    }
    class Crododile : Animal
    {
        public int lenght { get; set; }
        public Crododile(int lenght, string name, double weight, int age, double speed) : base(name, weight, age, speed)
        {
            this.lenght = lenght;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Lenght: " + lenght);

        }
    }

    class Kangoroo : Animal
    {
        public double jumpDistance { get; set; }
        public Kangoroo(double j, string name, double weight, int age, double speed) : base(name, weight, age, speed)
        {
            this.jumpDistance = j;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("jumpDistance: " + jumpDistance);

        }
    }


    //N2
    class Worker
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string state { get; set; }

        public Worker(string name, int age, string state)
        {
            Name = name;
            Age = age;
            this.state = state;
        }
        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("State: " + state);

        }
    }
    class President: Worker
    {
        public President(string name, int age, string state) : base(name, age, state) { }
        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("State: " + state);
        }
    }
    class Security : Worker
    {
        public Security(string name, int age, string state) : base(name, age, state) { }
        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("State: " + state);
        }
    }
    class Manager : Worker
    {
        public Manager(string name, int age, string state) : base(name, age, state) { }
        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("State: " + state);
        }
    }
    class Engineer : Worker
    {
        public Engineer(string name, int age, string state) : base(name, age, state) { }
        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("State: " + state);
        }
    }
    //N3
    abstract class Vehicle
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public int countofSits { get; set; }

        public Vehicle(string name, string type, int countofSits)
        {
            Name = name;
            Type = type;
            this.countofSits = countofSits;
        }
        public abstract void Print();
    }
    class Car : Vehicle
    {
       public int countofWheels {  get; set; }
       public Car(int countofWheels, string name, string type, int countofSits): base(name, type, countofSits) 
        {
            this.countofWheels = countofWheels;
        }
        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Count of sits: " + countofSits);
            Console.WriteLine("Count of Wheels: " + countofSits);
        }
    }
    class Plane: Vehicle
    {
        public int powerofNitro {  get; set; }
        public Plane(int powerofNitro, string name, string type, int countofSits): base(name, type, countofSits)        {
            this.powerofNitro = powerofNitro;
        }
        public override void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Count of sits: " + countofSits);
            Console.WriteLine("Power of nitro: " + powerofNitro);
        }
    }

    //N4
    abstract class Equation 
    {
     public int A {  get; set; }
     public int B { get; set; }
        public Equation(int a, int b)
        {
            A = a;
            B = b;
        }
        public abstract void Result();
    }
    
    class Linear : Equation
    {
        public Linear(int a, int b): base(a, b) { }
        public override void Result() {

            if (A == 0 || B == 0) {
                Console.WriteLine("Нельзя делить на ноль");
            }
            else
            {
                double X = (double)-B / A;
                Console.WriteLine("Решение линейного уравнения: x = " + X);
            }
        }
    }
    //N5
    abstract class MyVehicle
    {
        public double Paymant { get; set; }
        public int Carrying { get; set; }

       

        public int Gas { get; set; }

        public int CountOfSits {  get; set; }
        public MyVehicle( double payment, int carrying,  int count, int gas)
        {
            Paymant = payment;
            Carrying = carrying;
            
            CountOfSits = count;
            Gas = gas;
        }
        public void Input()
        {
            Paymant = Convert.ToDouble(Console.ReadLine());
            Carrying = Convert.ToInt32(Console.ReadLine());
            Gas = Convert.ToInt32(Console.ReadLine());
            CountOfSits = Convert.ToInt32(Console.ReadLine());
        }
        public void OutPut()
        {
            Console.WriteLine("Payment: " + Paymant);
            Console.WriteLine("Carrying: " + Carrying);
            Console.WriteLine("Gas: " +  Gas);
            Console.WriteLine("Count of sits: " +  CountOfSits);
        }
        public abstract void InputOutPut();
        public abstract int GaS();
        public abstract double GetPayment ();

        public abstract void SetPayment();

        public abstract int GetCarrying();

        public abstract int GetCount();
    }

    class Train: MyVehicle
    {
        public Train(double payment, int carrying,  int count, int gas) : base(payment, carrying,  count, gas) { }
        public override void InputOutPut()

        {
            Console.WriteLine("Train.");
            base.Input();
            base.OutPut();
        }
        public override int GaS()
        {
            Console.WriteLine("Gas needed");
            return Gas;
        }
        public override double GetPayment()
        {
            Console.WriteLine("Current Payment: ");
            return Paymant;
        }
        public override void SetPayment()
        {
            Console.WriteLine("Eneter Payment: ");
            Paymant = Convert.ToDouble(Console.ReadLine());
        }
        public override int GetCarrying()
        {
            Console.WriteLine("This machine can handle: ");
            return Carrying;
        }
        public override int GetCount()
        {
            Console.WriteLine("Count of seats for people: ");
            return CountOfSits;
        }
    }

    class Bus : MyVehicle
    {
        public Bus(double payment, int carrying, int count, int gas) : base(payment, carrying, count, gas) { }

        public override void InputOutPut()

        {
            Console.WriteLine("Bus.");
            base.Input();
            base.OutPut();
        }
        public override int GaS()
        {
            Console.WriteLine("Gas needed");
            return Gas;
        }
        public override double GetPayment()
        {
            Console.WriteLine("Current Payment: ");
            return Paymant;
        }
        public override void SetPayment()
        {
            Console.WriteLine("Eneter Payment: ");
            Paymant = Convert.ToDouble(Console.ReadLine());
        }
        public override int GetCarrying()
        {
            Console.WriteLine("This machine can handle: ");
            return Carrying;
        }
        public override int GetCount()
        {
            Console.WriteLine("Count of seats for people: ");
            return CountOfSits;
        }
    }


    abstract class Geometric
    {
        public abstract double Area();
        public abstract double Perimeter();
    }

    class Triangle : Geometric
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double H { get; set; }

        public Triangle(double a, double b, double c, double h)
        {
            A = a;
            B = b;
            C = c;
            H = h;
        }

        public override double Area()
        {
            return 0.5 * A * H;
        }

        public override double Perimeter()
        {
            return A + B + C;
        }
    }

    class Square : Geometric
    {
        public double A { get; set; }

        public Square(double a)
        {
            A = a;
        }

        public override double Area()
        {
            return A * A;
        }

        public override double Perimeter()
        {
            return 4 * A;
        }
    }

    class Rhombus : Geometric
    {
        public double A { get; set; }
        public double H { get; set; }

        public Rhombus(double a, double h)
        {
            A = a;
            H = h;
        }

        public override double Area()
        {
            return A * H;
        }

        public override double Perimeter()
        {
            return 4 * A;
        }
    }

    class Rectangle : Geometric
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double Area()
        {
            return A * B;
        }

        public override double Perimeter()
        {
            return 2 * (A + B);
        }
    }

    class Circle : Geometric
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Composite : Geometric
    {
        private List<Geometric> shapes = new List<Geometric>();

        public void AddShape(Geometric shape)
        {
            shapes.Add(shape);
        }

        public override double Area()
        {
            return shapes.Sum(shape => shape.Area());
        }

        public override double Perimeter()
        {
            return shapes.Sum(shape => shape.Perimeter());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            Animal[] obj = new Animal[]
            {
                new Tiger("White", "Tiger", 120.90, 5, 60.00),
                new Crododile(5, "Crocodile", 80.20, 9, 20.00),
                new Kangoroo(15.0, "Kangoroo", 50.00, 4, 40.00)
            };
            foreach(var animals in obj) {
            
                animals.Print();
            
            }
            Console.WriteLine();
            //N2
            Worker[] obj2 = new Worker[] {

                new President("Ivan", 45, "President"),
                new Security("Andrey", 21, "Security Engineer"),
                new Manager("Vanya", 25, "Market Manager"),
                new Engineer("Anatoly", 31, "Software Engineer"),

            };
            foreach (var workers in obj2)
            {
                workers.Print();
            }
            //N3
            Console.WriteLine();
            Vehicle obj3 = new Car(4, "Name", "Road", 4);
            Vehicle obj4 = new Plane(20, "Plane", "Fly", 70);
            obj3.Print();
            obj4.Print();
            Console.WriteLine();
            //N4
            Equation obj5 = new Linear(3, 6);
            obj5.Result();
            Console.WriteLine();
            //N5
            MyVehicle obj6 = new Train(20.9, 400, 365, 1000);
            obj6.InputOutPut();
            obj6.SetPayment();
            Console.WriteLine("Payment: " + obj6.GetPayment());
            Console.WriteLine("Gas: " + obj6.GaS());
            Console.WriteLine("Carrying: " + obj6.GetCarrying());
            Console.WriteLine("Count of seats: " + obj6.GetCount());
            MyVehicle obj7 = new Bus(23.6, 20, 15, 200);
            obj7.InputOutPut();
            obj7.SetPayment();
            Console.WriteLine("Payment: " + obj6.GetPayment());
            Console.WriteLine("Gas: " + obj6.GaS());
            Console.WriteLine("Carrying: " + obj6.GetCarrying());
            Console.WriteLine("Count of seats: " + obj6.GetCount());
            //N6
            Triangle triangle = new Triangle(3, 4, 5, 2);
            Square square = new Square(4);
            Rhombus rhombus = new Rhombus(4, 3);
            Rectangle rectangle = new Rectangle(4, 6);
            Circle circle = new Circle(5);

            
            Composite composite = new Composite();

           
            composite.AddShape(triangle);
            composite.AddShape(square);
            composite.AddShape(rhombus);
            composite.AddShape(rectangle);
            composite.AddShape(circle);

           
            Console.WriteLine("Total Area: " + composite.Area());
            Console.WriteLine("Total Perimeter: " + composite.Perimeter());

        }
    }
}
