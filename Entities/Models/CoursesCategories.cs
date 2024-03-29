﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CoursesCategories
    {
        [Key]
        public int CategoryID {get; set;}
        public string CategoryName { get; set;}
        public string CategoryImage { get; set; }
        public string CategoryDescription { get; set; }
        public int TotalCourseNumber { get; set; }
    }
}