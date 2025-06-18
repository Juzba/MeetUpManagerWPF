using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetUpManagerWPF.Models
{
    public class UserRole
    {
        public string Id { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;


        public ICollection<User> Users { get; set; } = default!;
    }
}
