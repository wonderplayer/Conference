using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Conference.Models
{
    public class Session
    {
        public int SessionID { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        [DataType(DataType.MultilineText)]
        public string Abstract { get; set; }

        public int SpeakerID { get; set; }

        public virtual Speaker Speaker { get; set; }
    }
}