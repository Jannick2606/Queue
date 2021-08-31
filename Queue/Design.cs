using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Design
    {
        public Design()
        {

        }
        public void Menu()
        {
            Queue q = new Queue();

            string design = "";
            string design2 = "";
            for (int i = 0; i < 55; i++)
            {
                design += "=";
                if (i % 4 == 0)
                    design2 += " ";
            }
            string retry = "yes";
            while (retry.Contains("y"))
            {
                Console.Clear();
                Console.WriteLine($"{design}\n");
                Console.WriteLine($"{design2}H1 Queue Operations Menu\n");
                Console.WriteLine($"{design}\n");
                Console.WriteLine("1. Add items");
                Console.WriteLine("2. Delete items");
                Console.WriteLine("3. Show the number of items");
                Console.WriteLine("4. Show min and max items");
                Console.WriteLine("5. Find an item");
                Console.WriteLine("6. Print all items");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Write the number on the menu you want to access ");

                int menu = int.Parse(Console.ReadLine());
                Console.Clear();
                    switch (menu)
                    {

                        case 1:
                        Console.WriteLine("How many numbers do you want to add?");
                        int amount = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the number(s) you want to add to the queue");
                        for (int i = 0; i < amount; i++)
                        {
                            q.Add(int.Parse(Console.ReadLine()));
                        }
                            break;
                        case 2:
                        Console.WriteLine("How many numbers do you want to add?");
                        amount = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the number(s) you want to add to the queue");
                        for (int i = 0; i < amount; i++)
                        {
                            q.Delete();
                        }
                            break;
                        case 3:
                            Console.WriteLine($"Number of items in queue: {q.Amount()}");
                            break;
                        case 4:
                        Console.WriteLine($"The biggest number in the queue is: {q.Max()}");
                        Console.WriteLine($"The smallest number in the queue is: {q.Min()}");
                        break;
                        case 5:
                            Console.WriteLine("What number are you looking for?");
                            Console.WriteLine(q.Find(int.Parse(Console.ReadLine())));
                            break;
                        case 6:
                            foreach (int index in q.PrintAll())
                                Console.WriteLine(index);
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }
                retry = Repeat();
            } 
        }
        public string Repeat()
        {
            Console.WriteLine("Do you want to go back to the menu?");
            return Console.ReadLine().ToLower();
        }
    }
}
