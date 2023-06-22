namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1:

            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int? userInput = null; 
            int i = 1;  

            Console.WriteLine("Try to guess my favorite number between 1 and 1000");

            do
            {
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("too low");
                    Console.WriteLine("Try to guess again");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("too high");
                    Console.WriteLine("Try to guess again");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {i} attempts!!!");
                }
                i++;
            }
            while (userInput != favNumber);
        }
    }
}
