using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC.Ass2
{

    public enum BadgeTier
    {
        Standard,
        VIP
    }
    internal class Badge
    {
        public int Id { get; set; }
        public string CredentialNumber { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;
    }
}
