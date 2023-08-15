using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public string UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        
        [Required]
        public int UserPhone { get; set; }
        [Required]
        public string UserGender { get; set; }
        [Required]
        public string UserPassword { get; set; }
        public string Type { get; set; }

        

    }
}