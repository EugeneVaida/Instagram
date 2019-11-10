using System.ComponentModel.DataAnnotations.Schema;

namespace Instagram.Models
{
    [NotMapped]
    public class Subscription
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int SubscriberId { get; set; }
        public User Subscriber { get; set; }
    }
}
