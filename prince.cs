using System;

class menu
{
    static void Main(String[] a)
    {
        int i = 0;
        int q = 0;
        char c = 'y';
        int count = 0;

        int[] price = new int[100];
        int[] total = new int[100];
        String[] name = new String[100];
        int[] quantity = new int[100];

        while (c == 'y' || c == 'Y')
        {
            Console.WriteLine("=========Hotel Menu=========");
            Console.WriteLine();
            Console.WriteLine("no item name        price");
            Console.WriteLine("1. Cold Tea        Rs 20./-");
            Console.WriteLine("2. Coffee          Rs 50./-");
            Console.WriteLine("3. Burger          Rs 80./-");
            Console.WriteLine("4. Dhosa           Rs 150./-");
            Console.WriteLine("5. Pizza           Rs 250./-");
            Console.WriteLine("============================");

            Console.Write("Please Select Item : ");
            i = Convert.ToInt32(Console.ReadLine());

            string selectedName = "";
            int selectedPrice = 0;

            switch (i)
            {
                case 1:
                    selectedName = "Cold Tea";
                    selectedPrice = 20;
                    break;

                case 2:
                    selectedName = "Coffee";
                    selectedPrice = 50;
                    break;

                case 3:
                    selectedName = "Burger";
                    selectedPrice = 80;
                    break;

                case 4:
                    selectedName = "Dhosa";
                    selectedPrice = 150;
                    break;

                case 5:
                    selectedName = "Pizza";
                    selectedPrice = 250;
                    break;

                default:
                    Console.WriteLine("Sorry Please Select Valid Item");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
            }

            Console.Write("Select Item Quantity: ");
            q = Convert.ToInt32(Console.ReadLine());

            // CHECK DUPLICATE ITEM
            int foundIndex = -1;
            for (int j = 0; j < count; j++)
            {
                if (name[j] == selectedName)
                {
                    foundIndex = j;
                    break;
                }
            }

            // IF ITEM ALREADY EXISTS THEN ADD QUANTITY
            if (foundIndex != -1)
            {
                quantity[foundIndex] += q;
                total[foundIndex] = quantity[foundIndex] * price[foundIndex];
            }
            else
            {
                name[count] = selectedName;
                price[count] = selectedPrice;
                quantity[count] = q;
                total[count] = price[count] * quantity[count];
                count++;
            }

            Console.WriteLine("\nItem Added Successfully!");
            Console.Write("Do You Want to Order More (y/n): ");
            c = Convert.ToChar(Console.ReadLine());

            Console.Clear();
        }

        Console.WriteLine("Your Order is Successfully Placed");
        Console.WriteLine("================================              Total Bill Generated              ================================");
        Console.WriteLine();

        int grandtotal = 0;

        Console.WriteLine("   ITEMS_NAME\t\tITEM_PRICE\t\tQUANTITY\t\tTOTAL_PRICE\n");

        for (i = 0; i < count; i++)
        {
            Console.WriteLine((i + 1) + ". " + name[i] +
                              "\t\tPrice: " + price[i] +
                              "\t\tQuantity: " + quantity[i] +
                              "\t\tTotal Price: " + total[i] + " /-");

            grandtotal += total[i];
        }

        Console.WriteLine("------------------------------------------------------------------------------------------------");
        Console.WriteLine("Grand Total Price is : " + grandtotal + " /-");
        Console.WriteLine("------------------------------------------------------------------------------------------------");
        Console.WriteLine("=========================================");
        Console.WriteLine("  THANK YOU !! VISIT AGAIN IN FUTURE !!");
        Console.WriteLine("=========================================");

        Console.ReadLine();
    }
}
