using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Instructors
    {
        [Key]
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string InstructorDescription { get; set; }
        public string AreaOfExpertise { get; set; }

    }
}
