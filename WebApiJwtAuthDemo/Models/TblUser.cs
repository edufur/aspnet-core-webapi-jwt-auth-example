using System;
using System.Collections.Generic;

namespace WebApiJwtAuthDemo.Models
{
    public partial class TblUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSalt { get; set; }
        public string Password { get; set; }
    }
}
