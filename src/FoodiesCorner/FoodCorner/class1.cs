using System;
namespace FoodieCorner.Backend;

public class Execute
{
    public static void Main()
    {
        Loops loops = new Loops();
        loops.ForLoop();
    }
}

public class Loops
{
    string FirstName;
    public Loops() { }

    public void ForLoop()
    {  
            
            Loops[] newArr = new Loops[3];
            newArr[0] = new Loops();
            newArr[1] = new Loops();
            newArr[2] = new Loops();
            newArr[0].FirstName = "Aamir";
            newArr[1].FirstName = "Sushmit";
            newArr[2].FirstName = "Abhi";

           for (int i = 0; i < 3; i++)
        {
            Console.WriteLine( newArr[i].FirstName );
        }
           for(int j = 0; j < 3; j++)
        {
            Loops abc = newArr[j];
            string someVar = new String( abc.FirstName );
            Console.WriteLine(someVar);
        }
        foreach (Loops loop in newArr)
        {
            Console.WriteLine(loop.FirstName);
        }
    }
}