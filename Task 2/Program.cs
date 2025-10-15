namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool Quit = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n===============================");
                Console.WriteLine("          Main Menu");
                Console.WriteLine("===============================");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("C - Clear the whole list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("===============================");
                Console.Write("==> ");
                Console.ResetColor();

                string choice = Console.ReadLine().ToUpper();
                Console.WriteLine();

                switch (choice)
                {
                    case "P":
                        PrintNumbers(numbers);
                        break;
                    case "A":
                        AddNumber(numbers);
                        break;
                    case "M":
                        DisplayMean(numbers);
                        break;
                    case "S":
                        DisplaySmallest(numbers);
                        break;
                    case "L":
                        DisplayLargest(numbers);
                        break;
                    case "F":
                        FindNumber(numbers);
                        break;
                    case "C":
                        ClearList(numbers);
                        break;
                    case "Q":
                        Quit = true;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("GoodBye - See you later!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Choice, Please try again later.");
                        Console.ResetColor();
                        break;
                }
            }
            while (!Quit);
        }

        static void PrintNumbers(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The List is empty");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"The List of numbers is: [{string.Join(", ", numbers)}]");
            }
        }

        static void AddNumber(List<int> numbers)
        {
            Console.WriteLine("Enter a number in the list: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers.Add(num);
                Console.WriteLine($"{num} is added");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, Please try again later.");
                Console.ResetColor();
            }
        }

        static void DisplayMean(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }

                int mean = sum / numbers.Count;
                Console.WriteLine($"The Mean of the List in number is: {mean}");
            }
        }

        static void DisplaySmallest(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int smallest = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (smallest > numbers[i])
                    {
                        smallest = numbers[i];
                    }
                }

                Console.WriteLine($"The Smallest of the List in number is: {smallest}");
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to find the smallest number because The List is empty");
                Console.ResetColor();
            }
        }

        static void DisplayLargest(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                int largest = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (largest < numbers[i])
                    {
                        largest = numbers[i];
                    }
                }

                Console.WriteLine($"The Largest of the List in number is: {largest}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to find the largest number because The List is empty");
                Console.ResetColor();
            }
        }

        static void FindNumber(List<int> numbers)
        {
            Console.WriteLine("Enter a number to find it in the list: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                bool found = false;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if(num == numbers[i]) 
                    { 
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{num} is not found in the List");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{num} is found in the List");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input, Please try again later.");
                Console.ResetColor();
            }
        }

        static void ClearList(List<int> numbers)
        {
            if (numbers.Count != 0)
            {
                numbers.Clear();
                Console.WriteLine("The List is cleared");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The List is already cleared");
                Console.ResetColor();
            }
        }
    }
}
