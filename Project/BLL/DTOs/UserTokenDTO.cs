using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserTokenDTO
    {
        public string TKey { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? ExpiredTime { get; set; }
        public string UserId { get; set; }
        //public string Type { get; set; }
    }
}