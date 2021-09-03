using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        //Protected can be inherited from this class, and any class that inherits from this class.
        public int Id { get; set; }
        public string UserName { get; set; }

       
    }
}
