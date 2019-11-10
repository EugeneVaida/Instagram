using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Models
{
    public enum Gender
    {
        Male,
        Female
    }
    
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public List<Subscription> Subscribers { get; set; }
        public DateTime Created { get; set; }

        public User()
        {
            Created = DateTime.Today;
        }
    }
}
