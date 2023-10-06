using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            Console.WriteLine("Binary Tree:");
            while (true)
            {
                Console.WriteLine("1. Insert value");
                Console.WriteLine("2. Search value");
                Console.WriteLine("3. Delete value");
                Console.WriteLine("4. Exit");

                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter a value to insert: ");
                        int valueToInsert = int.Parse(Console.ReadLine());
                        tree.Insert(valueToInsert);
                        break;
                    case 2:
                        Console.Write("Enter a value to search: ");
                        int valueToSearch = int.Parse(Console.ReadLine());
                        bool found = tree.Search(valueToSearch);
                        if (found)
                        {
                            Console.WriteLine("The value is found in the tree.");
                        }
                        else
                        {
                            Console.WriteLine("The value is not found in the tree.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter a value to delete: ");
                        int valueToDelete = int.Parse(Console.ReadLine());
                        tree.Delete(valueToDelete);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}
