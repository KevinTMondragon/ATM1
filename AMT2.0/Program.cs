using System;


namespace ATM1
{
    public class Program
    {
        static void Main()
        {
            bool isProgramRunnning = true;
            double balance = 0;
            int pin = 123456789;

            string Name = "Life Programming";

            Console.WriteLine("Welcome to the LP ATM," + Name);
           

            while (isProgramRunnning)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("******************************************");
                Console.WriteLine(" What do you want to do ?");
                Console.WriteLine("1. Show Balance");
                Console.WriteLine("2. Withdraw funds");
                Console.WriteLine("3. Add funds");
                Console.WriteLine("4. Change PIN");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Select one of the options");


                int Choice = Convert.ToInt32(Console.ReadLine());

                if (Choice == 1)
                {
                    Console.WriteLine("Enter PIN to them balance...");
                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine("Your Balance: $" + balance);
                        Console.WriteLine();
                    }

                }
                if (Choice == 2)
                {
                    Console.WriteLine("Enter Pin to withdraw funds...");
                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your Balance $" + balance);
                        Console.WriteLine();
                        Console.WriteLine("Enter amount to withdraw");
                        Console.WriteLine();

                        double Amount = Convert.ToDouble(Console.ReadLine());

                        if (Amount <= balance)
                        {
                            Console.WriteLine("Withdraw: $" + Amount);
                           
                            balance = balance - Amount;
                            Console.WriteLine("Here the Amount: $" + balance);
                        }
                        else
                        {
                            Console.WriteLine("ERROR! Can't remove more money that you have!");
                        }
                    }
                }
                if (Choice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter PIN to add funds...");
                    Console.WriteLine();

                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Your Balance: $" + balance);
                        Console.WriteLine("Enter amount to add");

                        double AmountToAdd = Convert.ToDouble(Console.ReadLine());
                        balance += AmountToAdd;
                        Console.WriteLine("Yout Balnce: $" + balance);
                    }
                }
                if (Choice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter PIN to continue...");
                    Console.WriteLine();

                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Enter new Pin:");

                        int NewPin = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Changed PIN from: " + pin + " to " + NewPin);
                        pin = NewPin;
                    }
                }
                if (Choice == 5)
                {

                    Console.WriteLine();
                    Console.WriteLine(" To Exit Press Q");
                    
                    var KeyInput = Console.Read();
                    char letter = Convert.ToChar(KeyInput);
                    if (letter.ToString().ToLower() == "q") 
                    {
                        isProgramRunnning = false;
                    }
                   
                }
            }


        }

    }
}
