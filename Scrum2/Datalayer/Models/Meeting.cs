using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer.Models
{
    /**
     * Ett Meeting är en faktisk mötesbokning, som ska visas i kalendern.
     */
    public class Meeting
    {
        public int MeetingId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }

        public virtual User Organizer { get; set; }
        public virtual HashSet<Invite> Invited { get; set; }

    }
}
