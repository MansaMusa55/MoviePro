using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePro.Models
{
    public class Cast
    {
        public int Id { get; set; }
        [Display(Name="Movie")]
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }

        //Profile Image
        [Display(Name = "Profile Pic")]
        public byte[] Profile { get; set; }

        public string ContentType { get; set; }

        public Movie Movie { get; set; }
       
    }
}
