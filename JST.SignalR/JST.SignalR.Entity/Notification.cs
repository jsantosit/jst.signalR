using System;

namespace JST.SignalR.Entity
{
    public class Notification
    {
        public User User { get; set; }

        public String Content { get; set; }

        public DateTime SendDate { get; set; }

        public bool WasSeen { get; set; }
    }
}
