using CollectionProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Helper.RoomHelper
{
    public class RoomNoWiseSort : IComparer<Room>
    {
        public int Compare(Room? x, Room? y)
        {
            return x.RoomNo.CompareTo(y.RoomNo);
        }
    }
}
