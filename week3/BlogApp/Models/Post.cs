using System;
using System.ComponentModel.DataAnnotations;

namespace BlogAPP.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
