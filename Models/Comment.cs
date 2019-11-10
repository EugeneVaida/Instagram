using System;
using System.ComponentModel.DataAnnotations;

namespace Instagram.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public Post PostId { get; set; }
        public User UserId { get; set; }
        public DateTime Created { get; set; }
        public string Message { get; set; }
    }
}
