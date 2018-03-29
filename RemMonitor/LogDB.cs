using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RemMonitor
{
    public class LogDB
    {
        [Key]
        public int RecID { get; set; }

        public string TopicName { get; set; }
        public DateTime DateStamp { get; set; }


    }
}
