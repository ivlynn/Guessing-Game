using System; //przesyłam mini gierkę, niestety git mnie irytował, więc przepisałam do fiddle

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(2, 21); 

        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("The program has drawn a secret number from 2 to 20.");//od 2 bo musi być suma dwóch liczb
        Console.WriteLine("Your task is to enter two numbers and the program will check whether their sum equals the secret number.");

        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int sum = firstNumber + secondNumber;

        if (sum == secretNumber)
        {
            Console.WriteLine("Great! The sum of the numbers you entered ({firstNumber} and {secondNumber}) is equal to the secret number ({secretNumber}).");
        }
        else
        {
            Console.WriteLine($"Unfortunately, the sum of the numbers you entered ({firstNumber} and {secondNumber}) does not equal the secret number ({secretNumber}).");
        }
    }
}