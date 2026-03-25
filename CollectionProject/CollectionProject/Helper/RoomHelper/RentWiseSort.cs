using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.RoomHelper
{
    public class RentWiseSort : IComparer<Room>
    {
        public int Compare(Room? x, Room? y)
        {
            return x.Rent.CompareTo(y.Rent);
        }
    }
}
