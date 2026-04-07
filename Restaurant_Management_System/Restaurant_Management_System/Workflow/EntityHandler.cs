using Restaurant_Management_System.Entity.EntityBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Workflow
{
    public class EntityHandler
    {
        public static async Task EntityHandlerProcess()
        {
            char ans;
            do
            {

                Console.WriteLine("For Which section do you want to perform opearation ??\n1.Customer\n2.MenuItem\n3.Staff\n4.Order\n5.Delivery\n6.Feedback\n7.TableReservation");
                int choice=Convert.ToInt32(Console.ReadLine());

                switch (choice)
                { 
                    case 1:await OperationHandler.OperationProcess(EntityBuilder.CustomerBuilder);
                        break;

                    case 2:await OperationHandler.OperationProcess(EntityBuilder.MenuItemBuilder);
                        break;

                    case 3:await OperationHandler.OperationProcess(EntityBuilder.StaffBuilder);
                        break;

                    case 4:await OperationHandler.OperationProcess(EntityBuilder.OrderBuilder);
                        break;

                    case 5:await OperationHandler.OperationProcess(EntityBuilder.DeliveryBuilder);
                        break;

                    case 6:await OperationHandler.OperationProcess(EntityBuilder.FeedbackBuilder);
                        break;

                    case 7:await OperationHandler.OperationProcess(EntityBuilder.TableReservationBuilder);
                        break;
                }









                Console.WriteLine("\n------------------------------------------------------------------------------------------\n");
                Console.WriteLine("\n Do u want to perform operation for another Section If Yes then Enter Yes :");
                ans = Console.ReadLine()[0];
            } while (ans == 'Y' || ans == 'y');
        }
    }
}
