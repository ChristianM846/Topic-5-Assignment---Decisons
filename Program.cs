namespace Topic_5_Assignment___Decisons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selection;
            Console.WriteLine("Hello, please choose one of the following programs:");
            Console.WriteLine("1 - Simple Banking Machine");
            Console.WriteLine("2 - Parking Garage Cost");
            Console.WriteLine("3 - Hurricane");
            Console.WriteLine("(Input the number corisponding to your selection)");

            while (!Int32.TryParse(Console.ReadLine(), out selection) || selection > 3)
            {
                Console.WriteLine("Good jon numbnut, it works");
            }

            if (selection == 1)
            {
                Banking();
            }
        }

        public static void Banking()
        {
            string selection;
            double balance, deposit, withdrawal, payment;
            balance = 150;
            Console.WriteLine("Hello, welcome to the Bank Of Blorb. Please input the name of your desired transaction:");
            selection = Console.ReadLine().Trim().ToUpper();
            Console.WriteLine(selection); //temporary
            if (selection == "DEPOSIT")
            {
                Console.WriteLine("deposit");
            }
            else if (selection == "WITHDRAWAL")
            {
                Console.WriteLine("withdrawal");
            }
            else if (selection == "BILL PAYMENT")
            {
                Console.WriteLine("You currently have an outstanding bill payment. How much would you like to pay:");
                if (Double.TryParse(Console.ReadLine(), out payment)) 
                {
                    if (payment <= balance - 0.75) 
                    {
                        balance = balance - payment - 0.75;
                        Console.WriteLine($"Your payment has been made. You new account balance is {balance}. Have a nice day");
                    }
                    else if (payment > balance - 0.75)
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"You cannot pay more then you have. Transaction cancelled. Your account balance is now {balance}");
                    }
                    else if (payment < 0)
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"Thought you could cheat the system? NOPE! Transaction cancelled. Your account balance is now {balance}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input, transaction cancelled, your account ballance is now {balance}");
                }
            }
            else if (selection == "ACCOUNT BALANCE UPDATE")
            {
                balance = balance - 0.75;
                Console.WriteLine($"Your current account balance is {balance}, have a nice day");
            }
            else
            {
                Console.WriteLine($"Invalid input, transaction cancelled, your account ballance is now {balance}");
            }

        }
    }
}