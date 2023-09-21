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
            Console.WriteLine("It works");
        }
    }
}