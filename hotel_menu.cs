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
			Console.WriteLine("1. vadapav         Rs 40./-");
			Console.WriteLine("2. sandwich        Rs 80./-");
			Console.WriteLine("3. dabeli          Rs 50./-");
			Console.WriteLine("4. puff            Rs 30./-");
			Console.WriteLine("5. pizza           Rs 250./-");
			Console.WriteLine("============================");
			Console.Write("Plese Select Item : ");
			i = Convert.ToInt32(Console.ReadLine());
			switch (i)
			{
				case 1:
					name[count] = "vadapav";
					price[count] = 40;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of vadapav is : {0} * 40 = {1} /-", q, q * 40);
					Console.WriteLine("=======================================================");
					count++;
					break;
				case 2:
					name[count] = "sandwich";
					price[count] = 80;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of sandwich is : {0} * 80 = {1} /-", q, q * 80);
					Console.WriteLine("========================================================");
					count++;
					break;
				case 3:
					name[count] = "dabeli";
					price[count] = 50;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of dabeli is : {0} * 50 = {1} /-", q, q * 50);
					Console.WriteLine("======================================================");
					count++;
					break;
				case 4:
					name[count] = "puff";
					price[count] = 30;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of puff is : {0} * 30 = {1} /-", q, q * 30);
					Console.WriteLine("====================================================");
					count++;
					break;
				case 5:
					name[count] = "pizzai";
					price[count] = 250;
					Console.WriteLine("Thank You for Chosing Item Plese Select Quntity:");
					q = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Your Price of pizza is : {0} * 250 = {1} /-", q, q * 250);
					Console.WriteLine("=======================================================");
					count++;
					break;
				default:
					Console.WriteLine("Sorry Please Select Valid Item");
      Console.Clear();
					continue;
			}
			quantity[count - 1] = q;
			total[count - 1] = price[count - 1] * quantity[count - 1];
			Console.Write("Do You Want to Order More (y/n): ");
			c = Convert.ToChar(Console.ReadLine());
			Console.Clear();
		}
		int[] item = new int[count];
		Console.WriteLine("Your Order is Successfully Placed");
		Console.WriteLine("=========Total Bill Generated=========");
		int grandtotal = 0;
		for (i = 0; i < count; i++)
		{
			item[i] = i + 1;
			Console.WriteLine( item[i] +". "+ name[i] + "  Quantity: " + quantity[i] + "  Total Price: " + total[i] + " /-");
			grandtotal = grandtotal + total[i];
		}
		Console.WriteLine("Grand Total Price is : " + grandtotal + " /-");
		Console.WriteLine("Thank You for Visiting our Hotel");
		Console.ReadLine();
	}
}