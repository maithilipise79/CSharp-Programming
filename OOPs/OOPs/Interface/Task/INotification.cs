using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOPs.Interface.Task
{
    //Build a notification system that can send messages through multiple platforms.
    internal interface INotification
    {
        void SendNotification();
    }

    public class WhatsApp:INotification
    { 
        public void SendNotification()
        {
            Console.WriteLine("173 Batch meeting scheduled at 7 PM.");
        }
    }

    public class LinkedIn:INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("You have a new connection request.");
        }
    }

    public class Instagram : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Someone commented on your post ");
        }
    }

}
