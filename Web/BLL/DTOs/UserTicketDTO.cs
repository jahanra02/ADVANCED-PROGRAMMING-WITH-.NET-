using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserTicketDTO : UserDTO
    {
        public List<TicketDTO> Tickets { get; set; }
        public UserTicketDTO()
        {
            Tickets = new List<TicketDTO>();
        }
    }
}
