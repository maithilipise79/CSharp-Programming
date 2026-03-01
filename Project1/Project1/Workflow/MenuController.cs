using System;
using System.Collections.Generic;
using Project1.EntityClass;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class MenuController

    {

        public static void Process()
        {
            char ans;
            do
            {
                Console.WriteLine("For which class do you want to perform operation : ");
                Console.WriteLine("\n1) Product \n2) Payment \n3) Customer\n4) Category\n5) Delivery\n6) Discount\n7) Invoice\n8) Order\n9) ReturnRequest \n10) Review \n11) Shipment \n12) Supplier \n13) Warehouse \n14) Wishlist");
                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateProduct);
                        break;

                    case 2:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreatePayment);
                        break;

                    case 3:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateCustomer);
                        break;

                    case 4:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateCategory);
                        break;

                    case 5:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateDelivery);
                        break;

                    case 6:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateDiscount);
                        break;

                    case 7:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateInvoice);
                        break;

                    case 8:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateOrder);
                        break;

                    case 9:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateReturnRequest);
                        break;

                    case 10:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateReview);
                        break;

                    case 11:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateShipment);
                        break;  
                    case 12:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateSupplier);
                        break;
                    case 13:
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateWarehouse);
                        break;  
                    case 14 :   
                        ProcessHandler.OperationOnEntity(EntityInputBuilder.CreateWishList);
                        break;

                    default: Console.WriteLine("Invalid Choice");
                        break;



                }

                Console.WriteLine("\n================================================================================================================\n");

                Console.WriteLine("Do you want perform opeartion for another class if Yes then entre Yes :");
                ans = Console.ReadLine()[0];

            } while (ans == 'Y' || ans == 'y');






        }


    }
}
