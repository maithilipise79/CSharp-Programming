using Restaurant_Management_System.Entity.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.EntityBuilder
{
    public class EntityBuilder
    {
        public static Customer CustomerBuilder()
        {
            Console.WriteLine("Enter Customer Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter phone :");
            string phone = Console.ReadLine();

            return new Customer { Name = name, Address = address, Phone = phone };
        }



        public static MenuItem MenuItemBuilder()
        {
            Console.WriteLine("Enter Dish Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enyer Category :");
            string category = Console.ReadLine();
            Console.WriteLine("Enter Price :");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            return new MenuItem { Name = name, Category = category, Price = price };

        }


        public static Delivery DeliveryBuilder()
        {
            Console.WriteLine("Enter Delivery Person :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Delivery Address :");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Contact Number :");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Status :");
            string status = Console.ReadLine();

            return new Delivery { DeliveryPersonName = name, Address = address, ContactNumber = phone, Status = status };
        }



        public static Staff StaffBuilder()
        {
            Console.WriteLine("Enter Staff Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Role :");
            string role = Console.ReadLine();
            Console.WriteLine("Enter Salary :");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Phone No :");
            string phone= Console.ReadLine();

            return new Staff {Name=name, Role=role,Salary=salary ,Phone=phone};
        }


        public static Order OrderBuilder()
        {
            Console.WriteLine("Enter Quantity :");
            int quantity=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price :");
            decimal price= Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Status :");
            string status = Console.ReadLine();
            decimal totalAmount = quantity * price;

            return new Order { Quantity=quantity,Price=price,Status=status, TotalAmount=totalAmount};
        }


        public static Feedback FeedbackBuilder()
        {
            Console.WriteLine("Enter Customer Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Comment :");
            string comment = Console.ReadLine();
            Console.WriteLine("Enter rating out of 10 ");
            int rating = Convert.ToInt32(Console.ReadLine());

            return new Feedback { CustomerName = name, Comments = comment, Rating = rating };

        }


        public static TableReservation TableReservationBuilder()
        {
            Console.WriteLine("Enter Table Number :");
            int tableNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Guests :");
            int guestsNo = Convert.ToInt32(Console.ReadLine());
            DateTime date = DateTime.Now;

            return new TableReservation { TableNumber = tableNo, NumberOfGuests = guestsNo, Date = date, Time = date };
        }
    }

}
