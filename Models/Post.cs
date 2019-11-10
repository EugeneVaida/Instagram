using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Instagram.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public User UserId { get; set; }
        public List<Document> Documents { get; set; }
        public List<Comment> Comments { get; set; }
        public List<User> Likes { get; set; }
        public DateTime Created { get; set; }

        public Post()
        {
            Documents = new List<Document>();
            Comments = new List<Comment>();
        }
    }
}