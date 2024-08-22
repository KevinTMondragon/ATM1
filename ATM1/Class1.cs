using System;


namespace ATM1
{
    public class Class1
    {
        static void Main () 
        {
            int balance = 0;
            int pin = 123456789;

            string Name = "Life Programming";

            Console.WriteLine("Welcome to the LP ATM," + Name);
            Console.WriteLine("1. Show Balance");
            Console.WriteLine("2. Withdraw funds");
            Console.WriteLine("3. Add funds");
            Console.WriteLine("4. Chnage PIN");
            Console.WriteLine("5. Help");
            Console.WriteLine("Select one of the options");

            int Choice = Convert.ToInt32(Console.ReadLine());

            while (true) 
            {
                if (Choice == 1)
                {
                    Console.WriteLine("Enter PIN to them balance...");
                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Your Balance: $" + balance);
                    }

                }
                if (Choice == 2)
                {
                    Console.WriteLine("Enter Pin to withdraw funds...");
                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Your Balance $" + balance);
                        Console.WriteLine("Enter amount to withdraw");

                        int Amount = Convert.ToInt32(Console.ReadLine());

                        if (Amount == balance)
                        {
                            Console.WriteLine("Removed: $" + Amount);
                            balance = Amount;

                        }
                        else
                        {
                            Console.WriteLine("ERROR! Can't remove more money that you have!");
                        }
                    }
                }
                if (Choice == 3)
                {
                    Console.WriteLine("Enter PIN to add funds...");
                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Your Balance: $" + balance);
                        Console.WriteLine("Enter amount to add");

                        int AmountToAdd = Convert.ToInt32(Console.ReadLine());
                        balance += AmountToAdd;
                        Console.WriteLine("Yout Balnce: $" + balance);
                    }
                }
                if (Choice == 4)
                {
                    Console.WriteLine("Enter PIN to continue...");
                    int PinInput = Convert.ToInt32(Console.ReadLine());

                    if (PinInput == pin)
                    {
                        Console.WriteLine("Enter new Pin:");

                        int NewPin = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Chnaged PIN from: " + pin + " to " + NewPin);
                        pin = NewPin;
                    }
                }
                if (Choice == 5)
                {
                    Console.WriteLine();
                }
            }

           
        }

    }
}
