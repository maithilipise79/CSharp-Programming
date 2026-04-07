using Restaurant_Management_System.Entity;
using Restaurant_Management_System.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Workflow
{
    public class OperationHandler
    {
        public static async Task OperationProcess<T>(Func<T> createEntity) where T:BaseEntity
        {

            char ans;
            using var context = new Data.AppDbContext();
            var repo=new Repository<T>(context);


            do
            {
                Console.WriteLine("Which Operation Do You want To Perform ??\n1.Insertion\n2.Deletion\n3.GetAll \n4.GetById \n5.update \nEnter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nHow may Record do u want to insert :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            T entity = createEntity();
                            await repo.CreateAsync(entity);
                            Console.WriteLine("Record Successfully add");
                            Console.WriteLine("\n==============================\n");
                        }
                        Console.WriteLine("\n------------------------------------------------------------------------------------------\n");
                        break;

                    case 2:
                        Console.WriteLine("Enter Id to delete the record");
                        int id = Convert.ToInt32(Console.ReadLine());
                        bool result = await repo.DeleteAsync(id);
                        Console.WriteLine((result) ? "Record Successfully deleted" : "Record not fount ");
                        Console.WriteLine("\n------------------------------------------------------------------------------------------\n");
                        break;

                    case 3:
                        var resultList = await repo.GetAllAsync();
                        Console.WriteLine("\n------------------------------------------------------------------------------------------\n");
                        foreach (var n in resultList)
                        {
                            Console.WriteLine(n);
                        }
                        Console.WriteLine("\n------------------------------------------------------------------------------------------\n");
                        break;

                    case 4:
                        Console.WriteLine("Enter Id to get record :");
                        int recordId= Convert.ToInt32(Console.ReadLine());
                        var record= await repo.GetByIdAsync(recordId);
                       Console.WriteLine((record == null) ? "Record Not Found" : record);
                        Console.WriteLine("\n------------------------------------------------------------------------------------------\n");
                        break;

                    case 5:

                        Console.WriteLine("Enter id to update record :");
                        int updateId= Convert.ToInt32(Console.ReadLine());
                        T entity1=createEntity();
                        var updateResult=await repo.UpdateAsync(updateId,entity1);
                        Console.WriteLine((updateResult == null) ? "Id not found" : "Record Update Successfully ");
                        Console.WriteLine("\n------------------------------------------------------------------------------------------\n");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("\nDo you want to perform another operation If yes then Enter Yes :");
                ans = Console.ReadLine()[0];

            } while (ans == 'Y' || ans == 'y');


        }
    }
}
