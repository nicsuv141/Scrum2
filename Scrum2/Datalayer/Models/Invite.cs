using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Models
{
    public class Invite
    {
        public int InviteId { get; set; }
        public User InvitedUser { get; set; }
        public bool Accepted { get; set; }
        public DateTime AcceptedTime { get; set; }
    }
}
