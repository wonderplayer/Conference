using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Conference.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Speaker")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        public virtual List<Session> Sessions { get; set; }
    }
}