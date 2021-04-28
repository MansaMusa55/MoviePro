﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Crew
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CrewId { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        //Profile Image
        [Display(Name = "Profile Pic")]
        public byte[] Profile { get; set; }
        public string ContentType { get; set; }
        public Movie Movie { get; set; }

    }
}
