using System;

class HotelMenu
{
    static void Main()
    {
        int choice, quantity;
        int totalDishes = 0;
        double totalAmount = 0;
        char continueChoice = 'y';

        string hotelName = "Hotel Royal";
        string place = "Near St Depo,Amreli";
        string cashier = "Manager";
        int tokenNo = 694;
        int billNo = 197082;

        Console.WriteLine("=======================================");
        Console.WriteLine("           " + hotelName);
        Console.WriteLine("        " + place);
        Console.WriteLine("=======================================");

        Console.Write("Enter Customer Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("_________________________________________");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Date: " + DateTime.Now.ToString("dd/MM/yy HH:mm") + "      Pick Up");
        Console.WriteLine("Cashier: " + cashier + "           Bill No.: " + billNo);
        Console.WriteLine("Token No.: " + tokenNo);
        Console.WriteLine("________________________________________");

        Console.WriteLine("Item                 Qty     Amount");
        Console.WriteLine("________________________________________");
		Console.WriteLine("________________________________________");


        while (continueChoice == 'y')
        {
            Console.WriteLine("\n------------------------");
            Console.WriteLine("       HOTEL MENU       ");
			Console.WriteLine("------------------------\n");
            Console.WriteLine("________________________");
            Console.WriteLine("1. Tea       -> Rs. 10");
            Console.WriteLine("2. Coffee    -> Rs. 20");
            Console.WriteLine("3. Burger    -> Rs. 50");
            Console.WriteLine("4. Pizza     -> Rs. 100");
			Console.WriteLine("________________________");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            string itemName = "";
            double price = 0;

            switch (choice)
            {
                case 1:
                    itemName = "Tea";
                    price = 10;
                    break;

                case 2:
                    itemName = "Coffee";
                    price = 20;
                    break;

                case 3:
                    itemName = "Burger";
                    price = 50;
                    break;

                case 4:
                    itemName = "Pizza";
                    price = 100;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    continue;
            }

            double amount = price * quantity;

            totalAmount += amount;
            totalDishes += quantity;
			
            Console.WriteLine(itemName + "              " + quantity + "      Rs. " + amount);

            Console.Write("\nDo you want to continue? (y/n): ");
            continueChoice = Convert.ToChar(Console.ReadLine().ToLower());
        }

        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine("Total Qty : " + totalDishes);
        //Console.WriteLine("Sub Total : Rs. " + totalAmount);
        Console.WriteLine("_________________________________________");
        Console.WriteLine("Grand Total : Rs. " + totalAmount);
        Console.WriteLine("_________________________________________");
		Console.WriteLine("_________________________________________");
		Console.WriteLine("\n=======================================");
        Console.WriteLine("THANK YOU !! VISIT AGAIN !!");
        Console.WriteLine("=======================================");
    }
}
