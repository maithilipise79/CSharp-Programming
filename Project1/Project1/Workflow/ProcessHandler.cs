using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
 
    public class ProcessHandler
    {
        public static void OperationOnEntity<T>(Func<T> createEntity) where T : BaseEntity
        {
            char continueChoice;
            IRepository<T> repo = new Repository<T>();
            do
            {
                Console.WriteLine("\nFor which Operation do you want to perform operation : ");
                Console.WriteLine("\n1) Add Record \n2) Delete record \n3)Get record By Id \n4) Get All Record ");
                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Console.WriteLine("How Many Record Do you want to add :");
                        int count = Convert.ToInt32(Console.ReadLine());
                        for (int j = 1; j <= count; j++)
                        {
                            T entity = createEntity();
                            repo.Add(entity);
                            Console.WriteLine("\n------------------------\n");
                        }
                        break;



                    case 2:
                        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------\n");

                        Console.WriteLine("Enter Id for delete the record :");
                        long id = long.Parse(Console.ReadLine());

                        if (repo.Delete(id))
                            Console.WriteLine("Record deleted successfully");
                        else
                            Console.WriteLine($"No record found with Id {id}");

                        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
                        break;



                    case 3:
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
                        Console.WriteLine("Enter the ID to get record :");
                        long id1 = long.Parse(Console.ReadLine());
                        Console.WriteLine(repo.GetById(id1));
                        Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------\n");
                        break;



                    case 4:
                        Console.WriteLine("\n===============================================================================================================\n");
                        Console.WriteLine("All records are =>");
                        var result = repo.GetAll();
                        foreach (var n in result)
                        {
                            Console.WriteLine(n);
                        }
                        Console.WriteLine("\n==============================================================================================================\n\n");
                        break;


                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }


                Console.WriteLine("\nDo you want perform another operation Yes then entre Yes :");
                continueChoice = Console.ReadLine()[0];
            } while (continueChoice == 'Y' || continueChoice == 'y');


        }
    }
}
