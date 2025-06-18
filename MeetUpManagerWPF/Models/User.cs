using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetUpManagerWPF.Models
{
    public class User
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        

        public string UserRoleId { get; set; } = string.Empty;
        public UserRole? UserRole { get; set; }



        public ICollection<Event> Events { get; set; } = default!;
    }
}
