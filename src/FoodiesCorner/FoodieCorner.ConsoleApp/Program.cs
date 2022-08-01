namespace NewClass;
class ExeThis
{
    public static int Sum(int a , int b)
    {
        int SumOf2 = a + b;

        return SumOf2;
    } 
    public static void Main()
    {
        Car Car1 = new Car("BMW" , "Blue" , 12 , true);
        Car1.StateOfCar = true;
        Car1.Start();
        Car1.stop();
        int plus =Sum(1 , 5);
        Console.WriteLine(plus);

        Car Car2 = new();

        Car Car3 = new();

        Car3.Input();

    }
}

 public class Car
{
    public string BrandName;
    public string Color;
    public int Cost;
    public bool StateOfCar;

    public Car()
    {
        BrandName = "Audi";
        Color = "Black";
        Cost = 1;
        StateOfCar = true;
    }

    public Car(string brandName, string color, int cost, bool stateOfCar)
    {
        BrandName = brandName;
        Color = color;
        Cost = cost;
        StateOfCar = stateOfCar;
    }

    public void Start()
    {
        if (StateOfCar == true)
        {
            Console.WriteLine("The car is already on");
        }
        else
        {
            Console.WriteLine("The car is heating on");
            StateOfCar = true;
        }
    }

    public void stop()
    {
        if (StateOfCar == false)
        {
            Console.WriteLine("The car is stopped");
        }
        else
        {
            Console.WriteLine("Apply the brakes");
            StateOfCar= false;  
        }
    }

    public void Input()
    {
        StateOfCar = true;
        Console.WriteLine("Enter Brand Name Of Car : \n");
        BrandName = Console.ReadLine();

        Console.WriteLine("Enter Color Of Car : \n");
        Color = Console.ReadLine();

        Console.WriteLine("Enter Cost Of Car : \n");
        Cost =Convert.ToInt32( Console.ReadLine());
    }

    
}

