//Objective - Create classes and execute
//copyright@AamirKhan
using System;
using System.Diagnostics;
using System.Threading;

namespace WeeKendPractice;

public class AssignmentClass
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n --- Weekend Practice Tasks --- ");
        Console.WriteLine("\n>>> Code cpr@ Aamir Khan ");
        //Calculation of Perimeter and area execution calls

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("------------------------------------------------------------------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*** Task 1 *** \n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Perimeter of Rectangle = 2(Height + Width)");
        Console.WriteLine("Area of Rectangle = Height * Width\n");
        Console.ForegroundColor = ConsoleColor.White;
        Perimeter P = new Perimeter();
        P.Pmeter();
        P.Area();

        //student class execution calls

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n------------------------------------------------------------------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" *** Task 2 ***\n ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(">>> You are now executing student class \n");
        Console.ForegroundColor = ConsoleColor.White;
        Student student = new Student();
        student.InsertData();
        student.DisplayData();

        //Sum of next num SumOfFourthPower class execution calls

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" *** Task 3 *** \n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(">>> You are now executing Task 3 -sum of next and Stopwatch class <<<\n");
        Console.ForegroundColor = ConsoleColor.White;
        SumOfFourthPower sumOfNext = new SumOfFourthPower();
        sumOfNext.GetInputs();

    }
}

//Perimeter and Area - Task 1 cpr@AamirKhan
public class Perimeter
{
    int Height;
    int Width;
    int pmeter;
    int area;

    public Perimeter(){}

    public void Pmeter()
    {
        //Perimeter of Rectangle = 2(Height + Width)
        Console.Write("Enter Height of Rectangle in cms : ");
        Height = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Width of Rectangle in cms : ");
        Width = Convert.ToInt32(Console.ReadLine());
        pmeter = 2 * (Height + Width);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\nPerimeter of Rectangle of Height : {Height} cm and Width : {Width} cm is {pmeter} cm.");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void Area()
    {
        area = (Height * Width);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"\nArea of Rectangle of Height: {Height} cm and width: {Width} cm is {area} cm\u00b2.");
        Console.ForegroundColor=ConsoleColor.White;
    }
}

//Student Class - Task 2 cpr@AamirKhan
public class Student
{
    string Name;
    int Age;
    string Standard;
    string StudentId;


    public Student(){}
    
    public void InsertData()
    {
        
        Console.Write("Enter Name : ");
        this.Name=Console.ReadLine();
        Console.Write("\nEnter Age : ");
        this.Age=Convert.ToInt32(Console.ReadLine());
        Console.Write("\nEnter Standard : ");
        this.Standard=Console.ReadLine();
        Guid guid = Guid.NewGuid();
        this.StudentId = guid.ToString();
    }

    public void DisplayData()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"\n Name \t\t Age\t Standard \t\t StudentId \n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"\n {Name}\t\t {Age}\t {Standard}\t\t {StudentId} \n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n------------------------------------------------------------------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

//Math Class Calculation and Stopwatch  - Task 3 cpr@AamirKhan 
public class SumOfFourthPower
{
    double num;
    double Sum;
    public SumOfFourthPower() { }

    public void GetInputs()
    {
        Console.Write("Enter a number between 1 to 50 : ");
        while (true)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if(num >=1 && num <= 50)
            {
                for (double i = (num+1); i<=(num+10); i++)
                {
                    if (i < num + 10)
                    {
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        Console.Write($"{i}\x2074 + ");
                    }
                    else
                    {  
                        Console.OutputEncoding = System.Text.Encoding.UTF8;
                        Console.Write($"{i}\x2074 ");
                    }
                   
                    Sum = (Sum+Math.Pow(i, 4));
                    
                }
                DisplayResult();

                stopwatch.Stop();
                Console.ForegroundColor=ConsoleColor.Cyan;
                Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n------------------------------------------------------------------------------------------------\n");
                Console.ForegroundColor = ConsoleColor.White;

                break;
            }
            else
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid Input , Enter a number only between 1 to 50\n");
                Console.ForegroundColor= ConsoleColor.White;

            }
        }
    }
    public void DisplayResult()
    {
        Console.WriteLine($"= {Sum} ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n------------------------------------------------------------------------------------------------\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
}