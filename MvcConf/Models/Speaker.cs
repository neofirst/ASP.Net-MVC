using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcConf.Models
{
    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
    }
}