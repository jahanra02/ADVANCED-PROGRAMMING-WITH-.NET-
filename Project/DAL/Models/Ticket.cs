using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Ticket
    {
        [Key]
        public string TicketId { get; set; }
        public string SeatNumber { get; set; }
        public int TicketPrice { get; set; }
        public string Date { get; set; }
        public string ShowTime { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }


        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual User User { get; set; }


      
    }
}
