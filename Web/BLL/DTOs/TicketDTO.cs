using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TicketDTO
    {
        public string TicketId { get; set; }
        public string SeatNumber { get; set; }
        public int TicketPrice { get; set; }
        public string Date { get; set; }
        public string ShowTime { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public string UserId { get; set; }
        public int Id { get; set; }



    }
}
