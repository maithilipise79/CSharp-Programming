
using EmployeeManagement.MODELS;
using EmployeeMangement.Builder;
using EmployeeMangement.Services;

Console.WriteLine("For which class to u want to perform opeartion :\n1. Employee \n2. Department \n Enter choice");
int choice =Convert.ToInt32(Console.ReadLine());
var empService = new EmployeeService();
var deptService = new DepartmentService();

switch (choice)
{
    case 1:
        {
           
            char answer;
            do
            {
                Console.WriteLine("Which Operation do u want to perform for Employee \n1.Add \n2.View \n3.Update \n4.Delete \n Enter your choice :");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        empService.Add(EntityBuilder.EmployeeBuilder());
                        break;

                    case 2:
                        var result = empService.GetAll();
                        result.ForEach(x => Console.WriteLine(x));
                        break;

                    case 3:
                        Console.WriteLine("Enter id to update record :");
                        int id=Convert.ToInt32((string)Console.ReadLine());
                        Console.WriteLine("Enter name to update :");
                        string name=Console.ReadLine();
                        Console.WriteLine("Enter department id to update ");
                        int dptId=Convert.ToInt32((string)Console.ReadLine());
                        Console.WriteLine("Enter salary for thr update");
                        decimal salary=Convert.ToDecimal(Console.ReadLine());
                        empService.Update(new Employee(id,name,dptId,salary));
                        break;

                    case 4:
                        Console.Write("Id: ");
                        empService.Delete(int.Parse(Console.ReadLine()));
                        break;

                    default:
                        Console.WriteLine("Invalid choice ");
                        break;


                    
                }
                Console.WriteLine("Dou want to perform another opeartion if yes then enter yes :");
                answer = Console.ReadLine()[0];

            } while( answer=='y'||answer=='Y');

        }

        break;




    case 2:
        {
            
            char ans;
            do
            {

                Console.WriteLine("Which Operation do u want to perform for Department \n1.Add \n2.View \n3.Update \n4.Delete \n Enter your choice :");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        deptService.Add(EntityBuilder.DepartmentBuilder());
                        break;

                    case 2:
                        var result = deptService.GetAll();
                        result.ForEach(x => Console.WriteLine(x));
                        break;

                    case 3:
                        Console.WriteLine("Enter id for the update :");
                        int id= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name to update :");
                        string name= Console.ReadLine();
                        deptService.Update(new Department(id,name));
                        break;

                    case 4:
                        Console.WriteLine("Enter id to delete record :");
                        deptService.Delete(int.Parse(Console.ReadLine()));
                        break;

                    default:
                        Console.WriteLine("Invalid choice ");
                        break;

                }

                Console.WriteLine("Dou want to perform another opeartion if yes then enter yes :");
                ans = Console.ReadLine()[0];
            } while (ans == 'Y' || ans == 'y');
        }
        break;



     default: Console.WriteLine("Inavlid choice ");
        break;
}
