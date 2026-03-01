using Project1.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class EntityInputBuilder
    {

        //1Product

        public static Product CreateProduct()
        {
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Price ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter StockQuantity");
            int quantity = Convert.ToInt32(Console.ReadLine());

            return new Product { Name = name, Price = price, StockQuantity = quantity };
        }

        //2 Payment

        public static Payment CreatePayment()
        {
            Console.WriteLine("Enter amount ");
            double amount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Payment Mode :");
            string paymentMode = Console.ReadLine();
            Console.WriteLine("Enter Payment Method");
            string paymentMethod = Console.ReadLine();

            return new Payment { Amount = amount, PaymentMode = paymentMode, PaymentMethod = paymentMethod };
        }
        //3.Customer

        public static Customer CreateCustomer()
        {
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number");
            long mobileNo = long.Parse(Console.ReadLine());

            return new Customer { Name = name, Address = address, MobileNo = mobileNo };
        }
        //4.Category
        public static Category CreateCategory()
        {
            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Number of Product ");
            int numberofProduct = Convert.ToInt32(Console.ReadLine());
            return new Category { Name = name, NumberOfProduct = numberofProduct };
        }
        //5.Delivary
        public static Delivery CreateDelivery()
        {
            Console.WriteLine("Enter Delivery Address :");
            string deliveryAddress = Console.ReadLine();
            Console.WriteLine("Enter Delivery City ");
            string deliveryCity = Console.ReadLine();
            Console.WriteLine("Status");
            string status = Console.ReadLine();

            return new Delivery { DeliveryAddress = deliveryAddress, DeliveryCity = deliveryCity, Status = status };
        }
        //6. Discount
        public static Discount CreateDiscount()
        {
            Console.WriteLine("Enter Discount code :");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Discount Percentage  :");
            int discountPercentage = int.Parse(Console.ReadLine());

            return new Discount { Code = code, DiscountPercent = discountPercentage };
        }
        //7.Invoice
        public static Invoice CreateInvoice()
        {
            Console.WriteLine("Enter Customer Name :");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter Total Amount :");
            double totalAmount = double.Parse(Console.ReadLine());

            return new Invoice { CustomerName = customerName, TotalAmount = totalAmount };
        }
        //8.Order
        public static Order CreateOrder()
        {
            Console.WriteLine("Enter Total Amount :");
            double totalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Item Count :");
            int itemCount = int.Parse(Console.ReadLine());

            return new Order { TotalAmount = totalAmount, ItemCount = itemCount };
        }
        //9. ReturnRequest
        public static ReturnRequest CreateReturnRequest()
        {
            Console.WriteLine("Enter reason:");
            string reason = Console.ReadLine();
            Console.WriteLine("request :");
            string request = Console.ReadLine();

            return new ReturnRequest { Reason = reason, RequestDate = request };
        }
        //10.Review
        public static Review CreateReview()
        {
            Console.WriteLine("Enter Product Name :");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter Customer Name :");
            string customer = Console.ReadLine();
            Console.WriteLine("Enter rating out of 5 :");
            int rating = int.Parse(Console.ReadLine());

            return new Review { ProductName = productName, CustomerName = customer, Rating = rating };
        }

        //11.Shipment

        public static Shipment CreateShipment()
        {
            Console.WriteLine("Enter Carrier Name :");
            string carrier = Console.ReadLine();
            Console.WriteLine("Enter Tracking Number :");
            int trackingNumber = int.Parse(Console.ReadLine());

            return new Shipment { Carrier = carrier, TrackingNumber = trackingNumber };
        }

        //12. Supplier
        public static Supplier CreateSupplier()
        {
            Console.WriteLine("Enter Supplier Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Contact Number :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();

            return new Supplier { SupplierName = name, ContactNo = number, Address = address };
        }

        //13. Warehouse
        public static Warehouse CreateWarehouse()
        {
            Console.WriteLine("Enter Warehouse Location :");
            string location = Console.ReadLine();
            Console.WriteLine("Enter WareHouse Capacity :");
            int capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Manager Name :");
            string name = Console.ReadLine();

            return new Warehouse { Location = location, Capacity = capacity, ManagerName = name };
        }

        //14.WishList
        public static WishList CreateWishList()
        {
            Console.WriteLine("Enter Item Count :");
            int itemCount = int.Parse(Console.ReadLine());

            return new WishList { ItemCount = itemCount };
        }
    }
}
