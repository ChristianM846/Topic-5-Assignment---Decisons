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
            Console.WriteLine("(Input the number corresponding to your selection)");

            while (!Int32.TryParse(Console.ReadLine(), out selection) || selection > 3)
            {
                Console.WriteLine("That is not a valid input. Please input the number that corresponds to your choice");
            }

            if (selection == 1)
            {
                Banking();
            }
            else if (selection == 2)
            {
                ParkingGarage();
            }
            else if (selection == 3)
            {
                Hurricane();
            }
        }

        public static void Banking()
        {
            string selection;
            double balance, deposit, withdrawal, payment;
            balance = 150;
            Console.WriteLine("Hello, welcome to the Bank Of Blorb. Please input the name of your desired transaction:");
            selection = Console.ReadLine().Trim().ToUpper();
            if (selection == "DEPOSIT")
            {
                Console.WriteLine("Please select the amount you would like to deposit:");
                if (Double.TryParse(Console.ReadLine(), out deposit))
                {
                    Math.Round(balance, 2);
                    balance = balance + deposit - 0.75;
                    Console.WriteLine($"Your deposit of {deposit.ToString("C")} has been made. Your account balance is now {balance.ToString("C")}");
                }
                else
                {
                    balance = balance - 0.75;
                    Console.WriteLine($"Invalid input, transaction cancelled. Your account balance is now {balance.ToString("C")}");
                }
            }
            else if (selection == "WITHDRAWAL")
            {
                Console.WriteLine("How much would you like to withdrawal:");
                if (Double.TryParse(Console.ReadLine(), out withdrawal))
                {
                    if (withdrawal < 0)
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"You cannot withdraw a negative amount, transaction cancelled. Your account balance is now {balance.ToString("C")}");
                    }
                    else if (withdrawal <= balance - 0.75)
                    {
                        Math.Round(withdrawal, 2);
                        balance = balance - withdrawal - 0.75;
                        Console.WriteLine($"Your withdrawl of {withdrawal.ToString("C")} has been completed. Your account balance is now {balance.ToString("C")}. Have a nice day.");
                    }
                    else if (withdrawal > balance - 0.75)
                    {
                        Console.WriteLine($"You cannot withdraw more then you have, transaction cancelled. Your account balance is now {balance.ToString("C")}");
                    }
                }
                else
                {
                    balance = balance - 0.75;
                    Console.WriteLine($"Invalid input, transaction cancelled. Your account ballance is now {balance.ToString("C")}");
                }
            }
            else if (selection == "BILL PAYMENT")
            {
                Console.WriteLine("You currently have an outstanding bill payment. How much would you like to pay:");
                if (Double.TryParse(Console.ReadLine(), out payment)) 
                {
                    if (payment < 0)
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"Thought you could cheat the system? NOPE! Transaction cancelled. Your account balance is now {balance.ToString("C") }");
                    }
                    else if (payment <= balance - 0.75) 
                    {
                        Math.Round(payment, 2);
                        balance = balance - payment - 0.75;
                        Console.WriteLine($"Your payment has been made. Your new account balance is {balance.ToString("C")}. Have a nice day");
                    }
                    else if (payment > balance - 0.75)
                    {
                        balance = balance - 0.75;
                        Console.WriteLine($"You cannot pay more then you have. Transaction cancelled. Your account balance is now {balance.ToString("C")}");
                    }
                    
                }
                else
                {
                    balance = balance - 0.75;
                    Console.WriteLine($"Invalid input, transaction cancelled, your account ballance is now {balance.ToString("C")}");
                }
            }
            else if (selection == "ACCOUNT BALANCE UPDATE")
            {
                balance = balance - 0.75;
                Console.WriteLine($"Your current account balance is {balance.ToString("C")}, have a nice day");
            }
            else
            {
                Console.WriteLine($"Invalid input, transaction cancelled, your account ballance is now {balance.ToString("C")}");
            }

        }

        public static void ParkingGarage()
        {
            double minutes, fee;
            Console.WriteLine("Thank you choosing Sam's parking garage. How many minutes were you parked:");

            while (!Double.TryParse(Console.ReadLine(),out minutes) || minutes <= 0)
            {
                Console.WriteLine("I'm sorry, that's not a valid input. Please try again:");
            }

            Math.Round(minutes, 2);

            if (minutes > 0 && minutes <= 60)
            {
                fee = 4;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 60 && minutes <= 120)
            {
                fee = 6;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 120 && minutes <= 180)
            {
                fee = 8;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 180 && minutes <= 240)
            {
                fee = 10;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 240 && minutes <= 300)
            {
                fee = 12;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 300 && minutes <= 360)
            {
                fee = 14;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 360 && minutes <= 420)
            {
                fee = 16;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 420 && minutes <= 480)
            {
                fee = 18;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
            else if (minutes > 480)
            {
                fee = 20;
                Console.WriteLine($"You have parked {minutes} minutes. Your fee is {fee.ToString("C")}");
            }
        }

        public static void Hurricane()
        {
            Console.WriteLine("Hello");
        }
    }
}