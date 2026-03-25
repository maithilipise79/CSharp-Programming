using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject.Entity
{
    public class Room
    {
        public int RoomNo { get; set; }
        public double Rent {  get; set; }
        public int RoomMembers {  get; set; }

        public Room() { }
        public Room(int roomNo, double rent,int roomMembers)
        {
            RoomNo=roomNo;
            Rent = rent;
            RoomMembers=roomMembers;
        }

        public override string ToString()
        {
            return $"Room No :{RoomNo} , Rent :{Rent} , RoomMembers :{RoomMembers}";
        }
    }
}
