//Declaring a namespace below
namespace ClassesPractice;

//below is the class within the scope of which Main() method is declared.
public class QuizExe
{
    //the Main method
    public static void Main()
    {
        QuizMaterial DriveQuiz = new QuizMaterial();
        DriveQuiz.TakeQuiz();
        DriveQuiz.ViewQuizScore();
    }
}
//Another class which describes the quiz
public class QuizMaterial
{
    //data members of this class 
    public string QuizName;
    public int NumOfQuestions;
    public int timeInSeconds;
    public int Score;

    //Constructor
    public QuizMaterial(){}

    //another method to start the quiz
    public void TakeQuiz()
    {
        Console.WriteLine("Please Enter your Name to continue >\r\n");
        String QuizPlayerName = Console.ReadLine();
        Console.WriteLine($"Hello {QuizPlayerName} ! Please select the quiz you want to play >");
      while(true)
      { 
        DisplayQuiz();
        String QuizChoice = Console.ReadLine();

        if (QuizChoice == "Quiz 1")
        {
            Quiz1();
            break;
        }
        else if (QuizChoice == "Quiz 2")
        {
            Quiz2();
            break;
        }
        else if (QuizChoice == "Quiz 3")
        {
            Quiz3();
            break;
        }
        else
        {
            Console.Write("Please try again with proper inputs !!");
            Console.Write("Or try in format Quiz 1 or Quiz 2 or Quiz 3\n");
        }
      }
    }

    public void DisplayQuiz()
    {
        Console.WriteLine("Quiz 1 : Places");
        Console.WriteLine("Quiz 2 : Famous Personality");
        Console.WriteLine("Quiz 3 : Maths");
    }

    public void Quiz1()
    {   
        QuizName = "Quiz 1 - Places";
        this.NumOfQuestions = 2;
        this.timeInSeconds = 60;
        this.Score = 0;
        Console.WriteLine($"Welcome in {QuizName}");
        Console.WriteLine($"You would be getting {NumOfQuestions} questions which must be completed in {timeInSeconds} seconds .");
        Console.WriteLine("Let's start :\n");
        Console.WriteLine("Ques 1 : Where is Taj Mahal situated ?\n");
        Console.WriteLine("A :  Agra ");
        Console.WriteLine("B : Uttrakhand\n");
        while (true)
        {
        string Choice = Console.ReadLine();

            if (Choice == "A")
            {
                Score = Score + 10;
                break;
            }
            else if (Choice == "B")
            {
                Score = 0;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input ! Try again either A or B \n");
            }
        }

        Console.WriteLine("Ques 2 :What is the Capital of India ?\n");
        Console.WriteLine("A :  Bhopal ");
        Console.WriteLine("B : New Delhi\n");
        while (true)
        {
            string Choice = Console.ReadLine();

            if (Choice == "A")
            {   
                Score += 0;
                break;
            }
            else if (Choice == "B")
            {
                Score+=10;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input ! Try again either A or B \n");
            }
        }

        Console.WriteLine("End of the quiz !" );

    }
    public void Quiz2()
    {
        QuizName = "Quiz 2 - Famous Personality";
        this.NumOfQuestions = 2;
        this.timeInSeconds = 90;
        this.Score = 0;
        Console.WriteLine($"Welcome in {QuizName}");
        Console.WriteLine($"You would be getting {NumOfQuestions} questions which must be completed in {timeInSeconds} seconds .");
        Console.WriteLine("Let's start :\n");
        Console.WriteLine("Ques 1 : Who is the  current Prime Minister Of India ?\n");
        Console.WriteLine("A :  Shri Narendra Modi ");
        Console.WriteLine("B : Arvind Kejriwal \n");
        while (true)
        {
            string Choice = Console.ReadLine();

            if (Choice == "A")
            {
                Score = Score + 10 ;
                break;
            }
            else if (Choice == "B")
            {
                Score = 0;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input ! Try again either A or B \n");
            }
        }

        Console.WriteLine("Ques 2 :Who won the olympic gold medal in Javelin Throw game for india under age 25  ?\n");
        Console.WriteLine("A :  Neeraj Chopra ");
        Console.WriteLine("B : Usain Bolt\n");
        while (true)
        {
            string Choice = Console.ReadLine();

            if (Choice == "A")
            {
                Score += 10;
                break;
            }
            else if (Choice == "B")
            {
                Score += 0;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input ! Try again either A or B \n");
            }
        }

        Console.WriteLine("End of the quiz !");
    }
    public void Quiz3()
    {
        QuizName = "Quiz 3 - Maths";
        this.NumOfQuestions = 2;
        this.timeInSeconds = 180;
        this.Score = 0;
        Console.WriteLine($"Welcome in {QuizName}");
        Console.WriteLine($"You would be getting {NumOfQuestions} questions which must be completed in {timeInSeconds} seconds .");
        Console.WriteLine("Let's start :\n");
        Console.WriteLine("Ques 1 : What is 1 + 2 ?\n");
        Console.WriteLine("A :  3 ");
        Console.WriteLine("B : 30\n");
        while (true)
        {
            string Choice = Console.ReadLine();

            if (Choice == "A")
            {
                Score = Score + 10;
                break;
            }
            else if (Choice == "B")
            {
                Score = 0;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input ! Try again either A or B \n");
            }
        }

        Console.WriteLine("Ques 2 :What is 2 * 3 ?\n");
        Console.WriteLine("A :  20 ");
        Console.WriteLine("B : 6\n");
        while (true)
        {
            string Choice = Console.ReadLine();

            if (Choice == "A")
            {
                Score += 0;
                break;
            }
            else if (Choice == "B")
            {
                Score += 10;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input ! Try again either A or B \n");
            }
        }

        Console.WriteLine("End of the quiz !");
    }


    public void ViewQuizScore()
    {
        Console.WriteLine($"You Scored : - {Score} / 20 \n");
        if (Score == 0)
        {
            Console.WriteLine("Better Luck Next time !");
        }
        else if (Score == 20)
        {
            Console.WriteLine("Max Score Win ! Wohoo!!!");
        }
        else
        {
            Console.WriteLine("well Good Score ! Keep it up");
        }
    }
}