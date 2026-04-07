using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System.Entity.Restaurant
{
    public class TableReservation:BaseEntity
    {
        public int TableNumber {  get; set; }
        public int NumberOfGuests {  get; set; }
        public DateTime Date {  get; set; }
        public DateTime Time {  get; set; }

        public override string ToString()
        {
            return $"Reservation [Id :{base.Id} ,Table Number :{TableNumber} ,Number of Guests:{NumberOfGuests} , Date: {Date} ,Time: {Time} ]";
        }

    }
}
