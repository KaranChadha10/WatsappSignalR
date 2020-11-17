using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Watsapp.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        //One To Many Relationship
        
        //One User Will have many messages
        public virtual ICollection<Message> Messages { get; set; }
    }
}
