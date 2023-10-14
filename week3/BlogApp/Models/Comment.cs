using System;
using System.ComponentModel.DataAnnotations;

namespace BlogAPP.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public int PostId { get; set; }

        [Required]
        public string Text { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
