using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ContactUs
    {
        [Key]
        public int ContactId { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string TwitterAccount { get; set; }
        public string FacebookAccount { get; set; }
        public string YoutubeAccount { get; set; }
        public string LinkedInAccount { get; set; }
    }
}
