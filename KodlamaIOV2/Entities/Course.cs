﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOV2.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
