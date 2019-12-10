using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Would you like to play the higher/lower game? (Yes/No)");
//         string userInput = Console.ReadLine();

//         if (userInput == "No")
//         {
//             Console.WriteLine("Goodbye!");
//         }
//         else 
//         {
//             Console.WriteLine("Pick a number from 1 to 100");
//             int start = 1;
//             int end = 100;
//             int number = 50;

//             while (true) {
//                 Console.WriteLine("Is your number higher or lower than " +  number + "? (higher/lower/correct)");
//                 string answerInput = Console.ReadLine();
//                 if (answerInput == "Higher")
//                 {
//                     start = number;
//                     number = (end - start)/2 + start;
//                 } 
//                 else if (answerInput == "Lower") {
//                     end = number;
//                     number = (end-start)/2 +start;
//                 } 
//                 else if (answerInput == "Correct") {
//                     Console.WriteLine("Great! I guessed your number.");
//                     break;
//                 }
//             }
//             Main();

//         }
        
//     }

// }

class Program
{
    static void Main()
    {
        Console.WriteLine("Would you like to play the Higher/Lower game? (Yes/No)");
        string userInput = Console.ReadLine();

        if (userInput == "No")
        {
            Console.WriteLine("Goodbye!");
        }
        else if (userInput == "Yes")
        {
            Console.WriteLine("Pick a number from 1 to 100");
            int start = 1;
            int end = 100;
            Random rnd = new Random();
            int number = rnd.Next(start, end);

            while (true) {
                Console.WriteLine("Is your number higher or lower than " +  number + "? (Higher/Lower/Correct)");
                string answerInput = Console.ReadLine();
                if (answerInput == "Higher")
                {
                    start = number+1;
                    number = rnd.Next(start, end);
                } 
                else if (answerInput == "Lower") {
                    end = number-1;
                    number = rnd.Next(start, end);
                } 
                else if (answerInput == "Correct") {
                    Console.WriteLine("Great! I guessed your number.");
                    break;
                }
            }
            Main();
        }
        else 
        {
             Console.Error.WriteLine("Error. Wrong input. Try again.");
        }
    }
}